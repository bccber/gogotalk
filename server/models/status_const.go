package models

const (
	// 用户在线状态常量
	QMe         int32 = 1
	Online      int32 = 2
	Away        int32 = 3
	Busy        int32 = 4
	DontDisturb int32 = 5
	OffLine     int32 = 6

	// 请求状态常量
	Failure       int32 = 0
	Successful    int32 = 1
	UserExists    int32 = 2
	RepeatLogin   int32 = 3
	UserNotExists int32 = 4
	WrongPassword int32 = 5
)
