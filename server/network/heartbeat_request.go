package network

import (
	"github.com/aceld/zinx/ziface"
	"github.com/aceld/zinx/znet"
	"github.com/golang/protobuf/proto"
	"server/models"
	"server/pb"
)

// 心跳请求处理对象
type HeartbeatRequest struct {
	znet.BaseRouter
}

func (r *HeartbeatRequest) Handle(request ziface.IRequest) {
	msgReq := &pb.HeartbeatRequest{}
	proto.Unmarshal(request.GetData(), msgReq)

	if msgReq.UserID == "" {
		return
	}

	user := models.UserManagerObj.GetUser(msgReq.UserID)
	if user != nil {
		user.Heartbeat()
	}
}
