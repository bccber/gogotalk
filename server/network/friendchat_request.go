package network

import (
	"github.com/aceld/zinx/ziface"
	"github.com/aceld/zinx/znet"
	"github.com/golang/protobuf/proto"
	"server/models"
	"server/pb"
)

// 好友聊天请求处理对象
type FriendChatRequest struct {
	znet.BaseRouter
}

func (r *FriendChatRequest) Handle(request ziface.IRequest) {
	msgReq := &pb.FriendChatRequest{}
	proto.Unmarshal(request.GetData(), msgReq)

	if msgReq.FromUserID == "" || msgReq.ToUserID == "" ||
		msgReq.Content == nil || len(msgReq.Content) <= 0 {
		return
	}

	toUser := models.UserManagerObj.GetUser(msgReq.ToUserID)
	if toUser == nil || toUser.Status == models.OffLine || toUser.Conn == nil {
		return
	}

	toUser.Conn.SendMsg(models.FriendChatNoticeCMD, request.GetData())
}
