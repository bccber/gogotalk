package conf

import (
	"encoding/json"
	"io/ioutil"
)

var Config *conf

type conf struct {
	MySQLConn     string `json:"MySQLConn"`
	ResPath       string `json:"ResPath"`
	ResServerIP   string `json:"ResServerIP"`
	ResServerPort int    `json:"ResServerPort"`
	ResServerUrl  string `json:"ResServerUrl"`
}

func init() {
	buf, err := ioutil.ReadFile("./conf/conf.json")
	if err != nil {
		panic("conf.json 有误")
	}

	if err = json.Unmarshal(buf, &Config); err != nil {
		panic(err)
	}
}
