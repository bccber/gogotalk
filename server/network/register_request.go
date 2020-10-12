package network

import (
	"fmt"
	"github.com/aceld/zinx/ziface"
	"github.com/aceld/zinx/znet"
	"github.com/golang/protobuf/proto"
	"github.com/pkg/errors"
	"io/ioutil"
	"os"
	"server/conf"
	"server/db"
	"server/models"
	"server/pb"
	"time"
)

// 注册用户请求处理对象
type RegisterRequest struct {
	znet.BaseRouter
}

func (r *RegisterRequest) send(request ziface.IRequest, code int32, msg string) {
	resp := &pb.RegisterResponse{}
	resp.Result = &pb.Result{
		Code: code,
		Msg:  msg,
	}

	buffer, _ := proto.Marshal(resp)
	request.GetConnection().SendMsg(models.RegisterResponseCMD, buffer)
}

// 保存头像图片
func (r *RegisterRequest) saveHeadImage(userID string, buffer []byte) (string, error) {
	if len(buffer) <= 0 {
		return "", errors.New("")
	}

	filePath := fmt.Sprintf("%sheadimg/%s/", conf.Config.ResPath, userID)
	os.MkdirAll(filePath, os.ModePerm)
	file := fmt.Sprintf("%s/head.jpg", filePath)

	err := ioutil.WriteFile(file, buffer, 0644)
	if err != nil {
		return "", err
	}

	return fmt.Sprintf("/headimg/%s/head.jpg", userID), nil
}

func (r *RegisterRequest) Handle(request ziface.IRequest) {
	msgReq := &pb.RegisterRequest{}
	proto.Unmarshal(request.GetData(), msgReq)

	if msgReq.UserID == "" || msgReq.Password == "" {
		r.send(request, models.Failure, "帐号密码不能为空")
		return
	}

	// 判断用户是否已存在
	user := db.GetUser(msgReq.UserID)
	if user != nil {
		r.send(request, models.UserExists, "用户帐号已经存在！")
		return
	}

	// 用户不存在，增加
	headImgUrl, err := r.saveHeadImage(msgReq.UserID, msgReq.HeadImageData)
	if err != nil || headImgUrl == "" {
		r.send(request, models.Failure, "注册失败！")
		return
	}

	newUser := models.User{
		UserID:       msgReq.UserID,
		Password:     msgReq.Password,
		NickName:     msgReq.NickName,
		Signature:    msgReq.Signature,
		HeadImageUrl: headImgUrl,
		CreateTime:   time.Now().Unix(),
	}
	err = db.AppendUser(newUser)
	if err != nil {
		r.send(request, models.Failure, err.Error())
		return
	}

	r.send(request, models.Successful, "注册成功")
}
