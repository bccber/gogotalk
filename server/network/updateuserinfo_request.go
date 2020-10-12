package network

import (
	"github.com/aceld/zinx/ziface"
	"github.com/aceld/zinx/znet"
	"github.com/golang/protobuf/proto"
	"server/db"
	"server/models"
	"server/pb"
)

// 更新用户信息请求处理对象
type UpdateUserInfoRequest struct {
	znet.BaseRouter
}

func (r *UpdateUserInfoRequest) Handle(request ziface.IRequest) {
	msgReq := &pb.UpdateUserInfoRequest{}
	proto.Unmarshal(request.GetData(), msgReq)

	if msgReq.User == nil || msgReq.User.UserID == "" {
		return
	}

	user := models.User{
		UserID:    msgReq.User.UserID,
		NickName:  msgReq.User.NickName,
		Signature: msgReq.User.Signature,
	}
	db.UpdateUserInfo(user)
}
