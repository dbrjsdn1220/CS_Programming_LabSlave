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
			this.tb_author = new System.Windows.Forms.TextBox();
			this.lb_bookAuthor = new System.Windows.Forms.Label();
			this.tb_title = new System.Windows.Forms.TextBox();
			this.lb_bookTitle = new System.Windows.Forms.Label();
			this.list_copy = new System.Windows.Forms.ListView();
			this.tb_category = new System.Windows.Forms.TextBox();
			this.btn_extend = new System.Windows.Forms.Button();
			this.btn_borrow = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lb_bookCategory
			// 
			this.lb_bookCategory.AutoSize = true;
			this.lb_bookCategory.Location = new System.Drawing.Point(21, 24);
			this.lb_bookCategory.Name = "lb_bookCategory";
			this.lb_bookCategory.Size = new System.Drawing.Size(37, 15);
			this.lb_bookCategory.TabIndex = 30;
			this.lb_bookCategory.Text = "분류";
			// 
			// tb_author
			// 
			this.tb_author.Location = new System.Drawing.Point(493, 20);
			this.tb_author.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.tb_author.Name = "tb_author";
			this.tb_author.ReadOnly = true;
			this.tb_author.Size = new System.Drawing.Size(206, 25);
			this.tb_author.TabIndex = 29;
			// 
			// lb_bookAuthor
			// 
			this.lb_bookAuthor.AutoSize = true;
			this.lb_bookAuthor.Location = new System.Drawing.Point(453, 25);
			this.lb_bookAuthor.Name = "lb_bookAuthor";
			this.lb_bookAuthor.Size = new System.Drawing.Size(37, 15);
			this.lb_bookAuthor.TabIndex = 28;
			this.lb_bookAuthor.Text = "저자";
			// 
			// tb_title
			// 
			this.tb_title.Location = new System.Drawing.Point(231, 20);
			this.tb_title.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.tb_title.Name = "tb_title";
			this.tb_title.ReadOnly = true;
			this.tb_title.Size = new System.Drawing.Size(189, 25);
			this.tb_title.TabIndex = 25;
			// 
			// lb_bookTitle
			// 
			this.lb_bookTitle.AutoSize = true;
			this.lb_bookTitle.Location = new System.Drawing.Point(191, 25);
			this.lb_bookTitle.Name = "lb_bookTitle";
			this.lb_bookTitle.Size = new System.Drawing.Size(37, 15);
			this.lb_bookTitle.TabIndex = 24;
			this.lb_bookTitle.Text = "제목";
			// 
			// list_copy
			// 
			this.list_copy.FullRowSelect = true;
			this.list_copy.GridLines = true;
			this.list_copy.HideSelection = false;
			this.list_copy.Location = new System.Drawing.Point(14, 64);
			this.list_copy.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.list_copy.Name = "list_copy";
			this.list_copy.Size = new System.Drawing.Size(724, 255);
			this.list_copy.TabIndex = 34;
			this.list_copy.UseCompatibleStateImageBehavior = false;
			this.list_copy.View = System.Windows.Forms.View.Details;
			// 
			// tb_category
			// 
			this.tb_category.Location = new System.Drawing.Point(61, 19);
			this.tb_category.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.tb_category.Name = "tb_category";
			this.tb_category.ReadOnly = true;
			this.tb_category.Size = new System.Drawing.Size(99, 25);
			this.tb_category.TabIndex = 35;
			// 
			// btn_extend
			// 
			this.btn_extend.Location = new System.Drawing.Point(645, 329);
			this.btn_extend.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.btn_extend.Name = "btn_extend";
			this.btn_extend.Size = new System.Drawing.Size(94, 29);
			this.btn_extend.TabIndex = 37;
			this.btn_extend.Text = "대출 연장";
			this.btn_extend.UseVisualStyleBackColor = true;
			this.btn_extend.Click += new System.EventHandler(this.btn_extend_Click);
			// 
			// btn_borrow
			// 
			this.btn_borrow.BackColor = System.Drawing.Color.Gold;
			this.btn_borrow.Location = new System.Drawing.Point(544, 329);
			this.btn_borrow.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.btn_borrow.Name = "btn_borrow";
			this.btn_borrow.Size = new System.Drawing.Size(95, 29);
			this.btn_borrow.TabIndex = 38;
			this.btn_borrow.Text = "상호 작용";
			this.btn_borrow.UseVisualStyleBackColor = false;
			this.btn_borrow.Click += new System.EventHandler(this.btn_borrow_Click);
			// 
			// BookDetailForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(752, 369);
			this.Controls.Add(this.btn_borrow);
			this.Controls.Add(this.btn_extend);
			this.Controls.Add(this.tb_category);
			this.Controls.Add(this.list_copy);
			this.Controls.Add(this.lb_bookCategory);
			this.Controls.Add(this.tb_author);
			this.Controls.Add(this.lb_bookAuthor);
			this.Controls.Add(this.tb_title);
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
        private System.Windows.Forms.TextBox tb_author;
        private System.Windows.Forms.Label lb_bookAuthor;
        private System.Windows.Forms.TextBox tb_title;
        private System.Windows.Forms.Label lb_bookTitle;
        private System.Windows.Forms.ListView list_copy;
        private System.Windows.Forms.TextBox tb_category;
        private System.Windows.Forms.Button btn_extend;
		private System.Windows.Forms.Button btn_borrow;
	}
}