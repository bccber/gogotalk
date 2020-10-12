package db

import (
	_ "github.com/go-sql-driver/mysql"
	"server/models"
)

// CheckUploadFile 检查文件是否存在
func CheckUploadFile(md5 string) bool {
	count := 0
	strSQL := `SELECT COUNT(0) FROM upload_files WHERE md5=?;`
	err := db.QueryRow(strSQL, md5).Scan(&count)

	return !(err != nil || count <= 0)
}

// AppendUploadFile 检增加文件
func AppendUploadFile(userType int32, fromUserID, toUserID, fileName, md5, url string, fileSize int) error {
	strSQL := `INSERT IGNORE INTO upload_files(fromuserid,touserid,usertype,filename,md5,url,fileSize) VALUE(?,?,?,?,?,?,?);`
	_, err := db.Exec(strSQL, fromUserID, toUserID, userType, fileName, md5, url, fileSize)
	return err
}

// GetFileList 获取列表
func GetFileList(userType int32, userID string) []models.File {
	var fileList []models.File

	strSQL := `SELECT id,fromuserid,touserid,usertype,md5,filename,filesize,url FROM upload_files ORDER BY id DESC;`
	rows, err := db.Query(strSQL)
	if err != nil {
		return nil
	}

	for rows.Next() {
		var file models.File
		rows.Scan(&file.ID, &file.FromUserID, &file.ToUserID, &file.UserType, &file.MD5,
			&file.FileName, &file.FileSize, &file.Url)

		fileList = append(fileList, file)
	}
	rows.Close()

	return fileList
}
