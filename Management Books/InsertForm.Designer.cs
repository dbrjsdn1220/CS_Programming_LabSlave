namespace Management_Books
{
    partial class InsertForm
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
			this.label1 = new System.Windows.Forms.Label();
			this.tb_title = new System.Windows.Forms.TextBox();
			this.tb_author = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.tb_bookCount = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.cb_category = new System.Windows.Forms.ComboBox();
			this.btn_insert = new System.Windows.Forms.Button();
			this.btn_reset = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(37, 68);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(37, 15);
			this.label1.TabIndex = 0;
			this.label1.Text = "제목";
			// 
			// tb_title
			// 
			this.tb_title.Location = new System.Drawing.Point(77, 62);
			this.tb_title.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.tb_title.Name = "tb_title";
			this.tb_title.Size = new System.Drawing.Size(138, 25);
			this.tb_title.TabIndex = 1;
			// 
			// tb_author
			// 
			this.tb_author.Location = new System.Drawing.Point(77, 95);
			this.tb_author.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.tb_author.Name = "tb_author";
			this.tb_author.Size = new System.Drawing.Size(138, 25);
			this.tb_author.TabIndex = 19;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(37, 99);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(37, 15);
			this.label3.TabIndex = 18;
			this.label3.Text = "저자";
			// 
			// tb_bookCount
			// 
			this.tb_bookCount.Location = new System.Drawing.Point(77, 128);
			this.tb_bookCount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.tb_bookCount.Name = "tb_bookCount";
			this.tb_bookCount.Size = new System.Drawing.Size(138, 25);
			this.tb_bookCount.TabIndex = 21;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(37, 133);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(37, 15);
			this.label4.TabIndex = 20;
			this.label4.Text = "권수";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(37, 34);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(37, 15);
			this.label5.TabIndex = 22;
			this.label5.Text = "분류";
			// 
			// cb_category
			// 
			this.cb_category.FormattingEnabled = true;
			this.cb_category.Location = new System.Drawing.Point(77, 30);
			this.cb_category.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.cb_category.Name = "cb_category";
			this.cb_category.Size = new System.Drawing.Size(138, 23);
			this.cb_category.TabIndex = 23;
			// 
			// btn_insert
			// 
			this.btn_insert.BackColor = System.Drawing.Color.Gold;
			this.btn_insert.Location = new System.Drawing.Point(135, 172);
			this.btn_insert.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.btn_insert.Name = "btn_insert";
			this.btn_insert.Size = new System.Drawing.Size(80, 29);
			this.btn_insert.TabIndex = 24;
			this.btn_insert.Text = "추가";
			this.btn_insert.UseVisualStyleBackColor = false;
			this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
			// 
			// btn_reset
			// 
			this.btn_reset.BackColor = System.Drawing.Color.LightGray;
			this.btn_reset.Location = new System.Drawing.Point(39, 172);
			this.btn_reset.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.btn_reset.Name = "btn_reset";
			this.btn_reset.Size = new System.Drawing.Size(80, 29);
			this.btn_reset.TabIndex = 25;
			this.btn_reset.Text = "초기화";
			this.btn_reset.UseVisualStyleBackColor = false;
			this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
			// 
			// InsertForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(257, 224);
			this.Controls.Add(this.btn_reset);
			this.Controls.Add(this.btn_insert);
			this.Controls.Add(this.cb_category);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.tb_bookCount);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.tb_author);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.tb_title);
			this.Controls.Add(this.label1);
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "InsertForm";
			this.Text = "도서 추가";
			this.Load += new System.EventHandler(this.InsertForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_title;
        private System.Windows.Forms.TextBox tb_author;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_bookCount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cb_category;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.Button btn_reset;
    }
}