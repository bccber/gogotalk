package network

import (
	"github.com/aceld/zinx/ziface"
	"github.com/aceld/zinx/znet"
	"github.com/golang/protobuf/proto"
	"server/conf"
	"server/db"
	"server/models"
	"server/pb"
)

// 获取好友列表请求处理对象
type GetFriendsRequest struct {
	znet.BaseRouter
}

func (r *GetFriendsRequest) send(request ziface.IRequest, code int32, msg string) {
	resp := &pb.RegisterResponse{}
	resp.Result = &pb.Result{
		Code: code,
		Msg:  msg,
	}

	buffer, _ := proto.Marshal(resp)
	request.GetConnection().SendMsg(models.RegisterResponseCMD, buffer)
}

func (r *GetFriendsRequest) Handle(request ziface.IRequest) {
	msgReq := &pb.GetFriendsRequest{}
	proto.Unmarshal(request.GetData(), msgReq)

	if msgReq.UserID == "" {
		r.send(request, 0, "帐号不能为空")
		return
	}

	friends := db.GetFriends(msgReq.UserID)
	if friends == nil || len(friends) <= 0 {
		r.send(request, 0, "没有朋友！")
		return
	}

	resp := &pb.GetFriendsResponse{}
	resp.Result = &pb.Result{
		Code: 1,
		Msg:  "",
	}

	for _, v := range friends {
		headImgUrl := ""
		if v.HeadImageUrl != "" {
			headImgUrl = conf.Config.ResServerUrl + v.HeadImageUrl
		} else {
			headImgUrl = conf.Config.ResServerUrl + "/headimg/default.jpg"
		}

		// 判断好友状态
		status := models.OffLine
		f := models.UserManagerObj.GetUser(v.UserID)
		if f != nil {
			status = f.Status
		}

		friend := &pb.UserInfo{
			UserID:       v.UserID,
			NickName:     v.NickName,
			Signature:    v.Signature,
			HeadImageUrl: headImgUrl,
			CreateTime:   v.CreateTime,
			Status:       status,
		}
		resp.Friends = append(resp.Friends, friend)
	}
	buffer, _ := proto.Marshal(resp)
	request.GetConnection().SendMsg(models.GetFriendsResponseCMD, buffer)
}
