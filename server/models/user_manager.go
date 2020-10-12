package models

import (
	"sync"
	"time"
)

type UserManager struct {
	// 所有在线的玩家
	userMap sync.Map
}

var UserManagerObj *UserManager

func init() {
	UserManagerObj = &UserManager{}

	// 启动检查心跳协和
	go UserManagerObj.checkHeartbeat()
}

// checkHeartbeat 心跳检查，5秒一次，超过10秒就删除
func (um *UserManager) checkHeartbeat() {
	for {
		time.Sleep(3 * time.Second)

		um.userMap.Range(func(key, value interface{}) bool {
			u := value.(*User)
			if time.Now().Unix()-u.HeartbeatTime > 10 {
				// 广播下线消息,删除缓存
				u.Logout()
			}
			return true
		})
	}
}

// AddUser 增加用户到缓存
func (um *UserManager) AddUser(user *User) {
	user.HeartbeatTime = time.Now().Unix()
	um.userMap.Store(user.UserID, user)
}

// GetUser 从缓存获取用户
func (um *UserManager) GetUser(userID string) *User {
	user, ok := um.userMap.Load(userID)
	if ok {
		return user.(*User)
	} else {
		return nil
	}
}

// RemoveUser 从缓存删除用户
func (um *UserManager) RemoveUser(userID string) {
	um.userMap.Delete(userID)
}
