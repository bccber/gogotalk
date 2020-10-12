前段时间看到一篇博文《[可在广域网部署运行的即时通讯系统 -- GGTalk总览（附源码下载）](https://www.cnblogs.com/justnow/p/3382160.html)》,他是用C#实现的即时通讯系统，功能强大，界面漂亮。  就想用golang重写服务端，把代码下载回来，发现通信框架用的是ESFramework，我没用过也不知道ESFramework的协议，重写是不行的了，只能把原作者的客户端界面扣出来，自己写一个，客户端是C#+protobuf, 服务端是golang+protobuf,动起手来才发现，功能细节实在太多了，没精力搞下去了，就权当protobuf的学习例子吧。

**一、协议**

```
4个字节的长度 + 4个字节的包长 + protobuf数据包

	// 登录的请求和响应
	LoginRequestCMD  uint32 = 1
	LoginResponseCMD uint32 = 2

	// 注册用户的请求和响应
	RegisterRequestCMD  uint32 = 3
	RegisterResponseCMD uint32 = 4

	// 获取朋友列表的请求和响应
	GetFriendsRequestCMD  uint32 = 5
	GetFriendsResponseCMD uint32 = 6

	// 用户下线请求 和 通知
	UserOfflineRequestCMD uint32 = 7
	UserOfflineNoticeCMD  uint32 = 8

	// 用户改变状态请求 和 通知
	ChangeStatusRequestCMD uint32 = 9
	ChangeStatusNoticeCMD  uint32 = 10

	// 修改用户资料请求 和 响应
	UpdateUserInfoRequestCMD  uint32 = 11
	UpdateUserInfoResponseCMD uint32 = 12

	// 好友聊天请求 和 通知
	FriendChatRequestCMD uint32 = 13
	FriendChatNoticeCMD  uint32 = 14
	
	// 获取用户列表请求 和 响应
	GetUserListRequestCMD  uint32 = 15
	GetUserListResponseCMD uint32 = 16

	// 增加好友请求 和 响应
	AddFriendsRequestCMD  uint32 = 17
	AddFriendsResponseCMD uint32 = 18

	// 心跳请求 和 响应
	HeartbeatRequestCMD  uint32 = 19
	HeartbeatResponseCMD uint32 = 20

	// 上传文件请求 和 响应
	UploadFileRequestCMD  uint32 = 21
	UploadFileResponseCMD uint32 = 22

	// 获取文件列表请求 和 响应
	GetFileListRequestCMD  uint32 = 23
	GetFileListResponseCMD uint32 = 24
```



**二、客户端**
```
客户端是使用c# + protobuf开发，只是简单的实现了一个TCPClient类，其它的大多是界面上的操作了：
```

TCPClien：

```c#
/// <summary>
/// 发送protobuf对象
/// </summary>
/// <param name="cmd">命令号</param>
/// <param name="sendMessage">protobuf对象</param>
/// <returns>已发送长度</returns>
public Int32 SendProtoMessage(Int32 cmd, IMessage message)
{
}
组装数据包，发送
    
/// <summary>
/// 接收消息线程
/// </summary>
/// <param name="state"></param>
private void ReceiveThread(Object state)
{
}
启动一个线程接收数据，把接收到的数据扔到队列里，再由DealQueueThread线程处理
在客户端其实有一些场景并不合适使用异步模式，比如 登录命令，注册命令，使用同步模式处理会更方便

/// <summary>
/// 处理消息线程
/// </summary>
/// <param name="state"></param>
private void DealQueueThread(Object state)
{    
}
消息队列处理线程，把接收到的消息用 ProtocolDecoder.Singleton.Decode 解包回调
```

ProtocolDecoder：

```c#
协议解析类，通过命令号把byte[]转成相应的protobuf对象，并根据命令号回调Action，最终回调给界面
拿LoginRequest来举例：
    首先增加一个Login.proto文件，里面有两个协议结构，LoginRequest用于请求，LoginResponse用于响应，
    用protoc --csharp_out=. Login.proto编译成c#类文件,build.bat有编译的命令
    
    message LoginRequest {
		string UserID = 1;		// 登陆的帐号
		string Password = 2;	// 密码
		int32 Status = 3;		// 状态
	}

	message LoginResponse {
		Result Result = 1;		// 返回值
		UserInfo User = 2;		// 用户信息
	}
    
在ProtocolDecoder类里增加一个回调事件：public Action<LoginResponse> OnLoginResponse;
在GetMessage 和 OnEvent方法里增加相关的代码
在LoginForm_Load里注册事件回调方法ProtocolDecoder.Singleton.OnLoginResponse += OnLoginResponse;
最后，使用TCPClient.Singleton.SendProtoMessage(CMD.LoginRequestCMD, request);发送登录命令后，会回调到OnLoginResponse方法。
注意一点哈：登录方法其实使用同步模式更加方便合理，我这里是使用异步，所以要增加一个BaseTask类用于修改按钮的状态
```



**三、服务端**

```
服务端使用golang + protobuf开发，通讯组件使用 [zinx](http://github.com/aceld/zinx), zinx内部已经实现了 
4个字节的长度 + 4个字节的包长 + 数据包  的协议
只要把命令号和处理对象绑定，并实现Handld方法就成了，其他的就是业务代码了

在服务端里，使用gin实现了一个简陋的web服务，用于下载头像，文件等资源
使用TCP协议上传文件后，同步到其他web或者CDN服务，再把URL返回给客户端
这种架构对客户端和服务端都是很好的，实现简单，并且能大大减少服务端压力。

```