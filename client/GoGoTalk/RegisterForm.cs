using CCWin;
using GoGoTalk.Models;
using GoGoTalk.Network;
using GoGoTalk.ProtoBuf;
using Google.Protobuf;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace GoGoTalk
{
    /// <summary>
    /// 注册。
    /// </summary>
    public partial class RegisterForm : BaseForm
    {
        public RegisterForm()
        {
            InitializeComponent();
        }
        
        private void RegisterForm_Load(object sender, EventArgs e)
        {
            ProtocolDecoder.Singleton.OnRegisterResponse += OnRegisterResponse;
        }

        private void RegisterForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            ProtocolDecoder.Singleton.OnRegisterResponse -= OnRegisterResponse;
        }

        private void OnRegisterResponse(RegisterResponse msg)
        {
            try
            {
                if (msg == null)
                {
                    MessageBoxEx.Show("注册失败");
                    return;
                }

                if (msg.Result.Code == 2)
                {
                    MessageBoxEx.Show("帐号已经存在");
                    return;
                }

                if (msg.Result.Code == 0 || msg.Result.Code != 1)
                {
                    MessageBoxEx.Show("注册失败");
                    return;
                }

                DialogResult = DialogResult.OK;
            }
            finally
            {
                btnRegister.Enabled = true;
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.None;
            String strUserID = skinTextBox_id.SkinTxt.Text.Trim();
            if (String.IsNullOrEmpty(strUserID))
            {
                skinTextBox_id.SkinTxt.Focus();
                MessageBoxEx.Show("帐号不能为空！");
                return;
            }

            btnRegister.Enabled = false;
            BaseTask.Singleton.AppendTask(5, () => { btnRegister.Enabled = true; });

            String strPassword1 = skinTextBox_pwd.SkinTxt.Text;
            String strPassword2 = skinTextBox_pwd2.SkinTxt.Text;
            if (String.IsNullOrEmpty(strPassword1) || strPassword1 != strPassword2)
            {
                MessageBoxEx.Show("两次输入的密码不一致！");
                skinTextBox_pwd.SkinTxt.SelectAll();
                skinTextBox_pwd.SkinTxt.Focus();
                return;
            }

            try
            {
                RegisterRequest request = new RegisterRequest();
                request.UserID = strUserID;
                request.Password = strPassword1;
                request.NickName = skinTextBox_nickName.SkinTxt.Text.Trim();
                request.Signature = skinTextBox_signature.SkinTxt.Text.Trim();

                if (pnlImgTx.BackgroundImage != null)
                {
                    ImageFormat format = ImageFormat.Jpeg;
                    if(pnlImgTx.Tag != null && pnlImgTx.Tag.ToString() == ".bmp")
                    {
                        format = ImageFormat.Bmp;
                    }
                    using (MemoryStream mstream = new MemoryStream())
                    {
                        pnlImgTx.BackgroundImage.Save(mstream, format);
                        Byte[] byData = new Byte[mstream.Length];
                        mstream.Position = 0;
                        mstream.Read(byData, 0, byData.Length);
                        mstream.Close();

                        request.HeadImageData = ByteString.CopyFrom(byData);
                    }
                }

                btnRegister.Enabled = false;
                TCPClient.Singleton.SendProtoMessage(CMD.RegisterRequestCMD, request);
            }
            catch (Exception ee)
            {
                MessageBoxEx.Show("注册失败！" + ee.Message);
            }
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "jpg|*.jpg|bmp|*.bmp";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                pnlImgTx.Tag = Path.GetExtension(dialog.FileName).ToLower();
                pnlImgTx.BackgroundImage = Image.FromFile(dialog.FileName);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
