package models

type File struct {
	ID         int32
	FromUserID string
	ToUserID   string
	UserType   string
	FileName   string
	Url        string
	MD5        string
	FileSize   int32
}
