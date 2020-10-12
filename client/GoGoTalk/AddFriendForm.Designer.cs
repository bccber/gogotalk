namespace GoGoTalk
{
    partial class AddFriendForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddFriendForm));
            this.btnCancel = new CCWin.SkinControl.SkinButton();
            this.btnAdd = new CCWin.SkinControl.SkinButton();
            this.lvwUsers = new System.Windows.Forms.ListView();
            this.colUserID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNicekName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSignature = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnRefresh = new CCWin.SkinControl.SkinButton();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(159)))), ((int)(((byte)(215)))));
            this.btnCancel.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.DownBack = ((System.Drawing.Image)(resources.GetObject("btnCancel.DownBack")));
            this.btnCancel.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.btnCancel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCancel.Location = new System.Drawing.Point(282, 464);
            this.btnCancel.MouseBack = ((System.Drawing.Image)(resources.GetObject("btnCancel.MouseBack")));
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.NormlBack = ((System.Drawing.Image)(resources.GetObject("btnCancel.NormlBack")));
            this.btnCancel.Size = new System.Drawing.Size(69, 24);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(159)))), ((int)(((byte)(215)))));
            this.btnAdd.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnAdd.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAdd.DownBack = ((System.Drawing.Image)(resources.GetObject("btnAdd.DownBack")));
            this.btnAdd.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.btnAdd.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAdd.Location = new System.Drawing.Point(164, 464);
            this.btnAdd.MouseBack = ((System.Drawing.Image)(resources.GetObject("btnAdd.MouseBack")));
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.NormlBack = ((System.Drawing.Image)(resources.GetObject("btnAdd.NormlBack")));
            this.btnAdd.Size = new System.Drawing.Size(69, 24);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "确定";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lvwUsers
            // 
            this.lvwUsers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvwUsers.CheckBoxes = true;
            this.lvwUsers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colUserID,
            this.colNicekName,
            this.colSignature});
            this.lvwUsers.Dock = System.Windows.Forms.DockStyle.Top;
            this.lvwUsers.FullRowSelect = true;
            this.lvwUsers.GridLines = true;
            this.lvwUsers.HideSelection = false;
            this.lvwUsers.LabelWrap = false;
            this.lvwUsers.Location = new System.Drawing.Point(4, 28);
            this.lvwUsers.Name = "lvwUsers";
            this.lvwUsers.Size = new System.Drawing.Size(651, 419);
            this.lvwUsers.TabIndex = 10;
            this.lvwUsers.UseCompatibleStateImageBehavior = false;
            this.lvwUsers.View = System.Windows.Forms.View.Details;
            // 
            // colUserID
            // 
            this.colUserID.Text = "帐号";
            this.colUserID.Width = 150;
            // 
            // colNicekName
            // 
            this.colNicekName.Text = "昵称";
            this.colNicekName.Width = 150;
            // 
            // colSignature
            // 
            this.colSignature.Text = "签名";
            this.colSignature.Width = 330;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnRefresh.BackColor = System.Drawing.Color.Transparent;
            this.btnRefresh.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(159)))), ((int)(((byte)(215)))));
            this.btnRefresh.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnRefresh.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnRefresh.DownBack = ((System.Drawing.Image)(resources.GetObject("btnRefresh.DownBack")));
            this.btnRefresh.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.btnRefresh.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnRefresh.Location = new System.Drawing.Point(400, 464);
            this.btnRefresh.MouseBack = ((System.Drawing.Image)(resources.GetObject("btnRefresh.MouseBack")));
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.NormlBack = ((System.Drawing.Image)(resources.GetObject("btnRefresh.NormlBack")));
            this.btnRefresh.Size = new System.Drawing.Size(69, 24);
            this.btnRefresh.TabIndex = 11;
            this.btnRefresh.Text = "刷新";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // AddFriendForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 505);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.lvwUsers);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Name = "AddFriendForm";
            this.Text = "增加好友";
            this.Load += new System.EventHandler(this.AddFriendForm_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private CCWin.SkinControl.SkinButton btnCancel;
        private CCWin.SkinControl.SkinButton btnAdd;
        private System.Windows.Forms.ListView lvwUsers;
        private System.Windows.Forms.ColumnHeader colUserID;
        private System.Windows.Forms.ColumnHeader colNicekName;
        private System.Windows.Forms.ColumnHeader colSignature;
        private CCWin.SkinControl.SkinButton btnRefresh;
    }
}