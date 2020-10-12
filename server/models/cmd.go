package models

const (
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
)
