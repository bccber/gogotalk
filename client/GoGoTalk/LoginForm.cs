using CCWin;
using GoGoTalk.Models;
using GoGoTalk.Network;
using GoGoTalk.ProtoBuf;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace GoGoTalk
{
    /// <summary>
    /// 登录窗体。
    /// </summary>
    public partial class LoginForm : BaseForm
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void OnLoginResponse(LoginResponse msg)
        {
            try
            {
                if (msg == null)
                {
                    MessageBoxEx.Show("登录失败");
                    return;
                }

                if (msg.Result.Code != 1)
                {
                    MessageBoxEx.Show("登录失败");
                    return;
                }

                GlobalResourceManager.CurrentUser = new Models.User();
                GlobalResourceManager.CurrentUser.UserID = msg.User.UserID;
                GlobalResourceManager.CurrentUser.NickName = msg.User.NickName;
                GlobalResourceManager.CurrentUser.Signature = msg.User.Signature;
                GlobalResourceManager.CurrentUser.HeadImageUrl = msg.User.HeadImageUrl;
                GlobalResourceManager.CurrentUser.CreateTime = msg.User.CreateTime;
                GlobalResourceManager.CurrentUser.Status = msg.User.Status;

                DialogResult = DialogResult.OK;
            }
            finally
            {
                btnLogin.Enabled = true;
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            ProtocolDecoder.Singleton.OnLoginResponse += OnLoginResponse;
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            ProtocolDecoder.Singleton.OnLoginResponse -= OnLoginResponse;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            String strUserID = txtUserID.SkinTxt.Text;
            String strPassword = txtPassword.SkinTxt.Text;
            if (String.IsNullOrEmpty(strUserID) || String.IsNullOrEmpty(strPassword))
            {
                return;
            }

            btnLogin.Enabled = false;
            BaseTask.Singleton.AppendTask(5, () => { btnLogin.Enabled = true; });

            try
            {
                LoginRequest request = new LoginRequest();
                request.UserID = strUserID;
                request.Password = strPassword;
                Int32 status = 1;
                if (btnStatus.Tag != null)
                {
                    Int32.TryParse(btnStatus.Tag.ToString(), out status);
                }
                request.Status = status <= 0 ? 2 : status;

                TCPClient.Singleton.SendProtoMessage(CMD.LoginRequestCMD, request);
            }
            catch
            {
                MessageBoxEx.Show("登录失败");
            }
            finally
            {
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            new RegisterForm().ShowDialog();
        }

        private void btnOpenUrl_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.cnblogs.com/bccber/");
        }

        private void btnStatus_Click(object sender, EventArgs e)
        {
            menuStripState.Show(this.Left + pnlTx.Left + panelHeadImage.Left + btnStatus.Left, this.Top + pnlTx.Top + panelHeadImage.Top + btnStatus.Top + btnStatus.Height + 5);
        }        
        
        //状态选择项
        private void Item_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item = (ToolStripMenuItem)sender;
            btnStatus.Image = item.Image;
            btnStatus.Tag = item.Tag;
        }
    }
}
