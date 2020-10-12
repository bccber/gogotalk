package db

import (
	"errors"
	_ "github.com/go-sql-driver/mysql"
	"server/models"
)

// getFriendsUserID 获取好友帐号列表
func getFriendsUserID(userID string) []string {
	var friendIDs []string
	strSQL := `SELECT friendid FROM user_friends WHERE userid=?;`
	rows, err := db.Query(strSQL, userID)
	if err != nil {
		return nil
	}

	for rows.Next() {
		var friendID string
		rows.Scan(&friendID)

		friendIDs = append(friendIDs, friendID)
	}
	rows.Close()

	return friendIDs
}

// AppendFriends 增加好友
func AppendFriends(userID string, friendsID []string) error {
	if userID == "" || friendsID == nil || len(friendsID) <= 0 {
		return errors.New("参数错误")
	}

	// 相互加
	strSQL := `INSERT IGNORE INTO user_friends(userid,friendid) VALUE(?,?),(?,?);`
	for _, fid := range friendsID {
		_, err := db.Exec(strSQL, userID, fid, fid, userID)
		if err != nil {
			return err
		}
	}

	return nil
}

// GetFriends 获取好友列表
func GetFriends(userID string) []models.User {
	var users []models.User
	strSQL := `SELECT a.friendid,password,nickname,signature,headimageurl,createtime FROM 
 				user_friends a INNER JOIN users b ON a.friendid=b.userid WHERE a.userid=?;`
	rows, err := db.Query(strSQL, userID)
	if err != nil {
		return nil
	}

	for rows.Next() {
		var user models.User
		rows.Scan(&user.UserID, &user.Password, &user.NickName, &user.Signature, &user.HeadImageUrl, &user.CreateTime)

		users = append(users, user)
	}
	rows.Close()

	return users
}
