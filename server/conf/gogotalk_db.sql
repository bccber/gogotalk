/*
Navicat MySQL Data Transfer

Source Server         : master
Source Server Version : 50565
Source Host           : localhost:33066
Source Database       : gogotalk_db

Target Server Type    : MYSQL
Target Server Version : 50565
File Encoding         : 65001

Date: 2020-10-13 19:23:05
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for `upload_files`
-- ----------------------------
DROP TABLE IF EXISTS `upload_files`;
CREATE TABLE `upload_files` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `fromuserid` varchar(50) NOT NULL DEFAULT '',
  `touserid` varchar(50) NOT NULL DEFAULT '',
  `usertype` varchar(50) NOT NULL DEFAULT '',
  `filename` varchar(255) NOT NULL DEFAULT '',
  `filesize` int(11) NOT NULL DEFAULT '0',
  `md5` varchar(32) NOT NULL DEFAULT '',
  `url` varchar(255) NOT NULL DEFAULT '',
  PRIMARY KEY (`id`,`filesize`),
  UNIQUE KEY `md5` (`md5`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of upload_files
-- ----------------------------

-- ----------------------------
-- Table structure for `users`
-- ----------------------------
DROP TABLE IF EXISTS `users`;
CREATE TABLE `users` (
  `userid` varchar(50) NOT NULL DEFAULT '',
  `password` varchar(100) NOT NULL DEFAULT '',
  `nickname` varchar(50) NOT NULL DEFAULT '',
  `signature` varchar(100) NOT NULL DEFAULT '',
  `headimageurl` varchar(255) NOT NULL DEFAULT '',
  `groups` varchar(1000) NOT NULL DEFAULT '',
  `createtime` int(11) NOT NULL DEFAULT '0',
  PRIMARY KEY (`userid`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of users
-- ----------------------------

-- ----------------------------
-- Table structure for `user_friends`
-- ----------------------------
DROP TABLE IF EXISTS `user_friends`;
CREATE TABLE `user_friends` (
  `userid` varchar(50) NOT NULL DEFAULT '',
  `friendid` varchar(50) NOT NULL DEFAULT '',
  PRIMARY KEY (`userid`,`friendid`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of user_friends
-- ----------------------------
