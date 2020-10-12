using GoGoTalk.Models;
using GoGoTalk.ProtoBuf;
using Google.Protobuf;
using System;

namespace GoGoTalk.Network
{
    public class ProtocolDecoder
    {
        // 单例
        public static ProtocolDecoder Singleton = new ProtocolDecoder();

        private ProtocolDecoder()
        {
        }

        // 登录响应回调
        public Action<LoginResponse> OnLoginResponse;
        // 注册响应回调
        public Action<RegisterResponse> OnRegisterResponse;
        // 获取好友列表响应回调
        public Action<GetFriendsResponse> OnGetFriendsResponse;
        // 和好友聊天通知回调
        public Action<FriendChatNotice> OnFriendChatNotice;
        // 修改状态响应回调
        public Action<ChangeStatusNotice> OnChangeStatusNotice;
        // 获取用户列表响应回调
        public Action<GetUserListResponse> OnGetUserListResponse;
        // 增加好友响应回调
        public Action<AddFriendsResponse> OnAddFriendsResponse;
        // 上传文件响应回调
        public Action<UploadFileResponse> OnUploadFileResponse;
        // 获取文件列表响应回调
        public Action<GetFileListResponse> OnGetFileListResponse;

        // 通过CMD创建目标对象
        private IMessage GetMessage(MessageBuffer msgBuf)
        {
            switch (msgBuf.CMD)
            {
                case CMD.LoginResponseCMD:
                    return new LoginResponse();

                case CMD.RegisterResponseCMD:
                    return new RegisterResponse();

                case CMD.GetFriendsResponseCMD:
                    return new GetFriendsResponse();

                case CMD.ChangeStatusNoticeCMD:
                    return new ChangeStatusNotice();

                case CMD.FriendChatNoticeCMD:
                    return new FriendChatNotice();

                case CMD.GetUserListResponseCMD:
                    return new GetUserListResponse();

                case CMD.AddFriendsResponseCMD:
                    return new AddFriendsResponse();

                case CMD.UploadFileResponseCMD:
                    return new UploadFileResponse();

                case CMD.GetFileListResponseCMD:
                    return new GetFileListResponse();
            }

            return null;
        }

        // 回调
        private void OnEvent(Int32 cmd, IMessage message)
        {
            switch (cmd)
            {
                case CMD.LoginResponseCMD:
                    OnLoginResponse?.Invoke(message as LoginResponse);
                    break;

                case CMD.RegisterResponseCMD:
                    OnRegisterResponse?.Invoke(message as RegisterResponse);
                    break;

                case CMD.GetFriendsResponseCMD:
                    OnGetFriendsResponse?.Invoke(message as GetFriendsResponse);
                    break;

                case CMD.ChangeStatusNoticeCMD:
                    OnChangeStatusNotice?.Invoke(message as ChangeStatusNotice);
                    break;

                case CMD.FriendChatNoticeCMD:
                    OnFriendChatNotice?.Invoke(message as FriendChatNotice);
                    break;

                case CMD.GetUserListResponseCMD:
                    OnGetUserListResponse?.Invoke(message as GetUserListResponse);
                    break;

                case CMD.AddFriendsResponseCMD:
                    OnAddFriendsResponse?.Invoke(message as AddFriendsResponse);
                    break;

                case CMD.UploadFileResponseCMD:
                    OnUploadFileResponse?.Invoke(message as UploadFileResponse);
                    break;

                case CMD.GetFileListResponseCMD:
                    OnGetFileListResponse?.Invoke(message as GetFileListResponse);
                    break;
            }
        }

        // 把buffer解析成目标对象，回调
        public void Decode(MessageBuffer msgBuf)
        {
            if (msgBuf == null)
            {
                return;
            }

            IMessage message = GetMessage(msgBuf);
            using (CodedInputStream cis = new CodedInputStream(msgBuf.Buffer))
            {
                cis.ReadRawMessage(message);
            }

            if (message != null)
            {
                OnEvent(msgBuf.CMD, message);
            }
        }
    }
}