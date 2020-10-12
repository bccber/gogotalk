package db

import (
	"errors"
	_ "github.com/go-sql-driver/mysql"
	"server/models"
)

// GetUser 获取用户信息
func GetUser(userID string) *models.User {
	user := &models.User{}
	strSQL := `SELECT userid,password,nickname,signature,headimageurl,createtime FROM users WHERE userid=?;`
	err := db.QueryRow(strSQL, userID).Scan(&user.UserID, &user.Password, &user.NickName, &user.Signature, &user.HeadImageUrl, &user.CreateTime)
	if err != nil {
		return nil
	}

	// 加载好友
	user.Friends = getFriendsUserID(userID)
	return user
}

// AppendUser 增加用户
func AppendUser(user models.User) error {
	if user.UserID == "" || user.Password == "" {
		return errors.New("参数错误")
	}

	strSQL := `INSERT IGNORE INTO users(userid,password,nickname,signature,headimageurl,createtime) VALUE(?,?,?,?,?,?);`
	_, err := db.Exec(strSQL, user.UserID, user.Password, user.NickName, user.Signature, user.HeadImageUrl, user.CreateTime)
	return err
}

// UpdateUserInfo 更新用户信息
func UpdateUserInfo(user models.User) {
	if user.UserID == "" {
		return
	}

	strSQL := `UPDATE users SET nickname=?,signature=? WHERE userid=?;`
	db.Exec(strSQL, user.NickName, user.Signature, user.UserID)
}

// GetUserList 获取用户列表
func GetUserList(filtUserID string) []models.User {
	var userList []models.User

	strSQL := `SELECT userid,nickname,signature,headimageurl,createtime FROM users WHERE userid<>? AND userid NOT IN (SELECT friendid FROM user_friends WHERE userid=?);`
	rows, err := db.Query(strSQL, filtUserID, filtUserID)
	if err != nil {
		return nil
	}

	for rows.Next() {
		var user models.User
		rows.Scan(&user.UserID, &user.NickName, &user.Signature, &user.HeadImageUrl, &user.CreateTime)

		userList = append(userList, user)
	}
	rows.Close()

	return userList
}
