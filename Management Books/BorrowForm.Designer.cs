namespace Management_Books
{
    partial class BorrowForm
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
			this.btn_borrow = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.tb_bookId = new System.Windows.Forms.TextBox();
			this.cb_grade = new System.Windows.Forms.ComboBox();
			this.cb_class = new System.Windows.Forms.ComboBox();
			this.cb_number = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.tb_bookTitle = new System.Windows.Forms.TextBox();
			this.btn_return = new System.Windows.Forms.Button();
			this.btn_select = new System.Windows.Forms.Button();
			this.list_loan = new System.Windows.Forms.ListView();
			this.label6 = new System.Windows.Forms.Label();
			this.tb_bookAuthor = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// btn_borrow
			// 
			this.btn_borrow.BackColor = System.Drawing.Color.Gold;
			this.btn_borrow.Location = new System.Drawing.Point(30, 266);
			this.btn_borrow.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.btn_borrow.Name = "btn_borrow";
			this.btn_borrow.Size = new System.Drawing.Size(86, 29);
			this.btn_borrow.TabIndex = 15;
			this.btn_borrow.Text = "대출";
			this.btn_borrow.UseVisualStyleBackColor = false;
			this.btn_borrow.Click += new System.EventHandler(this.btn_borrow_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(87, 168);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(37, 15);
			this.label3.TabIndex = 13;
			this.label3.Text = "학년";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(41, 37);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(40, 15);
			this.label2.TabIndex = 12;
			this.label2.Text = "책 ID";
			// 
			// tb_bookId
			// 
			this.tb_bookId.Location = new System.Drawing.Point(90, 34);
			this.tb_bookId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.tb_bookId.Name = "tb_bookId";
			this.tb_bookId.Size = new System.Drawing.Size(198, 25);
			this.tb_bookId.TabIndex = 11;
			// 
			// cb_grade
			// 
			this.cb_grade.DisplayMember = "제목";
			this.cb_grade.Font = new System.Drawing.Font("돋움", 9F);
			this.cb_grade.FormattingEnabled = true;
			this.cb_grade.Location = new System.Drawing.Point(19, 165);
			this.cb_grade.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.cb_grade.Name = "cb_grade";
			this.cb_grade.Size = new System.Drawing.Size(62, 23);
			this.cb_grade.TabIndex = 26;
			this.cb_grade.ValueMember = "제목";
			// 
			// cb_class
			// 
			this.cb_class.DisplayMember = "제목";
			this.cb_class.Font = new System.Drawing.Font("돋움", 9F);
			this.cb_class.FormattingEnabled = true;
			this.cb_class.Location = new System.Drawing.Point(130, 165);
			this.cb_class.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.cb_class.Name = "cb_class";
			this.cb_class.Size = new System.Drawing.Size(62, 23);
			this.cb_class.TabIndex = 27;
			this.cb_class.ValueMember = "제목";
			// 
			// cb_number
			// 
			this.cb_number.DisplayMember = "제목";
			this.cb_number.Font = new System.Drawing.Font("돋움", 9F);
			this.cb_number.FormattingEnabled = true;
			this.cb_number.Location = new System.Drawing.Point(226, 165);
			this.cb_number.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.cb_number.Name = "cb_number";
			this.cb_number.Size = new System.Drawing.Size(62, 23);
			this.cb_number.TabIndex = 28;
			this.cb_number.ValueMember = "제목";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(198, 168);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(22, 15);
			this.label1.TabIndex = 29;
			this.label1.Text = "반";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(294, 168);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(37, 15);
			this.label4.TabIndex = 30;
			this.label4.Text = "번호";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(27, 70);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(57, 15);
			this.label5.TabIndex = 31;
			this.label5.Text = "책 제목";
			// 
			// tb_bookTitle
			// 
			this.tb_bookTitle.Location = new System.Drawing.Point(90, 67);
			this.tb_bookTitle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.tb_bookTitle.Name = "tb_bookTitle";
			this.tb_bookTitle.Size = new System.Drawing.Size(198, 25);
			this.tb_bookTitle.TabIndex = 32;
			// 
			// btn_return
			// 
			this.btn_return.BackColor = System.Drawing.Color.Gold;
			this.btn_return.Location = new System.Drawing.Point(236, 266);
			this.btn_return.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.btn_return.Name = "btn_return";
			this.btn_return.Size = new System.Drawing.Size(86, 29);
			this.btn_return.TabIndex = 34;
			this.btn_return.Text = "반납";
			this.btn_return.UseVisualStyleBackColor = false;
			this.btn_return.Click += new System.EventHandler(this.btn_return_Click);
			// 
			// btn_select
			// 
			this.btn_select.BackColor = System.Drawing.Color.Gold;
			this.btn_select.Location = new System.Drawing.Point(134, 266);
			this.btn_select.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.btn_select.Name = "btn_select";
			this.btn_select.Size = new System.Drawing.Size(86, 29);
			this.btn_select.TabIndex = 35;
			this.btn_select.Text = "조회";
			this.btn_select.UseVisualStyleBackColor = false;
			this.btn_select.Click += new System.EventHandler(this.btn_select_Click);
			// 
			// list_loan
			// 
			this.list_loan.FullRowSelect = true;
			this.list_loan.GridLines = true;
			this.list_loan.HideSelection = false;
			this.list_loan.Location = new System.Drawing.Point(337, 13);
			this.list_loan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.list_loan.Name = "list_loan";
			this.list_loan.Size = new System.Drawing.Size(447, 343);
			this.list_loan.TabIndex = 36;
			this.list_loan.UseCompatibleStateImageBehavior = false;
			this.list_loan.View = System.Windows.Forms.View.Details;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(27, 103);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(57, 15);
			this.label6.TabIndex = 37;
			this.label6.Text = "책 저자";
			// 
			// tb_bookAuthor
			// 
			this.tb_bookAuthor.Location = new System.Drawing.Point(90, 100);
			this.tb_bookAuthor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.tb_bookAuthor.Name = "tb_bookAuthor";
			this.tb_bookAuthor.Size = new System.Drawing.Size(198, 25);
			this.tb_bookAuthor.TabIndex = 38;
			// 
			// BorrowForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(796, 369);
			this.Controls.Add(this.tb_bookAuthor);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.list_loan);
			this.Controls.Add(this.btn_select);
			this.Controls.Add(this.btn_return);
			this.Controls.Add(this.tb_bookTitle);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.cb_number);
			this.Controls.Add(this.cb_class);
			this.Controls.Add(this.cb_grade);
			this.Controls.Add(this.btn_borrow);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.tb_bookId);
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "BorrowForm";
			this.Text = "도서 대출";
			this.Load += new System.EventHandler(this.BorrowForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_borrow;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_bookId;
		private System.Windows.Forms.ComboBox cb_grade;
		private System.Windows.Forms.ComboBox cb_class;
		private System.Windows.Forms.ComboBox cb_number;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox tb_bookTitle;
		private System.Windows.Forms.Button btn_return;
		private System.Windows.Forms.Button btn_select;
		private System.Windows.Forms.ListView list_loan;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox tb_bookAuthor;
	}
}