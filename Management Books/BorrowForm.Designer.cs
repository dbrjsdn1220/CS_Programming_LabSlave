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
			this.lb_grade = new System.Windows.Forms.Label();
			this.lb_bookId = new System.Windows.Forms.Label();
			this.tb_bookId = new System.Windows.Forms.TextBox();
			this.cb_grade = new System.Windows.Forms.ComboBox();
			this.cb_class = new System.Windows.Forms.ComboBox();
			this.cb_number = new System.Windows.Forms.ComboBox();
			this.lb_class = new System.Windows.Forms.Label();
			this.lb_number = new System.Windows.Forms.Label();
			this.lb_bookTitle = new System.Windows.Forms.Label();
			this.tb_bookTitle = new System.Windows.Forms.TextBox();
			this.btn_return = new System.Windows.Forms.Button();
			this.list_loan = new System.Windows.Forms.ListView();
			this.lb_bookAuthor = new System.Windows.Forms.Label();
			this.tb_bookAuthor = new System.Windows.Forms.TextBox();
			this.lb_title = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btn_borrow
			// 
			this.btn_borrow.BackColor = System.Drawing.Color.Gold;
			this.btn_borrow.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.btn_borrow.Location = new System.Drawing.Point(12, 259);
			this.btn_borrow.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.btn_borrow.Name = "btn_borrow";
			this.btn_borrow.Size = new System.Drawing.Size(150, 35);
			this.btn_borrow.TabIndex = 15;
			this.btn_borrow.Text = "도서 대출";
			this.btn_borrow.UseVisualStyleBackColor = false;
			this.btn_borrow.Click += new System.EventHandler(this.btn_borrow_Click);
			// 
			// lb_grade
			// 
			this.lb_grade.AutoSize = true;
			this.lb_grade.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.lb_grade.Location = new System.Drawing.Point(20, 143);
			this.lb_grade.Name = "lb_grade";
			this.lb_grade.Size = new System.Drawing.Size(48, 23);
			this.lb_grade.TabIndex = 13;
			this.lb_grade.Text = "학년";
			// 
			// lb_bookId
			// 
			this.lb_bookId.AutoSize = true;
			this.lb_bookId.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.lb_bookId.Location = new System.Drawing.Point(511, 16);
			this.lb_bookId.Name = "lb_bookId";
			this.lb_bookId.Size = new System.Drawing.Size(74, 23);
			this.lb_bookId.TabIndex = 12;
			this.lb_bookId.Text = "도서 ID";
			// 
			// tb_bookId
			// 
			this.tb_bookId.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.tb_bookId.Location = new System.Drawing.Point(608, 13);
			this.tb_bookId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.tb_bookId.Name = "tb_bookId";
			this.tb_bookId.ReadOnly = true;
			this.tb_bookId.Size = new System.Drawing.Size(180, 30);
			this.tb_bookId.TabIndex = 11;
			// 
			// cb_grade
			// 
			this.cb_grade.DisplayMember = "제목";
			this.cb_grade.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.cb_grade.FormattingEnabled = true;
			this.cb_grade.Location = new System.Drawing.Point(74, 140);
			this.cb_grade.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.cb_grade.Name = "cb_grade";
			this.cb_grade.Size = new System.Drawing.Size(85, 31);
			this.cb_grade.TabIndex = 26;
			this.cb_grade.ValueMember = "제목";
			// 
			// cb_class
			// 
			this.cb_class.DisplayMember = "제목";
			this.cb_class.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.cb_class.FormattingEnabled = true;
			this.cb_class.Location = new System.Drawing.Point(74, 179);
			this.cb_class.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.cb_class.Name = "cb_class";
			this.cb_class.Size = new System.Drawing.Size(85, 31);
			this.cb_class.TabIndex = 27;
			this.cb_class.ValueMember = "제목";
			// 
			// cb_number
			// 
			this.cb_number.DisplayMember = "제목";
			this.cb_number.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.cb_number.FormattingEnabled = true;
			this.cb_number.Location = new System.Drawing.Point(74, 218);
			this.cb_number.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.cb_number.Name = "cb_number";
			this.cb_number.Size = new System.Drawing.Size(85, 31);
			this.cb_number.TabIndex = 28;
			this.cb_number.ValueMember = "제목";
			// 
			// lb_class
			// 
			this.lb_class.AutoSize = true;
			this.lb_class.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.lb_class.Location = new System.Drawing.Point(29, 182);
			this.lb_class.Name = "lb_class";
			this.lb_class.Size = new System.Drawing.Size(29, 23);
			this.lb_class.TabIndex = 29;
			this.lb_class.Text = "반";
			// 
			// lb_number
			// 
			this.lb_number.AutoSize = true;
			this.lb_number.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.lb_number.Location = new System.Drawing.Point(20, 221);
			this.lb_number.Name = "lb_number";
			this.lb_number.Size = new System.Drawing.Size(48, 23);
			this.lb_number.TabIndex = 30;
			this.lb_number.Text = "번호";
			// 
			// lb_bookTitle
			// 
			this.lb_bookTitle.AutoSize = true;
			this.lb_bookTitle.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.lb_bookTitle.Location = new System.Drawing.Point(504, 54);
			this.lb_bookTitle.Name = "lb_bookTitle";
			this.lb_bookTitle.Size = new System.Drawing.Size(91, 23);
			this.lb_bookTitle.TabIndex = 31;
			this.lb_bookTitle.Text = "도서 제목";
			// 
			// tb_bookTitle
			// 
			this.tb_bookTitle.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.tb_bookTitle.Location = new System.Drawing.Point(608, 51);
			this.tb_bookTitle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.tb_bookTitle.Name = "tb_bookTitle";
			this.tb_bookTitle.ReadOnly = true;
			this.tb_bookTitle.Size = new System.Drawing.Size(180, 30);
			this.tb_bookTitle.TabIndex = 32;
			// 
			// btn_return
			// 
			this.btn_return.BackColor = System.Drawing.Color.Gold;
			this.btn_return.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.btn_return.Location = new System.Drawing.Point(12, 302);
			this.btn_return.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.btn_return.Name = "btn_return";
			this.btn_return.Size = new System.Drawing.Size(150, 35);
			this.btn_return.TabIndex = 34;
			this.btn_return.Text = "도서 반납";
			this.btn_return.UseVisualStyleBackColor = false;
			this.btn_return.Click += new System.EventHandler(this.btn_return_Click);
			// 
			// list_loan
			// 
			this.list_loan.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.list_loan.FullRowSelect = true;
			this.list_loan.GridLines = true;
			this.list_loan.HideSelection = false;
			this.list_loan.Location = new System.Drawing.Point(175, 132);
			this.list_loan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.list_loan.Name = "list_loan";
			this.list_loan.Size = new System.Drawing.Size(613, 205);
			this.list_loan.TabIndex = 36;
			this.list_loan.UseCompatibleStateImageBehavior = false;
			this.list_loan.View = System.Windows.Forms.View.Details;
			// 
			// lb_bookAuthor
			// 
			this.lb_bookAuthor.AutoSize = true;
			this.lb_bookAuthor.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.lb_bookAuthor.Location = new System.Drawing.Point(504, 92);
			this.lb_bookAuthor.Name = "lb_bookAuthor";
			this.lb_bookAuthor.Size = new System.Drawing.Size(91, 23);
			this.lb_bookAuthor.TabIndex = 37;
			this.lb_bookAuthor.Text = "도서 저자";
			// 
			// tb_bookAuthor
			// 
			this.tb_bookAuthor.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.tb_bookAuthor.Location = new System.Drawing.Point(608, 89);
			this.tb_bookAuthor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.tb_bookAuthor.Name = "tb_bookAuthor";
			this.tb_bookAuthor.ReadOnly = true;
			this.tb_bookAuthor.Size = new System.Drawing.Size(180, 30);
			this.tb_bookAuthor.TabIndex = 38;
			// 
			// lb_title
			// 
			this.lb_title.AutoSize = true;
			this.lb_title.Font = new System.Drawing.Font("나눔바른고딕", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.lb_title.Location = new System.Drawing.Point(4, 9);
			this.lb_title.Name = "lb_title";
			this.lb_title.Size = new System.Drawing.Size(430, 46);
			this.lb_title.TabIndex = 39;
			this.lb_title.Text = "도서 (대출/반납) 페이지";
			// 
			// BorrowForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 350);
			this.Controls.Add(this.lb_title);
			this.Controls.Add(this.tb_bookAuthor);
			this.Controls.Add(this.lb_bookAuthor);
			this.Controls.Add(this.list_loan);
			this.Controls.Add(this.btn_return);
			this.Controls.Add(this.tb_bookTitle);
			this.Controls.Add(this.lb_bookTitle);
			this.Controls.Add(this.lb_number);
			this.Controls.Add(this.lb_class);
			this.Controls.Add(this.cb_number);
			this.Controls.Add(this.cb_class);
			this.Controls.Add(this.cb_grade);
			this.Controls.Add(this.btn_borrow);
			this.Controls.Add(this.lb_grade);
			this.Controls.Add(this.lb_bookId);
			this.Controls.Add(this.tb_bookId);
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "BorrowForm";
			this.Text = "도서 (대출/반납)";
			this.Load += new System.EventHandler(this.BorrowForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_borrow;
        private System.Windows.Forms.Label lb_grade;
        private System.Windows.Forms.Label lb_bookId;
        private System.Windows.Forms.TextBox tb_bookId;
		private System.Windows.Forms.ComboBox cb_grade;
		private System.Windows.Forms.ComboBox cb_class;
		private System.Windows.Forms.ComboBox cb_number;
		private System.Windows.Forms.Label lb_class;
		private System.Windows.Forms.Label lb_number;
		private System.Windows.Forms.Label lb_bookTitle;
		private System.Windows.Forms.TextBox tb_bookTitle;
		private System.Windows.Forms.Button btn_return;
		private System.Windows.Forms.ListView list_loan;
		private System.Windows.Forms.Label lb_bookAuthor;
		private System.Windows.Forms.TextBox tb_bookAuthor;
		private System.Windows.Forms.Label lb_title;
	}
}