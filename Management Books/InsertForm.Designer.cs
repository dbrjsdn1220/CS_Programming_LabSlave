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
			this.lb_bookTitle = new System.Windows.Forms.Label();
			this.tb_bookTitle = new System.Windows.Forms.TextBox();
			this.tb_bookAuthor = new System.Windows.Forms.TextBox();
			this.lb_bookAuthor = new System.Windows.Forms.Label();
			this.lb_bookCount = new System.Windows.Forms.Label();
			this.lb_bookCategory = new System.Windows.Forms.Label();
			this.cb_bookCategory = new System.Windows.Forms.ComboBox();
			this.btn_insertBook = new System.Windows.Forms.Button();
			this.btn_reset = new System.Windows.Forms.Button();
			this.tb_bookCount = new System.Windows.Forms.NumericUpDown();
			this.lb_title = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.tb_bookCount)).BeginInit();
			this.SuspendLayout();
			// 
			// lb_bookTitle
			// 
			this.lb_bookTitle.AutoSize = true;
			this.lb_bookTitle.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.lb_bookTitle.Location = new System.Drawing.Point(44, 132);
			this.lb_bookTitle.Name = "lb_bookTitle";
			this.lb_bookTitle.Size = new System.Drawing.Size(48, 23);
			this.lb_bookTitle.TabIndex = 0;
			this.lb_bookTitle.Text = "제목";
			// 
			// tb_bookTitle
			// 
			this.tb_bookTitle.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.tb_bookTitle.Location = new System.Drawing.Point(124, 129);
			this.tb_bookTitle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.tb_bookTitle.Name = "tb_bookTitle";
			this.tb_bookTitle.Size = new System.Drawing.Size(180, 30);
			this.tb_bookTitle.TabIndex = 1;
			// 
			// tb_bookAuthor
			// 
			this.tb_bookAuthor.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.tb_bookAuthor.Location = new System.Drawing.Point(124, 182);
			this.tb_bookAuthor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.tb_bookAuthor.Name = "tb_bookAuthor";
			this.tb_bookAuthor.Size = new System.Drawing.Size(180, 30);
			this.tb_bookAuthor.TabIndex = 19;
			// 
			// lb_bookAuthor
			// 
			this.lb_bookAuthor.AutoSize = true;
			this.lb_bookAuthor.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.lb_bookAuthor.Location = new System.Drawing.Point(44, 185);
			this.lb_bookAuthor.Name = "lb_bookAuthor";
			this.lb_bookAuthor.Size = new System.Drawing.Size(48, 23);
			this.lb_bookAuthor.TabIndex = 18;
			this.lb_bookAuthor.Text = "저자";
			// 
			// lb_bookCount
			// 
			this.lb_bookCount.AutoSize = true;
			this.lb_bookCount.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.lb_bookCount.Location = new System.Drawing.Point(44, 232);
			this.lb_bookCount.Name = "lb_bookCount";
			this.lb_bookCount.Size = new System.Drawing.Size(48, 23);
			this.lb_bookCount.TabIndex = 20;
			this.lb_bookCount.Text = "권수";
			// 
			// lb_bookCategory
			// 
			this.lb_bookCategory.AutoSize = true;
			this.lb_bookCategory.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.lb_bookCategory.Location = new System.Drawing.Point(44, 83);
			this.lb_bookCategory.Name = "lb_bookCategory";
			this.lb_bookCategory.Size = new System.Drawing.Size(48, 23);
			this.lb_bookCategory.TabIndex = 22;
			this.lb_bookCategory.Text = "분류";
			// 
			// cb_bookCategory
			// 
			this.cb_bookCategory.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.cb_bookCategory.FormattingEnabled = true;
			this.cb_bookCategory.Location = new System.Drawing.Point(124, 80);
			this.cb_bookCategory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.cb_bookCategory.Name = "cb_bookCategory";
			this.cb_bookCategory.Size = new System.Drawing.Size(180, 31);
			this.cb_bookCategory.TabIndex = 23;
			// 
			// btn_insertBook
			// 
			this.btn_insertBook.BackColor = System.Drawing.Color.Gold;
			this.btn_insertBook.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.btn_insertBook.Location = new System.Drawing.Point(189, 294);
			this.btn_insertBook.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.btn_insertBook.Name = "btn_insertBook";
			this.btn_insertBook.Size = new System.Drawing.Size(105, 35);
			this.btn_insertBook.TabIndex = 24;
			this.btn_insertBook.Text = "추가";
			this.btn_insertBook.UseVisualStyleBackColor = false;
			this.btn_insertBook.Click += new System.EventHandler(this.btn_insert_Click);
			// 
			// btn_reset
			// 
			this.btn_reset.BackColor = System.Drawing.Color.LightGray;
			this.btn_reset.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.btn_reset.Location = new System.Drawing.Point(63, 294);
			this.btn_reset.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.btn_reset.Name = "btn_reset";
			this.btn_reset.Size = new System.Drawing.Size(105, 35);
			this.btn_reset.TabIndex = 25;
			this.btn_reset.Text = "초기화";
			this.btn_reset.UseVisualStyleBackColor = false;
			this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
			// 
			// tb_bookCount
			// 
			this.tb_bookCount.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.tb_bookCount.Location = new System.Drawing.Point(124, 230);
			this.tb_bookCount.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.tb_bookCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.tb_bookCount.Name = "tb_bookCount";
			this.tb_bookCount.Size = new System.Drawing.Size(180, 30);
			this.tb_bookCount.TabIndex = 26;
			this.tb_bookCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// lb_title
			// 
			this.lb_title.Dock = System.Windows.Forms.DockStyle.Top;
			this.lb_title.Font = new System.Drawing.Font("나눔바른고딕", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.lb_title.Location = new System.Drawing.Point(0, 0);
			this.lb_title.Name = "lb_title";
			this.lb_title.Size = new System.Drawing.Size(355, 48);
			this.lb_title.TabIndex = 27;
			this.lb_title.Text = "도서 정보 추가";
			this.lb_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// InsertForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(355, 351);
			this.Controls.Add(this.lb_title);
			this.Controls.Add(this.tb_bookCount);
			this.Controls.Add(this.btn_reset);
			this.Controls.Add(this.btn_insertBook);
			this.Controls.Add(this.cb_bookCategory);
			this.Controls.Add(this.lb_bookCategory);
			this.Controls.Add(this.lb_bookCount);
			this.Controls.Add(this.tb_bookAuthor);
			this.Controls.Add(this.lb_bookAuthor);
			this.Controls.Add(this.tb_bookTitle);
			this.Controls.Add(this.lb_bookTitle);
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "InsertForm";
			this.Text = "도서 정보 추가";
			this.Load += new System.EventHandler(this.InsertForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.tb_bookCount)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_bookTitle;
        private System.Windows.Forms.TextBox tb_bookTitle;
        private System.Windows.Forms.TextBox tb_bookAuthor;
        private System.Windows.Forms.Label lb_bookAuthor;
        private System.Windows.Forms.Label lb_bookCount;
        private System.Windows.Forms.Label lb_bookCategory;
        private System.Windows.Forms.ComboBox cb_bookCategory;
        private System.Windows.Forms.Button btn_insertBook;
        private System.Windows.Forms.Button btn_reset;
		private System.Windows.Forms.NumericUpDown tb_bookCount;
		private System.Windows.Forms.Label lb_title;
	}
}