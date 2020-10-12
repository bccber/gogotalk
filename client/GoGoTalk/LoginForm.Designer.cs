using System;

namespace GoGoTalk
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.btnLogin = new CCWin.SkinControl.SkinButton();
            this.txtUserID = new CCWin.SkinControl.SkinTextBox();
            this.imgLoadding = new System.Windows.Forms.PictureBox();
            this.checkBoxRememberPwd = new CCWin.SkinControl.SkinCheckBox();
            this.checkBoxAutoLogin = new CCWin.SkinControl.SkinCheckBox();
            this.skinLabel2 = new CCWin.SkinControl.SkinLabel();
            this.btnRegister = new CCWin.SkinControl.SkinButton();
            this.pnlTx = new CCWin.SkinControl.SkinPanel();
            this.panelHeadImage = new CCWin.SkinControl.SkinPanel();
            this.btnStatus = new CCWin.SkinControl.SkinButton();
            this.ItemImonline = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemAway = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemBusy = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemMute = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemInVisble = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripState = new CCWin.SkinControl.SkinContextMenuStrip();
            this.itemQme = new System.Windows.Forms.ToolStripMenuItem();
            this.btnOpenUrl = new CCWin.SkinControl.SkinButton();
            this.skinLabel_SoftName = new CCWin.SkinControl.SkinLabel();
            this.txtPassword = new CCWin.SkinControl.SkinTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgLoadding)).BeginInit();
            this.pnlTx.SuspendLayout();
            this.panelHeadImage.SuspendLayout();
            this.menuStripState.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLogin.BackRectangle = new System.Drawing.Rectangle(50, 23, 50, 23);
            this.btnLogin.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(118)))), ((int)(((byte)(156)))));
            this.btnLogin.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnLogin.Create = true;
            this.btnLogin.DownBack = global::GoGoTalk.Properties.Resources.button_login_down;
            this.btnLogin.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.btnLogin.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.btnLogin.ForeColor = System.Drawing.Color.Black;
            this.btnLogin.Location = new System.Drawing.Point(106, 244);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(0);
            this.btnLogin.MouseBack = global::GoGoTalk.Properties.Resources.button_login_hover;
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.NormlBack = global::GoGoTalk.Properties.Resources.button_login_normal;
            this.btnLogin.Palace = true;
            this.btnLogin.Size = new System.Drawing.Size(185, 49);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "登        录";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtUserID
            // 
            this.txtUserID.BackColor = System.Drawing.Color.Transparent;
            this.txtUserID.DownBack = null;
            this.txtUserID.Icon = null;
            this.txtUserID.IconIsButton = false;
            this.txtUserID.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtUserID.IsPasswordChat = '\0';
            this.txtUserID.IsSystemPasswordChar = false;
            this.txtUserID.Lines = new string[0];
            this.txtUserID.Location = new System.Drawing.Point(119, 138);
            this.txtUserID.Margin = new System.Windows.Forms.Padding(0);
            this.txtUserID.MaxLength = 24;
            this.txtUserID.MinimumSize = new System.Drawing.Size(30, 28);
            this.txtUserID.MouseBack = null;
            this.txtUserID.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtUserID.Multiline = false;
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.NormlBack = null;
            this.txtUserID.Padding = new System.Windows.Forms.Padding(5);
            this.txtUserID.ReadOnly = false;
            this.txtUserID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUserID.Size = new System.Drawing.Size(266, 28);
            // 
            // 
            // 
            this.txtUserID.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUserID.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtUserID.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.txtUserID.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.txtUserID.SkinTxt.MaxLength = 24;
            this.txtUserID.SkinTxt.Name = "BaseText";
            this.txtUserID.SkinTxt.Size = new System.Drawing.Size(256, 18);
            this.txtUserID.SkinTxt.TabIndex = 0;
            this.txtUserID.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtUserID.SkinTxt.WaterText = "帐号";
            this.txtUserID.SkinTxt.WordWrap = false;
            this.txtUserID.TabIndex = 35;
            this.txtUserID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtUserID.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtUserID.WaterText = "帐号";
            this.txtUserID.WordWrap = false;
            // 
            // imgLoadding
            // 
            this.imgLoadding.Image = ((System.Drawing.Image)(resources.GetObject("imgLoadding.Image")));
            this.imgLoadding.Location = new System.Drawing.Point(1, 242);
            this.imgLoadding.Margin = new System.Windows.Forms.Padding(0);
            this.imgLoadding.Name = "imgLoadding";
            this.imgLoadding.Size = new System.Drawing.Size(402, 2);
            this.imgLoadding.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgLoadding.TabIndex = 17;
            this.imgLoadding.TabStop = false;
            this.imgLoadding.Visible = false;
            // 
            // checkBoxRememberPwd
            // 
            this.checkBoxRememberPwd.AutoSize = true;
            this.checkBoxRememberPwd.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxRememberPwd.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.checkBoxRememberPwd.DefaultCheckButtonWidth = 15;
            this.checkBoxRememberPwd.DownBack = global::GoGoTalk.Properties.Resources.checkbox_pushed;
            this.checkBoxRememberPwd.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBoxRememberPwd.ForeColor = System.Drawing.Color.Black;
            this.checkBoxRememberPwd.LightEffect = false;
            this.checkBoxRememberPwd.Location = new System.Drawing.Point(121, 206);
            this.checkBoxRememberPwd.MouseBack = global::GoGoTalk.Properties.Resources.checkbox_hightlight;
            this.checkBoxRememberPwd.Name = "checkBoxRememberPwd";
            this.checkBoxRememberPwd.NormlBack = ((System.Drawing.Image)(resources.GetObject("checkBoxRememberPwd.NormlBack")));
            this.checkBoxRememberPwd.SelectedDownBack = global::GoGoTalk.Properties.Resources.checkbox_tick_pushed;
            this.checkBoxRememberPwd.SelectedMouseBack = global::GoGoTalk.Properties.Resources.checkbox_tick_highlight;
            this.checkBoxRememberPwd.SelectedNormlBack = global::GoGoTalk.Properties.Resources.checkbox_tick_normal;
            this.checkBoxRememberPwd.Size = new System.Drawing.Size(75, 21);
            this.checkBoxRememberPwd.TabIndex = 3;
            this.checkBoxRememberPwd.Text = "记住密码";
            this.checkBoxRememberPwd.UseVisualStyleBackColor = false;
            // 
            // checkBoxAutoLogin
            // 
            this.checkBoxAutoLogin.AutoSize = true;
            this.checkBoxAutoLogin.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxAutoLogin.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.checkBoxAutoLogin.DefaultCheckButtonWidth = 15;
            this.checkBoxAutoLogin.DownBack = global::GoGoTalk.Properties.Resources.checkbox_pushed;
            this.checkBoxAutoLogin.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.checkBoxAutoLogin.ForeColor = System.Drawing.Color.Black;
            this.checkBoxAutoLogin.LightEffect = false;
            this.checkBoxAutoLogin.Location = new System.Drawing.Point(207, 206);
            this.checkBoxAutoLogin.MouseBack = global::GoGoTalk.Properties.Resources.checkbox_hightlight;
            this.checkBoxAutoLogin.Name = "checkBoxAutoLogin";
            this.checkBoxAutoLogin.NormlBack = ((System.Drawing.Image)(resources.GetObject("checkBoxAutoLogin.NormlBack")));
            this.checkBoxAutoLogin.SelectedDownBack = global::GoGoTalk.Properties.Resources.checkbox_tick_pushed;
            this.checkBoxAutoLogin.SelectedMouseBack = global::GoGoTalk.Properties.Resources.checkbox_tick_highlight;
            this.checkBoxAutoLogin.SelectedNormlBack = global::GoGoTalk.Properties.Resources.checkbox_tick_normal;
            this.checkBoxAutoLogin.Size = new System.Drawing.Size(75, 21);
            this.checkBoxAutoLogin.TabIndex = 4;
            this.checkBoxAutoLogin.Text = "自动登录";
            this.checkBoxAutoLogin.UseVisualStyleBackColor = false;
            // 
            // skinLabel2
            // 
            this.skinLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.skinLabel2.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel2.AutoSize = true;
            this.skinLabel2.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel2.BorderColor = System.Drawing.Color.White;
            this.skinLabel2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel2.ForeColor = System.Drawing.Color.DimGray;
            this.skinLabel2.Location = new System.Drawing.Point(287, 90);
            this.skinLabel2.Name = "skinLabel2";
            this.skinLabel2.Size = new System.Drawing.Size(96, 20);
            this.skinLabel2.TabIndex = 18;
            this.skinLabel2.Text = "作者：bccber";
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.Transparent;
            this.btnRegister.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(118)))), ((int)(((byte)(156)))));
            this.btnRegister.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnRegister.Create = true;
            this.btnRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegister.DownBack = global::GoGoTalk.Properties.Resources.zhuce_press;
            this.btnRegister.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.btnRegister.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnRegister.Location = new System.Drawing.Point(332, 208);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(0);
            this.btnRegister.MouseBack = global::GoGoTalk.Properties.Resources.zhuce_hover;
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.NormlBack = global::GoGoTalk.Properties.Resources.zhuce;
            this.btnRegister.Size = new System.Drawing.Size(51, 16);
            this.btnRegister.TabIndex = 8;
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // pnlTx
            // 
            this.pnlTx.BackColor = System.Drawing.Color.Transparent;
            this.pnlTx.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlTx.BackgroundImage")));
            this.pnlTx.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlTx.Controls.Add(this.panelHeadImage);
            this.pnlTx.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.pnlTx.DownBack = null;
            this.pnlTx.Location = new System.Drawing.Point(17, 138);
            this.pnlTx.Margin = new System.Windows.Forms.Padding(0);
            this.pnlTx.MouseBack = null;
            this.pnlTx.Name = "pnlTx";
            this.pnlTx.NormlBack = null;
            this.pnlTx.Size = new System.Drawing.Size(93, 87);
            this.pnlTx.TabIndex = 12;
            // 
            // panelHeadImage
            // 
            this.panelHeadImage.BackColor = System.Drawing.Color.Transparent;
            this.panelHeadImage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelHeadImage.BackgroundImage")));
            this.panelHeadImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelHeadImage.Controls.Add(this.btnStatus);
            this.panelHeadImage.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.panelHeadImage.DownBack = null;
            this.panelHeadImage.Location = new System.Drawing.Point(1, 1);
            this.panelHeadImage.Margin = new System.Windows.Forms.Padding(0);
            this.panelHeadImage.MouseBack = null;
            this.panelHeadImage.Name = "panelHeadImage";
            this.panelHeadImage.NormlBack = null;
            this.panelHeadImage.Radius = 4;
            this.panelHeadImage.Size = new System.Drawing.Size(90, 85);
            this.panelHeadImage.TabIndex = 11;
            // 
            // btnStatus
            // 
            this.btnStatus.BackColor = System.Drawing.Color.Transparent;
            this.btnStatus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStatus.BackRectangle = new System.Drawing.Rectangle(4, 4, 4, 4);
            this.btnStatus.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(118)))), ((int)(((byte)(156)))));
            this.btnStatus.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnStatus.DownBack = global::GoGoTalk.Properties.Resources.allbtn_down;
            this.btnStatus.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.btnStatus.Image = global::GoGoTalk.Properties.Resources.imonline__2_;
            this.btnStatus.ImageSize = new System.Drawing.Size(11, 11);
            this.btnStatus.Location = new System.Drawing.Point(71, 67);
            this.btnStatus.Margin = new System.Windows.Forms.Padding(0);
            this.btnStatus.MouseBack = global::GoGoTalk.Properties.Resources.allbtn_highlight;
            this.btnStatus.Name = "btnStatus";
            this.btnStatus.NormlBack = null;
            this.btnStatus.Size = new System.Drawing.Size(19, 18);
            this.btnStatus.TabIndex = 10;
            this.btnStatus.Tag = "2";
            this.btnStatus.UseVisualStyleBackColor = false;
            this.btnStatus.Click += new System.EventHandler(this.btnStatus_Click);
            // 
            // ItemImonline
            // 
            this.ItemImonline.AutoSize = false;
            this.ItemImonline.Image = global::GoGoTalk.Properties.Resources.imonline__2_;
            this.ItemImonline.Name = "ItemImonline";
            this.ItemImonline.Size = new System.Drawing.Size(105, 22);
            this.ItemImonline.Tag = "2";
            this.ItemImonline.Text = "我在线上";
            this.ItemImonline.ToolTipText = "表示希望好友看到您在线。\r\n声音：开启\r\n消息提醒框：开启\r\n会话消息：任务栏头像闪动\r\n";
            this.ItemImonline.Click += new System.EventHandler(this.Item_Click);
            // 
            // ItemAway
            // 
            this.ItemAway.AutoSize = false;
            this.ItemAway.Image = global::GoGoTalk.Properties.Resources.away__2_;
            this.ItemAway.Name = "ItemAway";
            this.ItemAway.Size = new System.Drawing.Size(105, 22);
            this.ItemAway.Tag = "3";
            this.ItemAway.Text = "离开";
            this.ItemAway.ToolTipText = "表示离开，暂无法处理消息。\r\n声音：开启\r\n消息提醒框：开启\r\n会话消息：任务栏头像闪动\r\n";
            this.ItemAway.Click += new System.EventHandler(this.Item_Click);
            // 
            // ItemBusy
            // 
            this.ItemBusy.AutoSize = false;
            this.ItemBusy.Image = global::GoGoTalk.Properties.Resources.busy__2_;
            this.ItemBusy.Name = "ItemBusy";
            this.ItemBusy.Size = new System.Drawing.Size(105, 22);
            this.ItemBusy.Tag = "4";
            this.ItemBusy.Text = "忙碌";
            this.ItemBusy.ToolTipText = "表示忙碌，不会及时处理消息。\r\n声音：开启\r\n消息提醒框：开启\r\n会话消息：任务栏显示气泡\r\n";
            this.ItemBusy.Click += new System.EventHandler(this.Item_Click);
            // 
            // ItemMute
            // 
            this.ItemMute.AutoSize = false;
            this.ItemMute.Image = global::GoGoTalk.Properties.Resources.mute__2_;
            this.ItemMute.Name = "ItemMute";
            this.ItemMute.Size = new System.Drawing.Size(105, 22);
            this.ItemMute.Tag = "5";
            this.ItemMute.Text = "请勿打扰";
            this.ItemMute.ToolTipText = "表示不想被打扰。\r\n声音：关闭\r\n消息提醒框：关闭\r\n会话消息：任务栏显示气泡\r\n\r\n";
            this.ItemMute.Click += new System.EventHandler(this.Item_Click);
            // 
            // ItemInVisble
            // 
            this.ItemInVisble.AutoSize = false;
            this.ItemInVisble.Image = global::GoGoTalk.Properties.Resources.invisible__2_;
            this.ItemInVisble.Name = "ItemInVisble";
            this.ItemInVisble.Size = new System.Drawing.Size(105, 22);
            this.ItemInVisble.Tag = "6";
            this.ItemInVisble.Text = "隐身";
            this.ItemInVisble.ToolTipText = "表示好友看到您是离线的。\r\n声音：开启\r\n消息提醒框：开启\r\n会话消息：任务栏头像闪动\r\n";
            this.ItemInVisble.Click += new System.EventHandler(this.Item_Click);
            // 
            // menuStripState
            // 
            this.menuStripState.Arrow = System.Drawing.Color.Black;
            this.menuStripState.Back = System.Drawing.Color.White;
            this.menuStripState.BackRadius = 4;
            this.menuStripState.Base = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(200)))), ((int)(((byte)(254)))));
            this.menuStripState.DropDownImageSeparator = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.menuStripState.Fore = System.Drawing.Color.Black;
            this.menuStripState.HoverFore = System.Drawing.Color.White;
            this.menuStripState.ImageScalingSize = new System.Drawing.Size(11, 11);
            this.menuStripState.ItemAnamorphosis = false;
            this.menuStripState.ItemBorder = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.menuStripState.ItemBorderShow = false;
            this.menuStripState.ItemHover = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.menuStripState.ItemPressed = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.menuStripState.ItemRadius = 4;
            this.menuStripState.ItemRadiusStyle = CCWin.SkinClass.RoundStyle.None;
            this.menuStripState.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemQme,
            this.ItemImonline,
            this.ItemAway,
            this.ItemBusy,
            this.ItemMute,
            this.ItemInVisble});
            this.menuStripState.ItemSplitter = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.menuStripState.Name = "MenuState";
            this.menuStripState.RadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.menuStripState.Size = new System.Drawing.Size(125, 136);
            this.menuStripState.SkinAllColor = true;
            this.menuStripState.TitleAnamorphosis = false;
            this.menuStripState.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(228)))), ((int)(((byte)(236)))));
            this.menuStripState.TitleRadius = 4;
            this.menuStripState.TitleRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            // 
            // itemQme
            // 
            this.itemQme.AutoSize = false;
            this.itemQme.Image = global::GoGoTalk.Properties.Resources.Qme__2_;
            this.itemQme.Name = "itemQme";
            this.itemQme.Size = new System.Drawing.Size(180, 22);
            this.itemQme.Tag = "1";
            this.itemQme.Text = "Q我吧";
            this.itemQme.Click += new System.EventHandler(this.Item_Click);
            // 
            // btnOpenUrl
            // 
            this.btnOpenUrl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenUrl.BackColor = System.Drawing.Color.Transparent;
            this.btnOpenUrl.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(159)))), ((int)(((byte)(215)))));
            this.btnOpenUrl.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnOpenUrl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpenUrl.DownBack = null;
            this.btnOpenUrl.DrawType = CCWin.SkinControl.DrawStyle.None;
            this.btnOpenUrl.Image = ((System.Drawing.Image)(resources.GetObject("btnOpenUrl.Image")));
            this.btnOpenUrl.Location = new System.Drawing.Point(383, 272);
            this.btnOpenUrl.Margin = new System.Windows.Forms.Padding(0);
            this.btnOpenUrl.MouseBack = null;
            this.btnOpenUrl.Name = "btnOpenUrl";
            this.btnOpenUrl.NormlBack = null;
            this.btnOpenUrl.Size = new System.Drawing.Size(17, 16);
            this.btnOpenUrl.TabIndex = 128;
            this.btnOpenUrl.UseVisualStyleBackColor = false;
            this.btnOpenUrl.Click += new System.EventHandler(this.btnOpenUrl_Click);
            // 
            // skinLabel_SoftName
            // 
            this.skinLabel_SoftName.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel_SoftName.AutoSize = true;
            this.skinLabel_SoftName.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel_SoftName.BorderColor = System.Drawing.Color.White;
            this.skinLabel_SoftName.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel_SoftName.ForeColor = System.Drawing.Color.Black;
            this.skinLabel_SoftName.Location = new System.Drawing.Point(7, 8);
            this.skinLabel_SoftName.Name = "skinLabel_SoftName";
            this.skinLabel_SoftName.Size = new System.Drawing.Size(75, 20);
            this.skinLabel_SoftName.TabIndex = 18;
            this.skinLabel_SoftName.Text = "GoGoTalk";
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.Transparent;
            this.txtPassword.DownBack = null;
            this.txtPassword.Icon = null;
            this.txtPassword.IconIsButton = false;
            this.txtPassword.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtPassword.IsPasswordChat = '●';
            this.txtPassword.IsSystemPasswordChar = false;
            this.txtPassword.Lines = new string[0];
            this.txtPassword.Location = new System.Drawing.Point(119, 175);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(0);
            this.txtPassword.MaxLength = 24;
            this.txtPassword.MinimumSize = new System.Drawing.Size(30, 28);
            this.txtPassword.MouseBack = null;
            this.txtPassword.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtPassword.Multiline = false;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.NormlBack = null;
            this.txtPassword.Padding = new System.Windows.Forms.Padding(5);
            this.txtPassword.ReadOnly = false;
            this.txtPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPassword.Size = new System.Drawing.Size(266, 28);
            // 
            // 
            // 
            this.txtPassword.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPassword.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.txtPassword.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.txtPassword.SkinTxt.MaxLength = 24;
            this.txtPassword.SkinTxt.Name = "BaseText";
            this.txtPassword.SkinTxt.PasswordChar = '●';
            this.txtPassword.SkinTxt.Size = new System.Drawing.Size(256, 18);
            this.txtPassword.SkinTxt.TabIndex = 0;
            this.txtPassword.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtPassword.SkinTxt.WaterText = "密码";
            this.txtPassword.SkinTxt.WordWrap = false;
            this.txtPassword.TabIndex = 36;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPassword.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtPassword.WaterText = "密码";
            this.txtPassword.WordWrap = false;
            // 
            // LoginForm
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackPalace = global::GoGoTalk.Properties.Resources.texture;
            this.BackToColor = false;
            this.BorderPalace = global::GoGoTalk.Properties.Resources.BackPalace;
            this.ClientSize = new System.Drawing.Size(404, 292);
            this.CloseDownBack = global::GoGoTalk.Properties.Resources.btn_close_down;
            this.CloseMouseBack = global::GoGoTalk.Properties.Resources.btn_close_highlight;
            this.CloseNormlBack = global::GoGoTalk.Properties.Resources.btn_close_disable;
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.btnOpenUrl);
            this.Controls.Add(this.txtUserID);
            this.Controls.Add(this.imgLoadding);
            this.Controls.Add(this.checkBoxRememberPwd);
            this.Controls.Add(this.checkBoxAutoLogin);
            this.Controls.Add(this.skinLabel2);
            this.Controls.Add(this.skinLabel_SoftName);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.pnlTx);
            this.MaxDownBack = global::GoGoTalk.Properties.Resources.btn_max_down;
            this.MaxMouseBack = global::GoGoTalk.Properties.Resources.btn_max_highlight;
            this.MaxNormlBack = global::GoGoTalk.Properties.Resources.btn_max_normal;
            this.MiniDownBack = global::GoGoTalk.Properties.Resources.btn_mini_down;
            this.MiniMouseBack = global::GoGoTalk.Properties.Resources.btn_mini_highlight;
            this.MiniNormlBack = global::GoGoTalk.Properties.Resources.btn_mini_normal;
            this.Name = "LoginForm";
            this.RestoreDownBack = global::GoGoTalk.Properties.Resources.btn_restore_down;
            this.RestoreMouseBack = global::GoGoTalk.Properties.Resources.btn_restore_highlight;
            this.RestoreNormlBack = global::GoGoTalk.Properties.Resources.btn_restore_normal;
            this.ShowBorder = false;
            this.ShowDrawIcon = false;
            this.ShowInTaskbar = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LoginForm_FormClosed);
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgLoadding)).EndInit();
            this.pnlTx.ResumeLayout(false);
            this.panelHeadImage.ResumeLayout(false);
            this.menuStripState.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CCWin.SkinControl.SkinButton btnLogin;
        private CCWin.SkinControl.SkinCheckBox checkBoxAutoLogin;
        private CCWin.SkinControl.SkinButton btnRegister;
        private CCWin.SkinControl.SkinPanel pnlTx;
        private CCWin.SkinControl.SkinPanel panelHeadImage;
        private CCWin.SkinControl.SkinButton btnStatus;
        private CCWin.SkinControl.SkinCheckBox checkBoxRememberPwd;
        private System.Windows.Forms.PictureBox imgLoadding;
        private CCWin.SkinControl.SkinTextBox txtUserID;
        private CCWin.SkinControl.SkinLabel skinLabel2;
        private System.Windows.Forms.ToolStripMenuItem ItemImonline;
        private System.Windows.Forms.ToolStripMenuItem ItemAway;
        private System.Windows.Forms.ToolStripMenuItem ItemBusy;
        private System.Windows.Forms.ToolStripMenuItem ItemMute;
        private System.Windows.Forms.ToolStripMenuItem ItemInVisble;
        private CCWin.SkinControl.SkinContextMenuStrip menuStripState;
        private CCWin.SkinControl.SkinButton btnOpenUrl;
        private CCWin.SkinControl.SkinLabel skinLabel_SoftName;
        private CCWin.SkinControl.SkinTextBox txtPassword;
        private System.Windows.Forms.ToolStripMenuItem itemQme;
    }
}