using System;

namespace GoGoTalk.Models
{
    public class CMD
    {
        // 登录请求和响应
        public const Int32 LoginRequestCMD = 1;
        public const Int32 LoginResponseCMD = 2;

        // 注册请求和响应
        public const Int32 RegisterRequestCMD = 3;
        public const Int32 RegisterResponseCMD = 4;

        // 获取朋友列表的请求和响应
        public const Int32 GetFriendsRequestCMD = 5;
        public const Int32 GetFriendsResponseCMD = 6;

        // 用户下线请求 和 通知
        public const Int32 UserOfflineRequestCMD = 7;
        public const Int32 UserOfflineNoticeCMD = 8;

        // 用户改变状态请求 和 通知
        public const Int32 ChangeStatusRequestCMD = 9;
        public const Int32 ChangeStatusNoticeCMD = 10;

        // 修改用户资料请求 和 响应
        public const Int32 UpdateUserInfoRequestCMD = 11;
        public const Int32 UpdateUserInfoResponseCMD = 12;

        // 好友聊天请求 和 通知
        public const Int32 FriendChatRequestCMD = 13;
        public const Int32 FriendChatNoticeCMD = 14;

        // 获取用户列表请求 和 响应
        public const Int32 GetUserListRequestCMD = 15;
        public const Int32 GetUserListResponseCMD = 16;

        // 增加好友请求 和 响应
        public const Int32 AddFriendsRequestCMD = 17;
        public const Int32 AddFriendsResponseCMD = 18;

        // 心跳请求 和 响应
        public const Int32 HeartbeatRequestCMD = 19;
        public const Int32 HeartbeatResponseCMD = 20;

        // 上传文件请求 和 响应
        public const Int32 UploadFileRequestCMD = 21;
        public const Int32 UploadFileResponseCMD = 22;

        // 获取文件列表请求 和 响应
        public const Int32 GetFileListRequestCMD = 23;
        public const Int32 GetFileListResponseCMD = 24;
    }
}