namespace Management_Books
{
    partial class BookDetailForm
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
			this.lb_bookCategory = new System.Windows.Forms.Label();
			this.tb_bookAuthor = new System.Windows.Forms.TextBox();
			this.lb_bookAuthor = new System.Windows.Forms.Label();
			this.tb_bookTitle = new System.Windows.Forms.TextBox();
			this.lb_bookTitle = new System.Windows.Forms.Label();
			this.list_copy = new System.Windows.Forms.ListView();
			this.tb_bookCategory = new System.Windows.Forms.TextBox();
			this.btn_extend = new System.Windows.Forms.Button();
			this.btn_borrow = new System.Windows.Forms.Button();
			this.lb_title = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lb_bookCategory
			// 
			this.lb_bookCategory.AutoSize = true;
			this.lb_bookCategory.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.lb_bookCategory.Location = new System.Drawing.Point(505, 16);
			this.lb_bookCategory.Name = "lb_bookCategory";
			this.lb_bookCategory.Size = new System.Drawing.Size(91, 23);
			this.lb_bookCategory.TabIndex = 30;
			this.lb_bookCategory.Text = "도서 분류";
			// 
			// tb_bookAuthor
			// 
			this.tb_bookAuthor.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.tb_bookAuthor.Location = new System.Drawing.Point(608, 89);
			this.tb_bookAuthor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.tb_bookAuthor.Name = "tb_bookAuthor";
			this.tb_bookAuthor.ReadOnly = true;
			this.tb_bookAuthor.Size = new System.Drawing.Size(180, 30);
			this.tb_bookAuthor.TabIndex = 29;
			// 
			// lb_bookAuthor
			// 
			this.lb_bookAuthor.AutoSize = true;
			this.lb_bookAuthor.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.lb_bookAuthor.Location = new System.Drawing.Point(505, 92);
			this.lb_bookAuthor.Name = "lb_bookAuthor";
			this.lb_bookAuthor.Size = new System.Drawing.Size(91, 23);
			this.lb_bookAuthor.TabIndex = 28;
			this.lb_bookAuthor.Text = "도서 저자";
			// 
			// tb_bookTitle
			// 
			this.tb_bookTitle.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.tb_bookTitle.Location = new System.Drawing.Point(608, 51);
			this.tb_bookTitle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.tb_bookTitle.Name = "tb_bookTitle";
			this.tb_bookTitle.ReadOnly = true;
			this.tb_bookTitle.Size = new System.Drawing.Size(180, 30);
			this.tb_bookTitle.TabIndex = 25;
			// 
			// lb_bookTitle
			// 
			this.lb_bookTitle.AutoSize = true;
			this.lb_bookTitle.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.lb_bookTitle.Location = new System.Drawing.Point(505, 54);
			this.lb_bookTitle.Name = "lb_bookTitle";
			this.lb_bookTitle.Size = new System.Drawing.Size(91, 23);
			this.lb_bookTitle.TabIndex = 24;
			this.lb_bookTitle.Text = "도서 제목";
			// 
			// list_copy
			// 
			this.list_copy.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.list_copy.FullRowSelect = true;
			this.list_copy.GridLines = true;
			this.list_copy.HideSelection = false;
			this.list_copy.Location = new System.Drawing.Point(175, 134);
			this.list_copy.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.list_copy.Name = "list_copy";
			this.list_copy.Size = new System.Drawing.Size(613, 228);
			this.list_copy.TabIndex = 34;
			this.list_copy.UseCompatibleStateImageBehavior = false;
			this.list_copy.View = System.Windows.Forms.View.Details;
			// 
			// tb_bookCategory
			// 
			this.tb_bookCategory.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.tb_bookCategory.Location = new System.Drawing.Point(608, 13);
			this.tb_bookCategory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.tb_bookCategory.Name = "tb_bookCategory";
			this.tb_bookCategory.ReadOnly = true;
			this.tb_bookCategory.Size = new System.Drawing.Size(180, 30);
			this.tb_bookCategory.TabIndex = 35;
			// 
			// btn_extend
			// 
			this.btn_extend.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.btn_extend.Location = new System.Drawing.Point(12, 252);
			this.btn_extend.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.btn_extend.Name = "btn_extend";
			this.btn_extend.Size = new System.Drawing.Size(150, 110);
			this.btn_extend.TabIndex = 37;
			this.btn_extend.Text = "대출 연장";
			this.btn_extend.UseVisualStyleBackColor = true;
			this.btn_extend.Click += new System.EventHandler(this.btn_extend_Click);
			// 
			// btn_borrow
			// 
			this.btn_borrow.BackColor = System.Drawing.Color.Gold;
			this.btn_borrow.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.btn_borrow.Location = new System.Drawing.Point(12, 134);
			this.btn_borrow.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.btn_borrow.Name = "btn_borrow";
			this.btn_borrow.Size = new System.Drawing.Size(150, 110);
			this.btn_borrow.TabIndex = 38;
			this.btn_borrow.Text = "상호 작용";
			this.btn_borrow.UseVisualStyleBackColor = false;
			this.btn_borrow.Click += new System.EventHandler(this.btn_borrow_Click);
			// 
			// lb_title
			// 
			this.lb_title.AutoSize = true;
			this.lb_title.Font = new System.Drawing.Font("나눔바른고딕", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.lb_title.Location = new System.Drawing.Point(4, 9);
			this.lb_title.Name = "lb_title";
			this.lb_title.Size = new System.Drawing.Size(299, 46);
			this.lb_title.TabIndex = 40;
			this.lb_title.Text = "도서 상세 페이지";
			// 
			// BookDetailForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 375);
			this.Controls.Add(this.lb_title);
			this.Controls.Add(this.btn_borrow);
			this.Controls.Add(this.btn_extend);
			this.Controls.Add(this.tb_bookCategory);
			this.Controls.Add(this.list_copy);
			this.Controls.Add(this.lb_bookCategory);
			this.Controls.Add(this.tb_bookAuthor);
			this.Controls.Add(this.lb_bookAuthor);
			this.Controls.Add(this.tb_bookTitle);
			this.Controls.Add(this.lb_bookTitle);
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "BookDetailForm";
			this.Text = "상세 정보";
			this.Load += new System.EventHandler(this.BookDetailForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lb_bookCategory;
        private System.Windows.Forms.TextBox tb_bookAuthor;
        private System.Windows.Forms.Label lb_bookAuthor;
        private System.Windows.Forms.TextBox tb_bookTitle;
        private System.Windows.Forms.Label lb_bookTitle;
        private System.Windows.Forms.ListView list_copy;
        private System.Windows.Forms.TextBox tb_bookCategory;
        private System.Windows.Forms.Button btn_extend;
		private System.Windows.Forms.Button btn_borrow;
		private System.Windows.Forms.Label lb_title;
	}
}