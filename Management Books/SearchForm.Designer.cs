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
            this.list_book = new System.Windows.Forms.ListView();
            this.cb_category = new System.Windows.Forms.ComboBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_search
            // 
            this.tb_search.Location = new System.Drawing.Point(73, 10);
            this.tb_search.Name = "tb_search";
            this.tb_search.Size = new System.Drawing.Size(434, 21);
            this.tb_search.TabIndex = 15;
            this.tb_search.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_search_KeyDown);
            // 
            // list_book
            // 
            this.list_book.GridLines = true;
            this.list_book.HideSelection = false;
            this.list_book.Location = new System.Drawing.Point(12, 39);
            this.list_book.Name = "list_book";
            this.list_book.Size = new System.Drawing.Size(611, 326);
            this.list_book.TabIndex = 14;
            this.list_book.UseCompatibleStateImageBehavior = false;
            this.list_book.View = System.Windows.Forms.View.Details;
            this.list_book.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.list_book_MouseDoubleClick);
            // 
            // cb_category
            // 
            this.cb_category.DisplayMember = "제목";
            this.cb_category.Font = new System.Drawing.Font("돋움", 9F);
            this.cb_category.FormattingEnabled = true;
            this.cb_category.Location = new System.Drawing.Point(12, 11);
            this.cb_category.Name = "cb_category";
            this.cb_category.Size = new System.Drawing.Size(55, 20);
            this.cb_category.TabIndex = 13;
            this.cb_category.ValueMember = "제목";
            // 
            // btn_search
            // 
            this.btn_search.Font = new System.Drawing.Font("돋움", 9F);
            this.btn_search.Location = new System.Drawing.Point(511, 8);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(47, 23);
            this.btn_search.TabIndex = 12;
            this.btn_search.Text = "검색";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.Font = new System.Drawing.Font("돋움", 9F);
            this.btn_reset.Location = new System.Drawing.Point(564, 8);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(61, 23);
            this.btn_reset.TabIndex = 28;
            this.btn_reset.Text = "초기화";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 377);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.tb_search);
            this.Controls.Add(this.list_book);
            this.Controls.Add(this.cb_category);
            this.Controls.Add(this.btn_search);
            this.Name = "SearchForm";
            this.Text = "도서 목록 조회";
            this.Load += new System.EventHandler(this.SearchFoam_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tb_search;
        private System.Windows.Forms.ListView list_book;
        private System.Windows.Forms.ComboBox cb_category;
        private System.Windows.Forms.Button btn_search;
		private System.Windows.Forms.Button btn_reset;
	}
}