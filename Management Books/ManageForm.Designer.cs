namespace Management_Books
{
    partial class ManageForm
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
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_insert = new System.Windows.Forms.Button();
            this.cb_category = new System.Windows.Forms.ComboBox();
            this.label_name = new System.Windows.Forms.Label();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_check_borrow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_search
            // 
            this.tb_search.Location = new System.Drawing.Point(73, 40);
            this.tb_search.Name = "tb_search";
            this.tb_search.Size = new System.Drawing.Size(444, 21);
            this.tb_search.TabIndex = 20;
            this.tb_search.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_search_KeyDown);
            // 
            // list_book
            // 
            this.list_book.FullRowSelect = true;
            this.list_book.GridLines = true;
            this.list_book.HideSelection = false;
            this.list_book.Location = new System.Drawing.Point(12, 67);
            this.list_book.Name = "list_book";
            this.list_book.Size = new System.Drawing.Size(611, 326);
            this.list_book.TabIndex = 19;
            this.list_book.UseCompatibleStateImageBehavior = false;
            this.list_book.View = System.Windows.Forms.View.Details;
            this.list_book.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.list_book_MouseDoubleClick);
            // 
            // btn_search
            // 
            this.btn_search.Font = new System.Drawing.Font("돋움", 9F);
            this.btn_search.Location = new System.Drawing.Point(523, 39);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(47, 23);
            this.btn_search.TabIndex = 17;
            this.btn_search.Text = "검색";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_insert
            // 
            this.btn_insert.Font = new System.Drawing.Font("돋움", 9F);
            this.btn_insert.Location = new System.Drawing.Point(576, 39);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(47, 23);
            this.btn_insert.TabIndex = 21;
            this.btn_insert.Text = "추가";
            this.btn_insert.UseVisualStyleBackColor = true;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // cb_category
            // 
            this.cb_category.DisplayMember = "제목";
            this.cb_category.Font = new System.Drawing.Font("돋움", 9F);
            this.cb_category.FormattingEnabled = true;
            this.cb_category.Location = new System.Drawing.Point(12, 41);
            this.cb_category.Name = "cb_category";
            this.cb_category.Size = new System.Drawing.Size(55, 20);
            this.cb_category.TabIndex = 25;
            this.cb_category.ValueMember = "제목";
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(10, 9);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(29, 12);
            this.label_name.TabIndex = 26;
            this.label_name.Text = "이름";
            // 
            // btn_reset
            // 
            this.btn_reset.Font = new System.Drawing.Font("돋움", 9F);
            this.btn_reset.Location = new System.Drawing.Point(523, 9);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(100, 23);
            this.btn_reset.TabIndex = 27;
            this.btn_reset.Text = "초기화";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // btn_check_borrow
            // 
            this.btn_check_borrow.Font = new System.Drawing.Font("돋움", 9F);
            this.btn_check_borrow.Location = new System.Drawing.Point(417, 9);
            this.btn_check_borrow.Name = "btn_check_borrow";
            this.btn_check_borrow.Size = new System.Drawing.Size(100, 23);
            this.btn_check_borrow.TabIndex = 28;
            this.btn_check_borrow.Text = "대출 조회";
            this.btn_check_borrow.UseVisualStyleBackColor = true;
            this.btn_check_borrow.Click += new System.EventHandler(this.btn_check_borrow_Click);
            // 
            // ManageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 404);
            this.Controls.Add(this.btn_check_borrow);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.cb_category);
            this.Controls.Add(this.btn_insert);
            this.Controls.Add(this.tb_search);
            this.Controls.Add(this.list_book);
            this.Controls.Add(this.btn_search);
            this.Name = "ManageForm";
            this.Text = "도서 관리 프로그램";
            this.Load += new System.EventHandler(this.ManageFoam_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_search;
        private System.Windows.Forms.ListView list_book;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.ComboBox cb_category;
        private System.Windows.Forms.Label label_name;
		private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_check_borrow;
    }
}