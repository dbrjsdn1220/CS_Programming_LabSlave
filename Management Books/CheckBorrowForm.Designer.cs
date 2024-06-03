namespace Management_Books
{
    partial class CheckBorrowForm
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
			this.btn_select = new System.Windows.Forms.Button();
			this.lb_number = new System.Windows.Forms.Label();
			this.lb_class = new System.Windows.Forms.Label();
			this.cb_number = new System.Windows.Forms.ComboBox();
			this.cb_class = new System.Windows.Forms.ComboBox();
			this.cb_grade = new System.Windows.Forms.ComboBox();
			this.lb_grade = new System.Windows.Forms.Label();
			this.list_loan = new System.Windows.Forms.ListView();
			this.lb_title = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btn_select
			// 
			this.btn_select.BackColor = System.Drawing.Color.Gold;
			this.btn_select.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.btn_select.Location = new System.Drawing.Point(12, 202);
			this.btn_select.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.btn_select.Name = "btn_select";
			this.btn_select.Size = new System.Drawing.Size(150, 85);
			this.btn_select.TabIndex = 36;
			this.btn_select.Text = "대출 조회";
			this.btn_select.UseVisualStyleBackColor = false;
			this.btn_select.Click += new System.EventHandler(this.btn_select_Click);
			// 
			// lb_number
			// 
			this.lb_number.AutoSize = true;
			this.lb_number.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.lb_number.Location = new System.Drawing.Point(21, 163);
			this.lb_number.Name = "lb_number";
			this.lb_number.Size = new System.Drawing.Size(48, 23);
			this.lb_number.TabIndex = 42;
			this.lb_number.Text = "번호";
			// 
			// lb_class
			// 
			this.lb_class.AutoSize = true;
			this.lb_class.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.lb_class.Location = new System.Drawing.Point(30, 124);
			this.lb_class.Name = "lb_class";
			this.lb_class.Size = new System.Drawing.Size(29, 23);
			this.lb_class.TabIndex = 41;
			this.lb_class.Text = "반";
			// 
			// cb_number
			// 
			this.cb_number.DisplayMember = "제목";
			this.cb_number.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.cb_number.FormattingEnabled = true;
			this.cb_number.Location = new System.Drawing.Point(77, 160);
			this.cb_number.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.cb_number.Name = "cb_number";
			this.cb_number.Size = new System.Drawing.Size(85, 31);
			this.cb_number.TabIndex = 40;
			this.cb_number.ValueMember = "제목";
			// 
			// cb_class
			// 
			this.cb_class.DisplayMember = "제목";
			this.cb_class.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.cb_class.FormattingEnabled = true;
			this.cb_class.Location = new System.Drawing.Point(77, 121);
			this.cb_class.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.cb_class.Name = "cb_class";
			this.cb_class.Size = new System.Drawing.Size(85, 31);
			this.cb_class.TabIndex = 39;
			this.cb_class.ValueMember = "제목";
			// 
			// cb_grade
			// 
			this.cb_grade.DisplayMember = "제목";
			this.cb_grade.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.cb_grade.FormattingEnabled = true;
			this.cb_grade.Location = new System.Drawing.Point(77, 82);
			this.cb_grade.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.cb_grade.Name = "cb_grade";
			this.cb_grade.Size = new System.Drawing.Size(85, 31);
			this.cb_grade.TabIndex = 38;
			this.cb_grade.ValueMember = "제목";
			// 
			// lb_grade
			// 
			this.lb_grade.AutoSize = true;
			this.lb_grade.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.lb_grade.Location = new System.Drawing.Point(21, 85);
			this.lb_grade.Name = "lb_grade";
			this.lb_grade.Size = new System.Drawing.Size(48, 23);
			this.lb_grade.TabIndex = 37;
			this.lb_grade.Text = "학년";
			// 
			// list_loan
			// 
			this.list_loan.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.list_loan.FullRowSelect = true;
			this.list_loan.GridLines = true;
			this.list_loan.HideSelection = false;
			this.list_loan.Location = new System.Drawing.Point(175, 82);
			this.list_loan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.list_loan.Name = "list_loan";
			this.list_loan.Size = new System.Drawing.Size(613, 205);
			this.list_loan.TabIndex = 43;
			this.list_loan.UseCompatibleStateImageBehavior = false;
			this.list_loan.View = System.Windows.Forms.View.Details;
			// 
			// lb_title
			// 
			this.lb_title.AutoSize = true;
			this.lb_title.Font = new System.Drawing.Font("나눔바른고딕", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.lb_title.Location = new System.Drawing.Point(4, 9);
			this.lb_title.Name = "lb_title";
			this.lb_title.Size = new System.Drawing.Size(374, 58);
			this.lb_title.TabIndex = 44;
			this.lb_title.Text = "대출 조회 페이지";
			// 
			// CheckBorrowForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 300);
			this.Controls.Add(this.lb_title);
			this.Controls.Add(this.list_loan);
			this.Controls.Add(this.lb_number);
			this.Controls.Add(this.lb_class);
			this.Controls.Add(this.cb_number);
			this.Controls.Add(this.cb_class);
			this.Controls.Add(this.cb_grade);
			this.Controls.Add(this.lb_grade);
			this.Controls.Add(this.btn_select);
			this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
			this.Name = "CheckBorrowForm";
			this.Text = "도서대출 기록 조회";
			this.Load += new System.EventHandler(this.CheckBorrowForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_select;
        private System.Windows.Forms.Label lb_number;
        private System.Windows.Forms.Label lb_class;
        private System.Windows.Forms.ComboBox cb_number;
        private System.Windows.Forms.ComboBox cb_class;
        private System.Windows.Forms.ComboBox cb_grade;
        private System.Windows.Forms.Label lb_grade;
        private System.Windows.Forms.ListView list_loan;
		private System.Windows.Forms.Label lb_title;
	}
}