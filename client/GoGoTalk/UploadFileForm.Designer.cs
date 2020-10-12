namespace GoGoTalk
{
    partial class UploadFileForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UploadFileForm));
            this.btnCancel = new CCWin.SkinControl.SkinButton();
            this.btnUploadFile = new CCWin.SkinControl.SkinButton();
            this.lvwFiles = new System.Windows.Forms.ListView();
            this.colUserID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colFileName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colFileSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDownUrl = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnRefresh = new CCWin.SkinControl.SkinButton();
            this.txtFile = new CCWin.SkinControl.SkinTextBox();
            this.skinLabel5 = new CCWin.SkinControl.SkinLabel();
            this.txtOpen = new CCWin.SkinControl.SkinButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(159)))), ((int)(((byte)(215)))));
            this.btnCancel.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnCancel.DownBack = ((System.Drawing.Image)(resources.GetObject("btnCancel.DownBack")));
            this.btnCancel.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.btnCancel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCancel.Location = new System.Drawing.Point(398, 61);
            this.btnCancel.MouseBack = ((System.Drawing.Image)(resources.GetObject("btnCancel.MouseBack")));
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.NormlBack = ((System.Drawing.Image)(resources.GetObject("btnCancel.NormlBack")));
            this.btnCancel.Size = new System.Drawing.Size(69, 24);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnUploadFile
            // 
            this.btnUploadFile.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnUploadFile.BackColor = System.Drawing.Color.Transparent;
            this.btnUploadFile.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(159)))), ((int)(((byte)(215)))));
            this.btnUploadFile.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnUploadFile.DownBack = ((System.Drawing.Image)(resources.GetObject("btnUploadFile.DownBack")));
            this.btnUploadFile.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.btnUploadFile.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnUploadFile.Location = new System.Drawing.Point(280, 61);
            this.btnUploadFile.MouseBack = ((System.Drawing.Image)(resources.GetObject("btnUploadFile.MouseBack")));
            this.btnUploadFile.Name = "btnUploadFile";
            this.btnUploadFile.NormlBack = ((System.Drawing.Image)(resources.GetObject("btnUploadFile.NormlBack")));
            this.btnUploadFile.Size = new System.Drawing.Size(69, 24);
            this.btnUploadFile.TabIndex = 8;
            this.btnUploadFile.Text = "上传";
            this.btnUploadFile.UseVisualStyleBackColor = false;
            this.btnUploadFile.Click += new System.EventHandler(this.btnUploadFile_Click);
            // 
            // lvwFiles
            // 
            this.lvwFiles.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lvwFiles.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvwFiles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colUserID,
            this.colFileName,
            this.colFileSize,
            this.colDownUrl});
            this.lvwFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwFiles.FullRowSelect = true;
            this.lvwFiles.GridLines = true;
            this.lvwFiles.HideSelection = false;
            this.lvwFiles.HotTracking = true;
            this.lvwFiles.HoverSelection = true;
            this.lvwFiles.LabelWrap = false;
            this.lvwFiles.Location = new System.Drawing.Point(4, 28);
            this.lvwFiles.MultiSelect = false;
            this.lvwFiles.Name = "lvwFiles";
            this.lvwFiles.Size = new System.Drawing.Size(915, 430);
            this.lvwFiles.TabIndex = 10;
            this.lvwFiles.UseCompatibleStateImageBehavior = false;
            this.lvwFiles.View = System.Windows.Forms.View.Details;
            this.lvwFiles.Click += new System.EventHandler(this.lvwFiles_Click);
            // 
            // colUserID
            // 
            this.colUserID.Text = "上传者";
            this.colUserID.Width = 100;
            // 
            // colFileName
            // 
            this.colFileName.Text = "文件名";
            this.colFileName.Width = 150;
            // 
            // colFileSize
            // 
            this.colFileSize.Text = "大小";
            this.colFileSize.Width = 100;
            // 
            // colDownUrl
            // 
            this.colDownUrl.Text = "下载地址";
            this.colDownUrl.Width = 530;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnRefresh.BackColor = System.Drawing.Color.Transparent;
            this.btnRefresh.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(159)))), ((int)(((byte)(215)))));
            this.btnRefresh.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnRefresh.DownBack = ((System.Drawing.Image)(resources.GetObject("btnRefresh.DownBack")));
            this.btnRefresh.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.btnRefresh.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnRefresh.Location = new System.Drawing.Point(516, 61);
            this.btnRefresh.MouseBack = ((System.Drawing.Image)(resources.GetObject("btnRefresh.MouseBack")));
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.NormlBack = ((System.Drawing.Image)(resources.GetObject("btnRefresh.NormlBack")));
            this.btnRefresh.Size = new System.Drawing.Size(69, 24);
            this.btnRefresh.TabIndex = 11;
            this.btnRefresh.Text = "刷新";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // txtFile
            // 
            this.txtFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFile.BackColor = System.Drawing.Color.Transparent;
            this.txtFile.DownBack = null;
            this.txtFile.Icon = null;
            this.txtFile.IconIsButton = false;
            this.txtFile.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtFile.IsPasswordChat = '\0';
            this.txtFile.IsSystemPasswordChar = false;
            this.txtFile.Lines = new string[0];
            this.txtFile.Location = new System.Drawing.Point(68, 20);
            this.txtFile.Margin = new System.Windows.Forms.Padding(0);
            this.txtFile.MaxLength = 32767;
            this.txtFile.MinimumSize = new System.Drawing.Size(28, 28);
            this.txtFile.MouseBack = null;
            this.txtFile.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtFile.Multiline = false;
            this.txtFile.Name = "txtFile";
            this.txtFile.NormlBack = null;
            this.txtFile.Padding = new System.Windows.Forms.Padding(5);
            this.txtFile.ReadOnly = true;
            this.txtFile.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFile.Size = new System.Drawing.Size(747, 28);
            // 
            // 
            // 
            this.txtFile.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFile.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFile.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.txtFile.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.txtFile.SkinTxt.Name = "BaseText";
            this.txtFile.SkinTxt.ReadOnly = true;
            this.txtFile.SkinTxt.Size = new System.Drawing.Size(737, 18);
            this.txtFile.SkinTxt.TabIndex = 5;
            this.txtFile.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtFile.SkinTxt.WaterText = "";
            this.txtFile.TabIndex = 13;
            this.txtFile.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtFile.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtFile.WaterText = "";
            this.txtFile.WordWrap = true;
            // 
            // skinLabel5
            // 
            this.skinLabel5.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel5.AutoSize = true;
            this.skinLabel5.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel5.BorderColor = System.Drawing.Color.White;
            this.skinLabel5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel5.Location = new System.Drawing.Point(5, 24);
            this.skinLabel5.Name = "skinLabel5";
            this.skinLabel5.Size = new System.Drawing.Size(68, 17);
            this.skinLabel5.TabIndex = 12;
            this.skinLabel5.Text = "选择文件：";
            // 
            // txtOpen
            // 
            this.txtOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOpen.BackColor = System.Drawing.Color.Transparent;
            this.txtOpen.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(159)))), ((int)(((byte)(215)))));
            this.txtOpen.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.txtOpen.DownBack = ((System.Drawing.Image)(resources.GetObject("txtOpen.DownBack")));
            this.txtOpen.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.txtOpen.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtOpen.Location = new System.Drawing.Point(824, 24);
            this.txtOpen.MouseBack = ((System.Drawing.Image)(resources.GetObject("txtOpen.MouseBack")));
            this.txtOpen.Name = "txtOpen";
            this.txtOpen.NormlBack = ((System.Drawing.Image)(resources.GetObject("txtOpen.NormlBack")));
            this.txtOpen.Size = new System.Drawing.Size(69, 24);
            this.txtOpen.TabIndex = 14;
            this.txtOpen.Text = "选择";
            this.txtOpen.UseVisualStyleBackColor = false;
            this.txtOpen.Click += new System.EventHandler(this.txtOpen_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Controls.Add(this.txtOpen);
            this.panel1.Controls.Add(this.txtFile);
            this.panel1.Controls.Add(this.skinLabel5);
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnUploadFile);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(4, 458);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(915, 94);
            this.panel1.TabIndex = 15;
            // 
            // UploadFileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 556);
            this.Controls.Add(this.lvwFiles);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = true;
            this.MinimizeBox = true;
            this.Name = "UploadFileForm";
            this.Text = "上传文件";
            this.Load += new System.EventHandler(this.UploadFileForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private CCWin.SkinControl.SkinButton btnCancel;
        private CCWin.SkinControl.SkinButton btnUploadFile;
        private System.Windows.Forms.ListView lvwFiles;
        private System.Windows.Forms.ColumnHeader colUserID;
        private System.Windows.Forms.ColumnHeader colFileName;
        private System.Windows.Forms.ColumnHeader colDownUrl;
        private CCWin.SkinControl.SkinButton btnRefresh;
        private CCWin.SkinControl.SkinTextBox txtFile;
        private CCWin.SkinControl.SkinLabel skinLabel5;
        private CCWin.SkinControl.SkinButton txtOpen;
        private System.Windows.Forms.ColumnHeader colFileSize;
        private System.Windows.Forms.Panel panel1;
    }
}