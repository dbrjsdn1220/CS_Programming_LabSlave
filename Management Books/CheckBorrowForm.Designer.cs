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
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_number = new System.Windows.Forms.ComboBox();
            this.cb_class = new System.Windows.Forms.ComboBox();
            this.cb_grade = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.list_loan = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // btn_select
            // 
            this.btn_select.BackColor = System.Drawing.Color.Gold;
            this.btn_select.Location = new System.Drawing.Point(28, 114);
            this.btn_select.Name = "btn_select";
            this.btn_select.Size = new System.Drawing.Size(75, 23);
            this.btn_select.TabIndex = 36;
            this.btn_select.Text = "조회";
            this.btn_select.UseVisualStyleBackColor = false;
            this.btn_select.Click += new System.EventHandler(this.btn_select_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 42;
            this.label4.Text = "번호";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 12);
            this.label1.TabIndex = 41;
            this.label1.Text = "반";
            // 
            // cb_number
            // 
            this.cb_number.DisplayMember = "제목";
            this.cb_number.Font = new System.Drawing.Font("돋움", 9F);
            this.cb_number.FormattingEnabled = true;
            this.cb_number.Location = new System.Drawing.Point(53, 74);
            this.cb_number.Name = "cb_number";
            this.cb_number.Size = new System.Drawing.Size(55, 20);
            this.cb_number.TabIndex = 40;
            this.cb_number.ValueMember = "제목";
            // 
            // cb_class
            // 
            this.cb_class.DisplayMember = "제목";
            this.cb_class.Font = new System.Drawing.Font("돋움", 9F);
            this.cb_class.FormattingEnabled = true;
            this.cb_class.Location = new System.Drawing.Point(53, 48);
            this.cb_class.Name = "cb_class";
            this.cb_class.Size = new System.Drawing.Size(55, 20);
            this.cb_class.TabIndex = 39;
            this.cb_class.ValueMember = "제목";
            // 
            // cb_grade
            // 
            this.cb_grade.DisplayMember = "제목";
            this.cb_grade.Font = new System.Drawing.Font("돋움", 9F);
            this.cb_grade.FormattingEnabled = true;
            this.cb_grade.Location = new System.Drawing.Point(53, 22);
            this.cb_grade.Name = "cb_grade";
            this.cb_grade.Size = new System.Drawing.Size(55, 20);
            this.cb_grade.TabIndex = 38;
            this.cb_grade.ValueMember = "제목";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 37;
            this.label3.Text = "학년";
            // 
            // list_loan
            // 
            this.list_loan.FullRowSelect = true;
            this.list_loan.GridLines = true;
            this.list_loan.HideSelection = false;
            this.list_loan.Location = new System.Drawing.Point(133, 12);
            this.list_loan.Name = "list_loan";
            this.list_loan.Size = new System.Drawing.Size(524, 139);
            this.list_loan.TabIndex = 43;
            this.list_loan.UseCompatibleStateImageBehavior = false;
            this.list_loan.View = System.Windows.Forms.View.Details;
            // 
            // CheckBorrowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 163);
            this.Controls.Add(this.list_loan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_number);
            this.Controls.Add(this.cb_class);
            this.Controls.Add(this.cb_grade);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_select);
            this.Name = "CheckBorrowForm";
            this.Text = "도서대출 기록 조회";
            this.Load += new System.EventHandler(this.CheckBorrowForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_select;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_number;
        private System.Windows.Forms.ComboBox cb_class;
        private System.Windows.Forms.ComboBox cb_grade;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView list_loan;
    }
}