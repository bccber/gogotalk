package db

import (
	"database/sql"
	_ "github.com/go-sql-driver/mysql"
	"server/conf"
)

var db *sql.DB

func init() {
	var err error
	db, err = sql.Open("mysql", conf.Config.MySQLConn)
	if err != nil {
		panic(err)
	}
}
