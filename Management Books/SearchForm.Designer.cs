namespace Management_Books
{
    partial class SearchForm
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
			this.tb_search = new System.Windows.Forms.TextBox();
			this.cb_bookCategory = new System.Windows.Forms.ComboBox();
			this.btn_search = new System.Windows.Forms.Button();
			this.btn_reset = new System.Windows.Forms.Button();
			this.list_book = new System.Windows.Forms.ListView();
			this.lb_title = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// tb_search
			// 
			this.tb_search.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.tb_search.Location = new System.Drawing.Point(119, 125);
			this.tb_search.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.tb_search.Name = "tb_search";
			this.tb_search.Size = new System.Drawing.Size(563, 30);
			this.tb_search.TabIndex = 2;
			this.tb_search.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_search_KeyDown);
			// 
			// cb_bookCategory
			// 
			this.cb_bookCategory.DisplayMember = "제목";
			this.cb_bookCategory.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.cb_bookCategory.FormattingEnabled = true;
			this.cb_bookCategory.Location = new System.Drawing.Point(12, 124);
			this.cb_bookCategory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.cb_bookCategory.Name = "cb_bookCategory";
			this.cb_bookCategory.Size = new System.Drawing.Size(101, 31);
			this.cb_bookCategory.TabIndex = 1;
			this.cb_bookCategory.ValueMember = "제목";
			// 
			// btn_search
			// 
			this.btn_search.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.btn_search.Location = new System.Drawing.Point(688, 120);
			this.btn_search.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.btn_search.Name = "btn_search";
			this.btn_search.Size = new System.Drawing.Size(150, 38);
			this.btn_search.TabIndex = 3;
			this.btn_search.Text = "도서 검색";
			this.btn_search.UseVisualStyleBackColor = true;
			this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
			// 
			// btn_reset
			// 
			this.btn_reset.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.btn_reset.Location = new System.Drawing.Point(688, 74);
			this.btn_reset.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.btn_reset.Name = "btn_reset";
			this.btn_reset.Size = new System.Drawing.Size(150, 38);
			this.btn_reset.TabIndex = 4;
			this.btn_reset.Text = "검색 초기화";
			this.btn_reset.UseVisualStyleBackColor = true;
			this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
			// 
			// list_book
			// 
			this.list_book.Font = new System.Drawing.Font("나눔바른고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.list_book.FullRowSelect = true;
			this.list_book.GridLines = true;
			this.list_book.HideSelection = false;
			this.list_book.Location = new System.Drawing.Point(12, 166);
			this.list_book.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.list_book.Name = "list_book";
			this.list_book.Size = new System.Drawing.Size(826, 406);
			this.list_book.TabIndex = 29;
			this.list_book.UseCompatibleStateImageBehavior = false;
			this.list_book.View = System.Windows.Forms.View.Details;
			this.list_book.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.list_book_MouseDoubleClick);
			// 
			// lb_title
			// 
			this.lb_title.AutoSize = true;
			this.lb_title.Cursor = System.Windows.Forms.Cursors.Default;
			this.lb_title.Font = new System.Drawing.Font("나눔바른고딕", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.lb_title.Location = new System.Drawing.Point(4, 9);
			this.lb_title.Name = "lb_title";
			this.lb_title.Size = new System.Drawing.Size(299, 46);
			this.lb_title.TabIndex = 30;
			this.lb_title.Text = "도서 검색 페이지";
			// 
			// SearchForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(850, 585);
			this.Controls.Add(this.lb_title);
			this.Controls.Add(this.list_book);
			this.Controls.Add(this.btn_reset);
			this.Controls.Add(this.tb_search);
			this.Controls.Add(this.cb_bookCategory);
			this.Controls.Add(this.btn_search);
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "SearchForm";
			this.Text = "도서 목록 조회";
			this.Load += new System.EventHandler(this.SearchFoam_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tb_search;
        private System.Windows.Forms.ComboBox cb_bookCategory;
        private System.Windows.Forms.Button btn_search;
		private System.Windows.Forms.Button btn_reset;
		private System.Windows.Forms.ListView list_book;
		private System.Windows.Forms.Label lb_title;
	}
}