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
			this.SuspendLayout();
			// 
			// tb_search
			// 
			this.tb_search.Location = new System.Drawing.Point(83, 39);
			this.tb_search.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.tb_search.Name = "tb_search";
			this.tb_search.Size = new System.Drawing.Size(507, 25);
			this.tb_search.TabIndex = 20;
			// 
			// list_book
			// 
			this.list_book.FullRowSelect = true;
			this.list_book.GridLines = true;
			this.list_book.HideSelection = false;
			this.list_book.Location = new System.Drawing.Point(14, 75);
			this.list_book.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.list_book.Name = "list_book";
			this.list_book.Size = new System.Drawing.Size(698, 406);
			this.list_book.TabIndex = 19;
			this.list_book.UseCompatibleStateImageBehavior = false;
			this.list_book.View = System.Windows.Forms.View.Details;
			this.list_book.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.list_book_MouseDoubleClick);
			// 
			// btn_search
			// 
			this.btn_search.Font = new System.Drawing.Font("돋움", 9F);
			this.btn_search.Location = new System.Drawing.Point(598, 39);
			this.btn_search.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.btn_search.Name = "btn_search";
			this.btn_search.Size = new System.Drawing.Size(54, 29);
			this.btn_search.TabIndex = 17;
			this.btn_search.Text = "검색";
			this.btn_search.UseVisualStyleBackColor = true;
			this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
			// 
			// btn_insert
			// 
			this.btn_insert.Font = new System.Drawing.Font("돋움", 9F);
			this.btn_insert.Location = new System.Drawing.Point(658, 39);
			this.btn_insert.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.btn_insert.Name = "btn_insert";
			this.btn_insert.Size = new System.Drawing.Size(54, 29);
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
			this.cb_category.Location = new System.Drawing.Point(14, 40);
			this.cb_category.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.cb_category.Name = "cb_category";
			this.cb_category.Size = new System.Drawing.Size(62, 23);
			this.cb_category.TabIndex = 25;
			this.cb_category.ValueMember = "제목";
			// 
			// label_name
			// 
			this.label_name.AutoSize = true;
			this.label_name.Location = new System.Drawing.Point(11, 11);
			this.label_name.Name = "label_name";
			this.label_name.Size = new System.Drawing.Size(37, 15);
			this.label_name.TabIndex = 26;
			this.label_name.Text = "이름";
			// 
			// btn_reset
			// 
			this.btn_reset.Font = new System.Drawing.Font("돋움", 9F);
			this.btn_reset.Location = new System.Drawing.Point(598, 4);
			this.btn_reset.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.btn_reset.Name = "btn_reset";
			this.btn_reset.Size = new System.Drawing.Size(114, 29);
			this.btn_reset.TabIndex = 27;
			this.btn_reset.Text = "초기화";
			this.btn_reset.UseVisualStyleBackColor = true;
			this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
			// 
			// ManageForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(726, 498);
			this.Controls.Add(this.btn_reset);
			this.Controls.Add(this.label_name);
			this.Controls.Add(this.cb_category);
			this.Controls.Add(this.btn_insert);
			this.Controls.Add(this.tb_search);
			this.Controls.Add(this.list_book);
			this.Controls.Add(this.btn_search);
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
	}
}