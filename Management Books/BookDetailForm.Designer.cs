namespace Management_Books
{
    partial class BookDetailForm
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
            this.label5 = new System.Windows.Forms.Label();
            this.tb_author = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_title = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_deleteAll = new System.Windows.Forms.Button();
            this.list_copy = new System.Windows.Forms.ListView();
            this.tb_category = new System.Windows.Forms.TextBox();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_extend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 30;
            this.label5.Text = "분류";
            // 
            // tb_author
            // 
            this.tb_author.Location = new System.Drawing.Point(431, 16);
            this.tb_author.Name = "tb_author";
            this.tb_author.Size = new System.Drawing.Size(112, 21);
            this.tb_author.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(396, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 28;
            this.label4.Text = "저자";
            // 
            // tb_title
            // 
            this.tb_title.Location = new System.Drawing.Point(202, 16);
            this.tb_title.Name = "tb_title";
            this.tb_title.Size = new System.Drawing.Size(166, 21);
            this.tb_title.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(167, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 24;
            this.label1.Text = "제목";
            // 
            // btn_deleteAll
            // 
            this.btn_deleteAll.Location = new System.Drawing.Point(564, 15);
            this.btn_deleteAll.Name = "btn_deleteAll";
            this.btn_deleteAll.Size = new System.Drawing.Size(82, 23);
            this.btn_deleteAll.TabIndex = 33;
            this.btn_deleteAll.Text = "전체 삭제";
            this.btn_deleteAll.UseVisualStyleBackColor = true;
            // 
            // list_copy
            // 
            this.list_copy.GridLines = true;
            this.list_copy.HideSelection = false;
            this.list_copy.Location = new System.Drawing.Point(12, 51);
            this.list_copy.Name = "list_copy";
            this.list_copy.Size = new System.Drawing.Size(634, 187);
            this.list_copy.TabIndex = 34;
            this.list_copy.UseCompatibleStateImageBehavior = false;
            this.list_copy.View = System.Windows.Forms.View.Details;
            // 
            // tb_category
            // 
            this.tb_category.Location = new System.Drawing.Point(53, 15);
            this.tb_category.Name = "tb_category";
            this.tb_category.Size = new System.Drawing.Size(87, 21);
            this.tb_category.TabIndex = 35;
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(474, 246);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(82, 23);
            this.btn_delete.TabIndex = 36;
            this.btn_delete.Text = "선택 삭제";
            this.btn_delete.UseVisualStyleBackColor = true;
            // 
            // btn_extend
            // 
            this.btn_extend.Location = new System.Drawing.Point(564, 246);
            this.btn_extend.Name = "btn_extend";
            this.btn_extend.Size = new System.Drawing.Size(82, 23);
            this.btn_extend.TabIndex = 37;
            this.btn_extend.Text = "대출 연장";
            this.btn_extend.UseVisualStyleBackColor = true;
            // 
            // BookDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 280);
            this.Controls.Add(this.btn_extend);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.tb_category);
            this.Controls.Add(this.list_copy);
            this.Controls.Add(this.btn_deleteAll);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_author);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_title);
            this.Controls.Add(this.label1);
            this.Name = "BookDetailForm";
            this.Text = "도서 상세 정보";
            this.Load += new System.EventHandler(this.BookDetailForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_author;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_deleteAll;
        private System.Windows.Forms.ListView list_copy;
        private System.Windows.Forms.TextBox tb_category;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_extend;
    }
}