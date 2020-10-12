using CCWin;
using GoGoTalk.Models;
using GoGoTalk.Network;
using GoGoTalk.ProtoBuf;
using Google.Protobuf;
using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace GoGoTalk
{
    public partial class UploadFileForm : BaseForm
    {
        public UploadFileForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 发送获取文件列表命令
        /// </summary>
        private void SendGetFileListCMD()
        {
            if (GlobalResourceManager.CurrentUser == null)
            {
                return;
            }

            if (String.IsNullOrEmpty(GlobalResourceManager.CurrentUser.UserID))
            {
                return;
            }

            GetFileListRequest request = new GetFileListRequest();
            request.UserID = GlobalResourceManager.CurrentUser.UserID;
            request.UserType = 0;

            TCPClient.Singleton.SendProtoMessage(CMD.GetFileListRequestCMD, request);
        }

        private void UploadFileForm_Load(object sender, EventArgs e)
        {
            ProtocolDecoder.Singleton.OnUploadFileResponse += OnUploadFileResponse;
            ProtocolDecoder.Singleton.OnGetFileListResponse += OnGetFileListResponse;

            SendGetFileListCMD();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            SendGetFileListCMD();
        }

        /// <summary>
        /// 上传文件请求回调
        /// </summary>
        /// <param name="obj"></param>
        private void OnUploadFileResponse(UploadFileResponse msg)
        {
            btnUploadFile.Enabled = true;

            if (msg == null)
            {
                return;
            }

            MessageBoxEx.Show(msg.Result.Code == 1 ? "上传成功" : msg.Result.Msg);
            SendGetFileListCMD();
        }

        /// <summary>
        /// 获取文件列表响应回调
        /// </summary>
        /// <param name="msg"></param>
        private void OnGetFileListResponse(GetFileListResponse msg)
        {
            if (msg == null || msg.Result.Code != 1 || msg.FileList == null || msg.FileList.Count <= 0)
            {
                return;
            }

            // 把文件增加到列表
            lvwFiles.BeginUpdate();
            lvwFiles.Items.Clear();
            foreach (var file in msg.FileList)
            {
                var item = lvwFiles.Items.Add(file.UserID);
                item.SubItems.Add(file.FileName);
                item.SubItems.Add(file.FileSize.ToString());
                item.SubItems.Add(file.DownUrl);
            }
            lvwFiles.EndUpdate();
        }

        private void btnUploadFile_Click(object sender, EventArgs e)
        {
            if (GlobalResourceManager.CurrentUser == null || String.IsNullOrEmpty(GlobalResourceManager.CurrentUser.UserID))
            {
                return;
            }

            String file = txtFile.SkinTxt.Text;
            if (!File.Exists(file))
            {
                MessageBoxEx.Show($"{file} 文件不存在");
                return;
            }

            //判断文件大小,不能大于300M
            FileInfo fInfo = new FileInfo(file);
            if (fInfo.Length > 300 * 1024 * 1024)
            {
                MessageBoxEx.Show("上传文件不能大于300M");
                return;
            }

            btnUploadFile.Enabled = false;
            BaseTask.Singleton.AppendTask(60, () => { btnUploadFile.Enabled = true; });

            UploadFileRequest request = new UploadFileRequest();
            request.FromUserID = GlobalResourceManager.CurrentUser.UserID;
            request.ToUserID = "";
            request.UserType = 0;
            request.FileName = Path.GetFileName(txtFile.Text);

            Byte[] byData = File.ReadAllBytes(txtFile.Text);
            request.Data = ByteString.CopyFrom(byData);

            TCPClient.Singleton.SendProtoMessage(CMD.UploadFileRequestCMD, request);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                String file = dialog.FileName;
                if (!File.Exists(file))
                {
                    MessageBoxEx.Show($"{file} 文件不存在");
                    return;
                }

                //判断文件大小,不能大于300M
                FileInfo fInfo = new FileInfo(file);
                if (fInfo.Length > 300 * 1024 * 1024)
                {
                    MessageBoxEx.Show("上传文件不能大于300M");
                    return;
                }

                txtFile.SkinTxt.Text = file;
            }
        }

        private void lvwFiles_Click(object sender, EventArgs e)
        {
            if (lvwFiles == null || lvwFiles.SelectedItems == null || lvwFiles.SelectedItems.Count <= 0)
            {
                return;
            }

            try
            {
                String url = lvwFiles.SelectedItems[0].SubItems[3].Text;
                String fileName = lvwFiles.SelectedItems[0].SubItems[1].Text;
                String filePath = Path.Combine(GlobalResourceManager.AppPath, "downfiles");
                if (!Directory.Exists(filePath))
                {
                    Directory.CreateDirectory(filePath);
                }

                Utils.DownFile(url, Path.Combine(filePath, fileName));
                Process.Start(filePath);
            }
            catch(Exception ex)
            {
                MessageBoxEx.Show(ex.ToString());
            }
        }
    }
}