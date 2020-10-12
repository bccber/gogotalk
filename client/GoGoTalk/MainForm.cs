using CCWin;
using CCWin.SkinControl;
using GoGoTalk.Models;
using GoGoTalk.Network;
using GoGoTalk.ProtoBuf;
using System;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using static CCWin.SkinControl.ChatListSubItem;

namespace GoGoTalk
{
    public partial class MainForm : BaseForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void AppendUserToList(User user)
        {
            if (user == null || String.IsNullOrEmpty(user.UserID))
            {
                return;
            }

            ChatListSubItem sub = new ChatListSubItem();
            sub.Tag = user.UserID;
            sub.NicName = user.NickName;
            sub.DisplayName = user.NickName;
            sub.PersonalMsg = user.Signature;
            sub.Status = (UserStatus)user.Status;

            String headFile = Path.Combine(GlobalResourceManager.AppPath, GlobalResourceManager.CurrentUser.UserID, "res", "head.jpg");
            Utils.DownFile(GlobalResourceManager.CurrentUser.HeadImageUrl, headFile);
            if (File.Exists(headFile))
            {
                skinButton_headImage.Image = Image.FromFile(headFile);
            }

            chatListBox1.Items[0].SubItems.Add(sub);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (GlobalResourceManager.CurrentUser == null)
            {
                MessageBoxEx.Show("请先登录");
                new LoginForm().ShowDialog();
                return;
            }

            // 启动心跳线程
            ThreadPool.QueueUserWorkItem(HeartbeatThread, null);

            ProtocolDecoder.Singleton.OnGetFriendsResponse += OnGetFriendsResponse;
            ProtocolDecoder.Singleton.OnChangeStatusNotice += OnChangeStatusNotice;
            ProtocolDecoder.Singleton.OnFriendChatNotice += OnFriendChatNotice;

            ChatListItem itemFriend = new ChatListItem("我的好友");
            chatListBox1.Items.Add(itemFriend);
            itemFriend.IsOpen = true;

            User user = new User();
            user.UserID = "SystemGroupChat";
            user.NickName = "群聊";
            user.Signature = "一起来聊天吧！";
            AppendUserToList(user);

            labelName.Text = GlobalResourceManager.CurrentUser.NickName;
            labelSignature.Text = GlobalResourceManager.CurrentUser.Signature;
            // 下载头像
            String headFile = Path.Combine(GlobalResourceManager.AppPath, GlobalResourceManager.CurrentUser.UserID, "res", "head.jpg");
            Utils.DownFile(GlobalResourceManager.CurrentUser.HeadImageUrl, headFile);
            if (File.Exists(headFile))
            {
                skinButton_headImage.Image = Image.FromFile(headFile);
            }
            AppendUserToList(GlobalResourceManager.CurrentUser);

            GetFriendsRequest getFriendsRequest = new GetFriendsRequest();
            getFriendsRequest.UserID = GlobalResourceManager.CurrentUser.UserID;
            TCPClient.Singleton.SendProtoMessage(CMD.GetFriendsRequestCMD, getFriendsRequest);
        }

        private void HeartbeatThread(object state)
        {
            HeartbeatRequest request = new HeartbeatRequest();
            request.UserID = GlobalResourceManager.CurrentUser.UserID;

            while (true)
            {
                Thread.Sleep(2000);
                TCPClient.Singleton.SendProtoMessage(CMD.HeartbeatRequestCMD, request);
            }
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
                    msg.Content == null || msg.Content.Length <= 0)
                {
                    return;
                }

                foreach (ChatListSubItem item in chatListBox1.Items[0].SubItems)
                {
                    if (item.Tag != null && item.Tag.ToString() == msg.FromUserID)
                    {
                        item.IsTwinkle = true;
                    }
                }
            }
            catch (Exception ex)
            {
            }
        }

        private void OnGetFriendsResponse(GetFriendsResponse msg)
        {
            try
            {
                if (msg == null)
                {
                    return;
                }

                if (msg.Result.Code != 1)
                {
                    return;
                }

                if (msg.Friends == null || msg.Friends.Count <= 0)
                {
                    return;
                }

                foreach (var friend in msg.Friends)
                {
                    User user = new User();
                    user.UserID = friend.UserID;
                    user.NickName = friend.NickName;
                    user.Signature = friend.Signature;
                    user.HeadImageUrl = friend.HeadImageUrl;
                    user.CreateTime = friend.CreateTime;
                    user.Status = friend.Status;

                    AppendUserToList(user);
                }
            }
            catch
            {
            }
        }

        private void OnChangeStatusNotice(ChangeStatusNotice msg)
        {
            try
            {
                if (msg == null)
                {
                    return;
                }

                if (String.IsNullOrEmpty(msg.UserID))
                {
                    return;
                }

                foreach (ChatListSubItem item in chatListBox1.Items[0].SubItems)
                {
                    if(item.Tag != null && item.Tag.ToString() == msg.UserID)
                    {
                        item.Status = (UserStatus)msg.Status;
                    }
                }
            }
            catch
            {
            }
        }

        private void skinButton_State_Click(object sender, EventArgs e)
        {
            skinContextMenuStrip_State.Show(skinButton_State, new Point(0, skinButton_State.Height), ToolStripDropDownDirection.Right);
        }

        private void skinButton_headImage_Click(object sender, EventArgs e)
        {
            new UpdateUserInfoForm().ShowDialog();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            LogoutRequest logoutRequest = new LogoutRequest();
            logoutRequest.UserID = GlobalResourceManager.CurrentUser.UserID;
            TCPClient.Singleton.SendProtoMessage(CMD.UserOfflineRequestCMD, logoutRequest);

            Thread.Sleep(100);
            TCPClient.Singleton.Dispose();
        }

        private void chatListBox1_DoubleClickSubItem(object sender, ChatListEventArgs e, MouseEventArgs es)
        {
            if (e.IsNull() || e.SelectSubItem == null || e.SelectSubItem.Tag == null)
            {
                return;
            }

            String userID = e.SelectSubItem.Tag.ToString();
            if (userID == "e.SelectSubItem")
            {
                FriendChatForm form = new FriendChatForm(userID);
                form.Show();
            }
            else
            {
                FriendChatForm form = new FriendChatForm(userID);
                form.Show();
            }
        }

        private void skinContextMenuStrip_State_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            ToolStripItem item = e.ClickedItem;
            skinButton_State.Image = item.Image;

            ChangeStatusRequest request = new ChangeStatusRequest();
            request.UserID = GlobalResourceManager.CurrentUser.UserID;

            Int32.TryParse(item.Tag.ToString(), out Int32 status);
            request.Status = status <= 0 ? 1 : status;

            TCPClient.Singleton.SendProtoMessage(CMD.ChangeStatusRequestCMD, request);
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            new AddFriendForm().ShowDialog();
        }

        private void 个人资料ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new UpdateUserInfoForm().ShowDialog();
        }

        private void 加入讨论组ToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.skinContextMenuStrip_main.Show(skinToolStrip1, new Point(3, -2), ToolStripDropDownDirection.AboveRight);
        }

        private void 网盘ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new UploadFileForm().ShowDialog();
        }
    }
}