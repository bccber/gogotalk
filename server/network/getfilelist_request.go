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

// 获取文件列表请求处理对象
type GetFileListRequest struct {
	znet.BaseRouter
}

func (r *GetFileListRequest) Handle(request ziface.IRequest) {
	msgReq := &pb.GetFileListRequest{}
	proto.Unmarshal(request.GetData(), msgReq)

	msgResp := &pb.GetFileListResponse{
		Result: &pb.Result{
			Code: 0,
		},
	}
	fileList := db.GetFileList(msgReq.UserType, msgReq.UserID)
	if fileList != nil && len(fileList) > 0 {
		msgResp.Result.Code = 1

		for _, file := range fileList {
			f := &pb.DownFileInfo{
				UserID:   file.FromUserID,
				FileSize: file.FileSize,
				FileName: file.FileName,
				DownUrl:  conf.Config.ResServerUrl + file.Url,
			}
			msgResp.FileList = append(msgResp.FileList, f)
		}
	}

	buffer, _ := proto.Marshal(msgResp)
	request.GetConnection().SendMsg(models.GetFileListResponseCMD, buffer)
}
