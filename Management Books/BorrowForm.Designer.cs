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
            this.tb_user = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_book = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_borrow
            // 
            this.btn_borrow.BackColor = System.Drawing.Color.Gold;
            this.btn_borrow.Location = new System.Drawing.Point(184, 90);
            this.btn_borrow.Name = "btn_borrow";
            this.btn_borrow.Size = new System.Drawing.Size(75, 23);
            this.btn_borrow.TabIndex = 15;
            this.btn_borrow.Text = "대출";
            this.btn_borrow.UseVisualStyleBackColor = false;
            // 
            // tb_user
            // 
            this.tb_user.Location = new System.Drawing.Point(91, 54);
            this.tb_user.Name = "tb_user";
            this.tb_user.Size = new System.Drawing.Size(168, 21);
            this.tb_user.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 12);
            this.label3.TabIndex = 13;
            this.label3.Text = "사용자 ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 12);
            this.label2.TabIndex = 12;
            this.label2.Text = "책 ID";
            // 
            // tb_book
            // 
            this.tb_book.Location = new System.Drawing.Point(91, 27);
            this.tb_book.Name = "tb_book";
            this.tb_book.Size = new System.Drawing.Size(168, 21);
            this.tb_book.TabIndex = 11;
            // 
            // BorrowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 129);
            this.Controls.Add(this.btn_borrow);
            this.Controls.Add(this.tb_user);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_book);
            this.Name = "BorrowForm";
            this.Text = "도서 대출";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_borrow;
        private System.Windows.Forms.TextBox tb_user;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_book;
    }
}