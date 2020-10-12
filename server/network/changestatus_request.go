package network

import (
	"github.com/aceld/zinx/ziface"
	"github.com/aceld/zinx/znet"
	"github.com/golang/protobuf/proto"
	"server/models"
	"server/pb"
)

// 改变状态请求处理对象
type ChangeStatusRequest struct {
	znet.BaseRouter
}

func (r *ChangeStatusRequest) Handle(request ziface.IRequest) {
	msgReq := &pb.ChangeStatusRequest{}
	proto.Unmarshal(request.GetData(), msgReq)

	user := models.UserManagerObj.GetUser(msgReq.UserID)
	if user != nil {
		user.ChangeStatus(msgReq.Status)
	}
}
