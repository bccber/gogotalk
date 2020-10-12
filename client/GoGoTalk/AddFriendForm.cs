using GoGoTalk.Models;
using GoGoTalk.Network;
using GoGoTalk.ProtoBuf;
using System;
using System.Windows.Forms;

namespace GoGoTalk
{
    public partial class AddFriendForm : BaseForm
    {
        public AddFriendForm()
        {
            InitializeComponent();
        }

        private void SendGetUserListCMD()
        {
            if (GlobalResourceManager.CurrentUser == null)
            {
                return;
            }

            if (String.IsNullOrEmpty(GlobalResourceManager.CurrentUser.UserID))
            {
                return;
            }

            GetUserListRequest request = new GetUserListRequest();
            request.UserID = GlobalResourceManager.CurrentUser.UserID;

            TCPClient.Singleton.SendProtoMessage(CMD.GetUserListRequestCMD, request);
        }

        private void AddFriendForm_Load(object sender, EventArgs e)
        {
            ProtocolDecoder.Singleton.OnGetUserListResponse += OnGetUserListResponse;
            ProtocolDecoder.Singleton.OnAddFriendsResponse += OnAddFriendsResponse;

            SendGetUserListCMD();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            SendGetUserListCMD();
        }

        private void OnGetUserListResponse(GetUserListResponse msg)
        {
            if(msg == null || msg.UserList == null || msg.Result.Code != 1)
            {
                return;
            }

            lvwUsers.BeginUpdate();
            lvwUsers.Items.Clear();
            foreach (var user in msg.UserList)
            {
                var item = lvwUsers.Items.Add(user.UserID);
                item.SubItems.Add(user.NickName);
                item.SubItems.Add(user.Signature);
            }
            lvwUsers.EndUpdate();
        }

        private void OnAddFriendsResponse(AddFriendsResponse msg)
        {
            if (msg == null || msg.Result.Code != 1)
            {
                return;
            }

            SendGetUserListCMD();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (GlobalResourceManager.CurrentUser == null || String.IsNullOrEmpty(GlobalResourceManager.CurrentUser.UserID))
            {
                return;
            }

            if (lvwUsers.CheckedItems == null || lvwUsers.CheckedItems.Count <= 0)
            {
                return;
            }

            AddFriendsRequest request = new AddFriendsRequest();
            request.UserID = GlobalResourceManager.CurrentUser.UserID;
            foreach (ListViewItem item in lvwUsers.CheckedItems)
            {
                request.UserIDList.Add(item.Text);
            }
            TCPClient.Singleton.SendProtoMessage(CMD.AddFriendsRequestCMD, request);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
