package main

import (
	"fmt"
	"github.com/aceld/zinx/ziface"
	"github.com/aceld/zinx/znet"
	"github.com/gin-gonic/gin"
	"server/conf"
	"server/models"
	"server/network"
)

// 当客户端建立连接的时候的hook函数
func OnConnectionAdd(conn ziface.IConnection) {
}

//当客户端断开连接的时候的hook函数
func OnConnectionLost(conn ziface.IConnection) {
	// 通过ConnectionID找到对应的用户
	// 删除缓存，并通知所有在线好友
	userID, _ := conn.GetProperty("userID")
	if userID != nil {
		user := models.UserManagerObj.GetUser(userID.(string))
		if user != nil {
			// 用户离线
			user.Logout()
		}
	}
}

// 启动web服务器
func startResServer() {
	router := gin.Default()
	router.Static("/res", "./res")

	router.Run(fmt.Sprintf("%s:%d", conf.Config.ResServerIP, conf.Config.ResServerPort))
}

func main() {
	fmt.Println("GoGoTalk")

	// 启动web资源下载服务器
	go startResServer()

	server := znet.NewServer()

	//注册客户端连接建立和丢失函数
	server.SetOnConnStart(OnConnectionAdd)
	server.SetOnConnStop(OnConnectionLost)

	// 注册路由
	server.AddRouter(models.LoginRequestCMD, &network.LoginRequest{})
	server.AddRouter(models.RegisterRequestCMD, &network.RegisterRequest{})
	server.AddRouter(models.GetFriendsRequestCMD, &network.GetFriendsRequest{})
	server.AddRouter(models.UserOfflineRequestCMD, &network.LogoutRequest{})
	server.AddRouter(models.ChangeStatusRequestCMD, &network.ChangeStatusRequest{})
	server.AddRouter(models.UpdateUserInfoRequestCMD, &network.UpdateUserInfoRequest{})
	server.AddRouter(models.FriendChatRequestCMD, &network.FriendChatRequest{})
	server.AddRouter(models.GetUserListRequestCMD, &network.GetUserListRequest{})
	server.AddRouter(models.AddFriendsRequestCMD, &network.AddFriendsRequest{})
	server.AddRouter(models.HeartbeatRequestCMD, &network.HeartbeatRequest{})
	server.AddRouter(models.UploadFileRequestCMD, &network.UploadFileRequest{})
	server.AddRouter(models.GetFileListRequestCMD, &network.GetFileListRequest{})

	// 启动TCP服务
	server.Serve()
}
