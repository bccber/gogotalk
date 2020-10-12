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

// 获取用户列表请求处理对象
type GetUserListRequest struct {
	znet.BaseRouter
}

func (r *GetUserListRequest) Handle(request ziface.IRequest) {
	msgReq := &pb.GetUserListRequest{}
	proto.Unmarshal(request.GetData(), msgReq)

	user := models.UserManagerObj.GetUser(msgReq.UserID)
	if user == nil || user.Status == models.OffLine {
		//request.GetConnection().SendMsg()
		return
	}

	userList := db.GetUserList(msgReq.UserID)
	if userList == nil || len(userList) <= 0 {
		return
	}

	resp := &pb.GetUserListResponse{}
	resp.Result = &pb.Result{
		Code: 1,
		Msg:  "",
	}
	for _, v := range userList {
		headImgUrl := ""
		if v.HeadImageUrl != "" {
			headImgUrl = conf.Config.ResServerUrl + v.HeadImageUrl
		} else {
			headImgUrl = conf.Config.ResServerUrl + "/headimg/default.jpg"
		}

		// 判断用户状态
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
		resp.UserList = append(resp.UserList, friend)
	}
	buffer, _ := proto.Marshal(resp)
	request.GetConnection().SendMsg(models.GetUserListResponseCMD, buffer)
}
