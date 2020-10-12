package network

import (
	"fmt"
	"github.com/aceld/zinx/ziface"
	"github.com/aceld/zinx/znet"
	"github.com/golang/protobuf/proto"
	"server/models"
	"server/pb"
)

// 离线请求处理对象
type LogoutRequest struct {
	znet.BaseRouter
}

func (r *LogoutRequest) Handle(request ziface.IRequest) {
	fmt.Println("LogoutRequest Handle")
	msgReq := &pb.LogoutRequest{}
	proto.Unmarshal(request.GetData(), msgReq)

	user := models.UserManagerObj.GetUser(msgReq.UserID)
	if user != nil {
		user.Logout()
	}
}
