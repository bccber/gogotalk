using GoGoTalk.Models;
using GoGoTalk.Network;
using GoGoTalk.ProtoBuf;
using Google.Protobuf;
using System;
using System.Text;

namespace GoGoTalk
{
    /// <summary>
    /// 好友聊天窗口。
    /// </summary>
    public partial class FriendChatForm : BaseForm
    {
        private readonly String _ToUserID;

        public FriendChatForm(String toUser)
        {
            InitializeComponent();
            _ToUserID = toUser;
        }

        private void skinButton_send_Click(object sender, EventArgs e)
        {
            String content = txtSend.Rtf;
            if (GlobalResourceManager.CurrentUser == null ||
                String.IsNullOrEmpty(GlobalResourceManager.CurrentUser.UserID) ||
                String.IsNullOrEmpty(_ToUserID) || String.IsNullOrEmpty(content))
            {
                return;
            }

            FriendChatRequest request = new FriendChatRequest();
            request.FromUserID = GlobalResourceManager.CurrentUser.UserID;
            request.ToUserID = _ToUserID;

            var buffer = Encoding.UTF8.GetBytes(content);
            request.Content = ByteString.CopyFrom(buffer);

            TCPClient.Singleton.SendProtoMessage(CMD.FriendChatRequestCMD, request);
            txtSend.Clear();
        }

        private void FriendChatForm_Load(object sender, EventArgs e)
        {
            ProtocolDecoder.Singleton.OnFriendChatNotice += OnFriendChatNotice;
        }

        private void OnFriendChatNotice(FriendChatNotice msg)
        {
            try
            {
                if (msg == null)
                {
                    return;
                }

                if (String.IsNullOrEmpty(msg.FromUserID) || String.IsNullOrEmpty(msg.ToUserID) ||
                    msg.ToUserID != _ToUserID || msg.Content == null || msg.Content.Length <= 0)
                {
                    return;
                }
                String context = msg.Content.ToStringUtf8();
                txtHistory.SelectionStart = txtHistory.Rtf.Length;
                txtHistory.SelectedRtf += context;
                txtHistory.ScrollToCaret();
            }
            catch(Exception ex)
            {
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}