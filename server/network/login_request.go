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

// 登录请求处理对象
type LoginRequest struct {
	znet.BaseRouter
}

func (r *LoginRequest) send(request ziface.IRequest, code int32, msg string, user *pb.UserInfo) {
	resp := &pb.LoginResponse{}
	resp.Result = &pb.Result{
		Code: code,
		Msg:  msg,
	}
	resp.User = user

	buffer, _ := proto.Marshal(resp)
	request.GetConnection().SendMsg(models.LoginResponseCMD, buffer)
}

func (r *LoginRequest) Handle(request ziface.IRequest) {
	msgReq := &pb.LoginRequest{}
	proto.Unmarshal(request.GetData(), msgReq)

	// 判断是否已登录
	user := models.UserManagerObj.GetUser(msgReq.UserID)
	if user != nil && user.Status != models.OffLine {
		r.send(request, models.RepeatLogin, "重复登录", nil)
		return
	}

	user = db.GetUser(msgReq.UserID)
	if user == nil {
		r.send(request, models.UserNotExists, "帐号不存在", nil)
		return
	}

	if msgReq.Password != user.Password {
		r.send(request, models.WrongPassword, "密码错误", nil)
		return
	}

	headImageUrl := ""
	if user.HeadImageUrl != "" {
		headImageUrl = conf.Config.ResServerUrl + user.HeadImageUrl
	} else {
		headImageUrl = conf.Config.ResServerUrl + "/headimg/default.jpg"
	}
	user.Status = msgReq.Status
	user.Conn = request.GetConnection()
	// 把用户增加到缓存
	models.UserManagerObj.AddUser(user)

	// 给Conn对象增加userID属性，把用户和链接关联起来
	request.GetConnection().SetProperty("userID", msgReq.UserID)

	userInfo := &pb.UserInfo{
		UserID:       user.UserID,
		NickName:     user.NickName,
		Signature:    user.Signature,
		HeadImageUrl: headImageUrl,
		CreateTime:   user.CreateTime,
		Status:       msgReq.Status,
	}
	r.send(request, models.Successful, "登录成功", userInfo)
	user.ChangeStatus(msgReq.Status)
}
