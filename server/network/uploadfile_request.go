package network

import (
	"crypto/md5"
	"errors"
	"fmt"
	"github.com/aceld/zinx/ziface"
	"github.com/aceld/zinx/znet"
	"github.com/golang/protobuf/proto"
	"io/ioutil"
	"os"
	"path"
	"server/conf"
	"server/db"
	"server/models"
	"server/pb"
)

// 上传请求处理对象
type UploadFileRequest struct {
	znet.BaseRouter
}

func (r *UploadFileRequest) send(request ziface.IRequest, code int32, msg, fileName, url string) {
	resp := &pb.UploadFileResponse{
		Result: &pb.Result{
			Code: code,
			Msg:  msg,
		},
		FileName: fileName,
		DownUrl:  url,
	}

	buffer, _ := proto.Marshal(resp)
	request.GetConnection().SendMsg(models.UploadFileResponseCMD, buffer)
}

// 保存文件
func (r *UploadFileRequest) saveFile(fileName, md5 string, buffer []byte) (string, error) {
	if len(buffer) <= 0 {
		return "", errors.New("")
	}

	ext := path.Ext(fileName)
	filePath := fmt.Sprintf("%suploadfiles/%c/%c", conf.Config.ResPath, md5[0], md5[1])
	os.MkdirAll(filePath, os.ModePerm)
	file := fmt.Sprintf("%s/%s%s", filePath, md5, ext)

	err := ioutil.WriteFile(file, buffer, 0644)
	if err != nil {
		return "", err
	}

	return fmt.Sprintf("/uploadfiles/%c/%c/%s%s", md5[0], md5[1], md5, ext), nil
}

func (r *UploadFileRequest) Handle(request ziface.IRequest) {
	msgReq := &pb.UploadFileRequest{}
	proto.Unmarshal(request.GetData(), msgReq)

	if msgReq.FromUserID == "" {
		r.send(request, 0, "参数错误", "", "")
		return
	}

	// 当UserType不为0时，ToUserID不能为空
	if msgReq.UserType != 0 && msgReq.ToUserID == "" {
		r.send(request, 0, "参数错误", "", "")
		return
	}

	fileSize := len(msgReq.Data)
	if fileSize <= 0 || fileSize > 300*1024*1024 {
		r.send(request, 0, "文件大小错误", "", "")
		return
	}

	has := md5.Sum(msgReq.Data)
	md5 := fmt.Sprintf("%x", has)
	if db.CheckUploadFile(md5) {
		r.send(request, 0, "文件已存在", "", "")
		return
	}

	url, err := r.saveFile(msgReq.FileName, md5, msgReq.Data)
	if err != nil {
		r.send(request, 0, "保存文件失败", "", "")
		return
	}

	err = db.AppendUploadFile(msgReq.UserType, msgReq.FromUserID, msgReq.ToUserID, msgReq.FileName, md5, url, fileSize)
	if err != nil {
		r.send(request, 0, "保存文件失败", "", "")
	} else {
		r.send(request, 1, "上传成功", msgReq.FileName, conf.Config.ResServerUrl+url)
	}
}
