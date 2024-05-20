namespace Management_Books
{
    partial class ManageFoam
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_insert = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label_name = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_search
            // 
            this.tb_search.Location = new System.Drawing.Point(73, 83);
            this.tb_search.Name = "tb_search";
            this.tb_search.Size = new System.Drawing.Size(444, 21);
            this.tb_search.TabIndex = 20;
            // 
            // list_book
            // 
            this.list_book.GridLines = true;
            this.list_book.HideSelection = false;
            this.list_book.Location = new System.Drawing.Point(12, 112);
            this.list_book.Name = "list_book";
            this.list_book.Size = new System.Drawing.Size(611, 326);
            this.list_book.TabIndex = 19;
            this.list_book.UseCompatibleStateImageBehavior = false;
            this.list_book.View = System.Windows.Forms.View.Details;
            // 
            // btn_search
            // 
            this.btn_search.Font = new System.Drawing.Font("돋움", 9F);
            this.btn_search.Location = new System.Drawing.Point(523, 83);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(47, 23);
            this.btn_search.TabIndex = 17;
            this.btn_search.Text = "검색";
            this.btn_search.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("돋움", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(230, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 37);
            this.label1.TabIndex = 16;
            this.label1.Text = "도서 관리";
            // 
            // btn_insert
            // 
            this.btn_insert.Font = new System.Drawing.Font("돋움", 9F);
            this.btn_insert.Location = new System.Drawing.Point(576, 83);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(47, 23);
            this.btn_insert.TabIndex = 21;
            this.btn_insert.Text = "추가";
            this.btn_insert.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DisplayMember = "제목";
            this.comboBox1.Font = new System.Drawing.Font("돋움", 9F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 84);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(55, 20);
            this.comboBox1.TabIndex = 25;
            this.comboBox1.ValueMember = "제목";
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(554, 9);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(69, 12);
            this.label_name.TabIndex = 26;
            this.label_name.Text = "관리자 이름";
            // 
            // ManageFoam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 450);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btn_insert);
            this.Controls.Add(this.tb_search);
            this.Controls.Add(this.list_book);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.label1);
            this.Name = "ManageFoam";
            this.Text = "도서 관리 프로그램";
            this.Load += new System.EventHandler(this.ManageFoam_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_search;
        private System.Windows.Forms.ListView list_book;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label_name;
    }
}