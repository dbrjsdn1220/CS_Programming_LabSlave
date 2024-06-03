namespace Management_Books
{
	partial class BookDetailForm_user
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
			this.tb_bookCategory = new System.Windows.Forms.TextBox();
			this.lb_bookCategory = new System.Windows.Forms.Label();
			this.tb_bookAuthor = new System.Windows.Forms.TextBox();
			this.lb_bookAuthor = new System.Windows.Forms.Label();
			this.tb_bookTitle = new System.Windows.Forms.TextBox();
			this.lb_bookTitle = new System.Windows.Forms.Label();
			this.list_copy = new System.Windows.Forms.ListView();
			this.lb_title = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// tb_bookCategory
			// 
			this.tb_bookCategory.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.tb_bookCategory.Location = new System.Drawing.Point(608, 13);
			this.tb_bookCategory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.tb_bookCategory.Name = "tb_bookCategory";
			this.tb_bookCategory.ReadOnly = true;
			this.tb_bookCategory.Size = new System.Drawing.Size(180, 30);
			this.tb_bookCategory.TabIndex = 46;
			// 
			// lb_bookCategory
			// 
			this.lb_bookCategory.AutoSize = true;
			this.lb_bookCategory.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.lb_bookCategory.Location = new System.Drawing.Point(506, 16);
			this.lb_bookCategory.Name = "lb_bookCategory";
			this.lb_bookCategory.Size = new System.Drawing.Size(91, 23);
			this.lb_bookCategory.TabIndex = 43;
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
			this.tb_bookAuthor.TabIndex = 42;
			// 
			// lb_bookAuthor
			// 
			this.lb_bookAuthor.AutoSize = true;
			this.lb_bookAuthor.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.lb_bookAuthor.Location = new System.Drawing.Point(506, 92);
			this.lb_bookAuthor.Name = "lb_bookAuthor";
			this.lb_bookAuthor.Size = new System.Drawing.Size(91, 23);
			this.lb_bookAuthor.TabIndex = 41;
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
			this.tb_bookTitle.TabIndex = 40;
			// 
			// lb_bookTitle
			// 
			this.lb_bookTitle.AutoSize = true;
			this.lb_bookTitle.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.lb_bookTitle.Location = new System.Drawing.Point(506, 54);
			this.lb_bookTitle.Name = "lb_bookTitle";
			this.lb_bookTitle.Size = new System.Drawing.Size(91, 23);
			this.lb_bookTitle.TabIndex = 39;
			this.lb_bookTitle.Text = "도서 제목";
			// 
			// list_copy
			// 
			this.list_copy.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.list_copy.FullRowSelect = true;
			this.list_copy.GridLines = true;
			this.list_copy.HideSelection = false;
			this.list_copy.Location = new System.Drawing.Point(12, 134);
			this.list_copy.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.list_copy.Name = "list_copy";
			this.list_copy.Size = new System.Drawing.Size(776, 228);
			this.list_copy.TabIndex = 47;
			this.list_copy.UseCompatibleStateImageBehavior = false;
			this.list_copy.View = System.Windows.Forms.View.Details;
			// 
			// lb_title
			// 
			this.lb_title.AutoSize = true;
			this.lb_title.Font = new System.Drawing.Font("나눔바른고딕", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.lb_title.Location = new System.Drawing.Point(4, 9);
			this.lb_title.Name = "lb_title";
			this.lb_title.Size = new System.Drawing.Size(299, 46);
			this.lb_title.TabIndex = 48;
			this.lb_title.Text = "도서 상세 페이지";
			// 
			// BookDetailForm_user
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 375);
			this.Controls.Add(this.lb_title);
			this.Controls.Add(this.list_copy);
			this.Controls.Add(this.tb_bookCategory);
			this.Controls.Add(this.lb_bookCategory);
			this.Controls.Add(this.tb_bookAuthor);
			this.Controls.Add(this.lb_bookAuthor);
			this.Controls.Add(this.tb_bookTitle);
			this.Controls.Add(this.lb_bookTitle);
			this.Name = "BookDetailForm_user";
			this.Text = "상세 정보";
			this.Load += new System.EventHandler(this.BookDetailForm_user_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.TextBox tb_bookCategory;
		private System.Windows.Forms.Label lb_bookCategory;
		private System.Windows.Forms.TextBox tb_bookAuthor;
		private System.Windows.Forms.Label lb_bookAuthor;
		private System.Windows.Forms.TextBox tb_bookTitle;
		private System.Windows.Forms.Label lb_bookTitle;
		private System.Windows.Forms.ListView list_copy;
		private System.Windows.Forms.Label lb_title;
	}
}