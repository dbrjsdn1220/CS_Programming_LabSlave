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
			this.label1 = new System.Windows.Forms.Label();
			this.btn_search = new System.Windows.Forms.Button();
			this.btn_manage = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("돋움", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label1.Location = new System.Drawing.Point(31, 29);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(325, 47);
			this.label1.TabIndex = 0;
			this.label1.Text = "경남대 도서관";
			// 
			// btn_search
			// 
			this.btn_search.Location = new System.Drawing.Point(84, 120);
			this.btn_search.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.btn_search.Name = "btn_search";
			this.btn_search.Size = new System.Drawing.Size(86, 29);
			this.btn_search.TabIndex = 1;
			this.btn_search.Text = "조회";
			this.btn_search.UseVisualStyleBackColor = true;
			this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
			// 
			// btn_manage
			// 
			this.btn_manage.Location = new System.Drawing.Point(191, 120);
			this.btn_manage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.btn_manage.Name = "btn_manage";
			this.btn_manage.Size = new System.Drawing.Size(86, 29);
			this.btn_manage.TabIndex = 3;
			this.btn_manage.Text = "관리";
			this.btn_manage.UseVisualStyleBackColor = true;
			this.btn_manage.Click += new System.EventHandler(this.btn_manage_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(355, 179);
			this.Controls.Add(this.btn_manage);
			this.Controls.Add(this.btn_search);
			this.Controls.Add(this.label1);
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "MainForm";
			this.Text = "경남대 도서관";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_manage;
    }
}

