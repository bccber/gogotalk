package models

import (
	"github.com/aceld/zinx/ziface"
	"github.com/golang/protobuf/proto"
	"server/pb"
	"time"
)

type User struct {
	UserID       string
	Password     string
	NickName     string
	Signature    string
	HeadImageUrl string // 头像Url,通过web对外提供
	CreateTime   int64
	Status       int32 // 在线状态
	// 当前用户的连接对象
	Conn ziface.IConnection

	// 朋友列表
	Friends []string

	// 心跳时间，超过10秒不更新，会认为下线，删除
	HeartbeatTime int64
}

// 用户下线
func (u *User) ChangeStatus(status int32) {
	// 向在线好友发消息
	resp := &pb.ChangeStatusNotice{
		UserID: u.UserID,
		Status: status,
	}
	buffer, _ := proto.Marshal(resp)

	for _, friendUserID := range u.Friends {
		// 通过friendUserID找到User对象
		friend := UserManagerObj.GetUser(friendUserID)
		if friend == nil || friend.Conn == nil {
			continue
		}

		friend.Conn.SendMsg(ChangeStatusNoticeCMD, buffer)
	}
}

// 用户下线
func (u *User) Logout() {
	// 向在线好友发消息
	resp := &pb.ChangeStatusNotice{
		UserID: u.UserID,
		Status: OffLine,
	}
	buffer, _ := proto.Marshal(resp)

	for _, friendUserID := range u.Friends {
		// 通过friendUserID找到User对象
		friend := UserManagerObj.GetUser(friendUserID)
		if friend == nil || friend.Conn == nil || friend.Status == OffLine {
			continue
		}

		friend.Conn.SendMsg(UserOfflineNoticeCMD, buffer)
	}

	// 删除缓存
	UserManagerObj.RemoveUser(u.UserID)
}

// Heartbeat 心跳
func (u *User) Heartbeat() {
	u.HeartbeatTime = time.Now().Unix()
}
