namespace Management_Books
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
			this.lb_title = new System.Windows.Forms.Label();
			this.btn_search = new System.Windows.Forms.Button();
			this.btn_manage = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lb_title
			// 
			this.lb_title.Cursor = System.Windows.Forms.Cursors.Default;
			this.lb_title.Dock = System.Windows.Forms.DockStyle.Top;
			this.lb_title.Font = new System.Drawing.Font("맑은 고딕", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.lb_title.Location = new System.Drawing.Point(0, 0);
			this.lb_title.Name = "lb_title";
			this.lb_title.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lb_title.Size = new System.Drawing.Size(350, 123);
			this.lb_title.TabIndex = 0;
			this.lb_title.Text = "경남대 도서관";
			this.lb_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btn_search
			// 
			this.btn_search.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.btn_search.Location = new System.Drawing.Point(12, 137);
			this.btn_search.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.btn_search.Name = "btn_search";
			this.btn_search.Size = new System.Drawing.Size(150, 50);
			this.btn_search.TabIndex = 1;
			this.btn_search.Text = "도서 조회";
			this.btn_search.UseVisualStyleBackColor = true;
			this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
			// 
			// btn_manage
			// 
			this.btn_manage.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.btn_manage.Location = new System.Drawing.Point(188, 137);
			this.btn_manage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.btn_manage.Name = "btn_manage";
			this.btn_manage.Size = new System.Drawing.Size(150, 50);
			this.btn_manage.TabIndex = 3;
			this.btn_manage.Text = "관리자 모드";
			this.btn_manage.UseVisualStyleBackColor = true;
			this.btn_manage.Click += new System.EventHandler(this.btn_manage_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(350, 200);
			this.Controls.Add(this.btn_manage);
			this.Controls.Add(this.btn_search);
			this.Controls.Add(this.lb_title);
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "MainForm";
			this.Text = "도서 프로그램";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lb_title;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_manage;
    }
}

