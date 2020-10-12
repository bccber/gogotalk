package network

import (
	"github.com/aceld/zinx/ziface"
	"github.com/aceld/zinx/znet"
	"github.com/golang/protobuf/proto"
	"server/db"
	"server/models"
	"server/pb"
)

// 增加好友请求处理对象
type AddFriendsRequest struct {
	znet.BaseRouter
}

func (r *AddFriendsRequest) send(request ziface.IRequest, code int32, msg string) {
	resp := &pb.AddFriendsResponse{}
	resp.Result = &pb.Result{
		Code: code,
		Msg:  msg,
	}

	buffer, _ := proto.Marshal(resp)
	request.GetConnection().SendMsg(models.AddFriendsResponseCMD, buffer)
}

func (r *AddFriendsRequest) Handle(request ziface.IRequest) {
	msgReq := &pb.AddFriendsRequest{}
	proto.Unmarshal(request.GetData(), msgReq)

	if msgReq.UserID == "" || msgReq.UserIDList == nil || len(msgReq.UserIDList) <= 0 {
		r.send(request, models.Failure, "参数错误")
		return
	}

	err := db.AppendFriends(msgReq.UserID, msgReq.UserIDList)
	if err != nil {
		r.send(request, models.Failure, "失败")
	} else {
		r.send(request, models.Successful, "成功")
	}
}
