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
			this.label5 = new System.Windows.Forms.Label();
			this.tb_author = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.tb_title = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.list_copy = new System.Windows.Forms.ListView();
			this.tb_category = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.btn_borrow = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(21, 24);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(37, 15);
			this.label5.TabIndex = 30;
			this.label5.Text = "분류";
			// 
			// tb_author
			// 
			this.tb_author.Location = new System.Drawing.Point(493, 20);
			this.tb_author.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.tb_author.Name = "tb_author";
			this.tb_author.ReadOnly = true;
			this.tb_author.Size = new System.Drawing.Size(127, 25);
			this.tb_author.TabIndex = 29;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(453, 25);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(37, 15);
			this.label4.TabIndex = 28;
			this.label4.Text = "저자";
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
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(191, 25);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(37, 15);
			this.label1.TabIndex = 24;
			this.label1.Text = "제목";
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(645, 19);
			this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(94, 29);
			this.button2.TabIndex = 33;
			this.button2.Text = "전체 삭제";
			this.button2.UseVisualStyleBackColor = true;
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
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(544, 329);
			this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(94, 29);
			this.button1.TabIndex = 36;
			this.button1.Text = "선택 삭제";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(645, 329);
			this.button3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(94, 29);
			this.button3.TabIndex = 37;
			this.button3.Text = "대출 연장";
			this.button3.UseVisualStyleBackColor = true;
			// 
			// btn_borrow
			// 
			this.btn_borrow.BackColor = System.Drawing.Color.Gold;
			this.btn_borrow.Location = new System.Drawing.Point(452, 329);
			this.btn_borrow.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.btn_borrow.Name = "btn_borrow";
			this.btn_borrow.Size = new System.Drawing.Size(86, 29);
			this.btn_borrow.TabIndex = 38;
			this.btn_borrow.Text = "대출";
			this.btn_borrow.UseVisualStyleBackColor = false;
			this.btn_borrow.Click += new System.EventHandler(this.btn_borrow_Click);
			// 
			// BookDetailForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(752, 369);
			this.Controls.Add(this.btn_borrow);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.tb_category);
			this.Controls.Add(this.list_copy);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.tb_author);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.tb_title);
			this.Controls.Add(this.label1);
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "BookDetailForm";
			this.Text = "상세 정보";
			this.Load += new System.EventHandler(this.BookDetailForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_author;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListView list_copy;
        private System.Windows.Forms.TextBox tb_category;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button btn_borrow;
	}
}