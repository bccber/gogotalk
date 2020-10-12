using GoGoTalk.Models;
using GoGoTalk.Network;
using GoGoTalk.ProtoBuf;
using System;

namespace GoGoTalk
{
    /// <summary>
    /// 修改个人资料。
    /// </summary>
    public partial class UpdateUserInfoForm : BaseForm
    {
        public UpdateUserInfoForm()
        {
            InitializeComponent();
        }

        private void skinButton1_Click(object sender, EventArgs e)
        {
            this.Close();       
        }

        private void UpdateUserInfoForm_Load(object sender, EventArgs e)
        {
            if(GlobalResourceManager.CurrentUser == null)
            {
                return;
            }

            skinLabel_ID.Text = GlobalResourceManager.CurrentUser.UserID;
            skinTextBox_nickName.SkinTxt.Text = GlobalResourceManager.CurrentUser.NickName;
            skinTextBox_signature.SkinTxt.Text = GlobalResourceManager.CurrentUser.Signature;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            String niceName = skinTextBox_nickName.SkinTxt.Text.Trim();
            if(String.IsNullOrEmpty(niceName))
            {
                return;
            }

            UpdateUserInfoRequest request = new UpdateUserInfoRequest();
            request.User = new UserInfo();
            request.User.UserID = GlobalResourceManager.CurrentUser.UserID;
            request.User.NickName = niceName;
            request.User.Signature = skinTextBox_signature.SkinTxt.Text;

            TCPClient.Singleton.SendProtoMessage(CMD.UpdateUserInfoRequestCMD, request);
        }
    }
}
