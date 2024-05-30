namespace Management_Books
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
			this.tb_userPwd = new System.Windows.Forms.TextBox();
			this.lb_userPwd = new System.Windows.Forms.Label();
			this.lb_userId = new System.Windows.Forms.Label();
			this.tb_userId = new System.Windows.Forms.TextBox();
			this.btn_login = new System.Windows.Forms.Button();
			this.pb_userPwd = new System.Windows.Forms.PictureBox();
			this.lb_title = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pb_userPwd)).BeginInit();
			this.SuspendLayout();
			// 
			// tb_userPwd
			// 
			this.tb_userPwd.Location = new System.Drawing.Point(102, 206);
			this.tb_userPwd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.tb_userPwd.Name = "tb_userPwd";
			this.tb_userPwd.Size = new System.Drawing.Size(200, 25);
			this.tb_userPwd.TabIndex = 8;
			this.tb_userPwd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_pwd_KeyDown);
			// 
			// lb_userPwd
			// 
			this.lb_userPwd.AutoSize = true;
			this.lb_userPwd.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.lb_userPwd.Location = new System.Drawing.Point(10, 207);
			this.lb_userPwd.Name = "lb_userPwd";
			this.lb_userPwd.Size = new System.Drawing.Size(86, 23);
			this.lb_userPwd.TabIndex = 7;
			this.lb_userPwd.Text = "비밀번호";
			// 
			// lb_userId
			// 
			this.lb_userId.AutoSize = true;
			this.lb_userId.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.lb_userId.Location = new System.Drawing.Point(12, 173);
			this.lb_userId.Name = "lb_userId";
			this.lb_userId.Size = new System.Drawing.Size(72, 23);
			this.lb_userId.TabIndex = 6;
			this.lb_userId.Text = " 아이디";
			// 
			// tb_userId
			// 
			this.tb_userId.Location = new System.Drawing.Point(102, 171);
			this.tb_userId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.tb_userId.Name = "tb_userId";
			this.tb_userId.Size = new System.Drawing.Size(200, 25);
			this.tb_userId.TabIndex = 5;
			// 
			// btn_login
			// 
			this.btn_login.BackColor = System.Drawing.Color.Gold;
			this.btn_login.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.btn_login.Location = new System.Drawing.Point(354, 171);
			this.btn_login.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.btn_login.Name = "btn_login";
			this.btn_login.Size = new System.Drawing.Size(125, 60);
			this.btn_login.TabIndex = 10;
			this.btn_login.Text = "로그인";
			this.btn_login.UseVisualStyleBackColor = false;
			this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
			// 
			// pb_userPwd
			// 
			this.pb_userPwd.ErrorImage = null;
			this.pb_userPwd.Image = global::Management_Books.Properties.Resources.hide_pwd;
			this.pb_userPwd.InitialImage = null;
			this.pb_userPwd.Location = new System.Drawing.Point(308, 207);
			this.pb_userPwd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.pb_userPwd.Name = "pb_userPwd";
			this.pb_userPwd.Size = new System.Drawing.Size(23, 24);
			this.pb_userPwd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pb_userPwd.TabIndex = 11;
			this.pb_userPwd.TabStop = false;
			this.pb_userPwd.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
			this.pb_userPwd.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pb_pwd_MouseUp);
			// 
			// lb_title
			// 
			this.lb_title.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lb_title.AutoSize = true;
			this.lb_title.Font = new System.Drawing.Font("맑은 고딕", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.lb_title.Location = new System.Drawing.Point(73, 19);
			this.lb_title.Name = "lb_title";
			this.lb_title.Size = new System.Drawing.Size(360, 62);
			this.lb_title.TabIndex = 12;
			this.lb_title.Text = "  관리자 로그인";
			this.lb_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// LoginForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(500, 250);
			this.Controls.Add(this.lb_title);
			this.Controls.Add(this.pb_userPwd);
			this.Controls.Add(this.btn_login);
			this.Controls.Add(this.lb_userPwd);
			this.Controls.Add(this.tb_userPwd);
			this.Controls.Add(this.lb_userId);
			this.Controls.Add(this.tb_userId);
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "LoginForm";
			this.Text = "도서 프로그램 (관리자 모드)";
			this.Load += new System.EventHandler(this.LoginFoam_Load);
			((System.ComponentModel.ISupportInitialize)(this.pb_userPwd)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_userPwd;
        private System.Windows.Forms.Label lb_userPwd;
        private System.Windows.Forms.Label lb_userId;
        private System.Windows.Forms.TextBox tb_userId;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.PictureBox pb_userPwd;
		private System.Windows.Forms.Label lb_title;
	}
}