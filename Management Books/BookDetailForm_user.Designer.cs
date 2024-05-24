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
			this.tb_category = new System.Windows.Forms.TextBox();
			this.list_copy = new System.Windows.Forms.ListView();
			this.label5 = new System.Windows.Forms.Label();
			this.tb_author = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.tb_title = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// tb_category
			// 
			this.tb_category.Location = new System.Drawing.Point(67, 41);
			this.tb_category.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.tb_category.Name = "tb_category";
			this.tb_category.ReadOnly = true;
			this.tb_category.Size = new System.Drawing.Size(99, 25);
			this.tb_category.TabIndex = 46;
			// 
			// list_copy
			// 
			this.list_copy.GridLines = true;
			this.list_copy.HideSelection = false;
			this.list_copy.Location = new System.Drawing.Point(20, 86);
			this.list_copy.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.list_copy.Name = "list_copy";
			this.list_copy.Size = new System.Drawing.Size(724, 255);
			this.list_copy.TabIndex = 45;
			this.list_copy.UseCompatibleStateImageBehavior = false;
			this.list_copy.View = System.Windows.Forms.View.Details;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(27, 46);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(37, 15);
			this.label5.TabIndex = 43;
			this.label5.Text = "분류";
			// 
			// tb_author
			// 
			this.tb_author.Location = new System.Drawing.Point(499, 42);
			this.tb_author.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.tb_author.Name = "tb_author";
			this.tb_author.ReadOnly = true;
			this.tb_author.Size = new System.Drawing.Size(127, 25);
			this.tb_author.TabIndex = 42;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(459, 47);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(37, 15);
			this.label4.TabIndex = 41;
			this.label4.Text = "저자";
			// 
			// tb_title
			// 
			this.tb_title.Location = new System.Drawing.Point(237, 42);
			this.tb_title.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.tb_title.Name = "tb_title";
			this.tb_title.ReadOnly = true;
			this.tb_title.Size = new System.Drawing.Size(189, 25);
			this.tb_title.TabIndex = 40;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(197, 47);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(37, 15);
			this.label1.TabIndex = 39;
			this.label1.Text = "제목";
			// 
			// BookDetailForm_user
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(756, 378);
			this.Controls.Add(this.tb_category);
			this.Controls.Add(this.list_copy);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.tb_author);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.tb_title);
			this.Controls.Add(this.label1);
			this.Name = "BookDetailForm_user";
			this.Text = "상세 정보";
			this.Load += new System.EventHandler(this.BookDetailForm_user_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.TextBox tb_category;
		private System.Windows.Forms.ListView list_copy;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox tb_author;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox tb_title;
		private System.Windows.Forms.Label label1;
	}
}