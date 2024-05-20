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
            this.label2 = new System.Windows.Forms.Label();
            this.tb_quantity = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_author = new System.Windows.Forms.TextBox();
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
            this.label1.Location = new System.Drawing.Point(33, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "제목";
            // 
            // tb_title
            // 
            this.tb_title.Location = new System.Drawing.Point(68, 108);
            this.tb_title.Name = "tb_title";
            this.tb_title.Size = new System.Drawing.Size(121, 21);
            this.tb_title.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("돋움", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(22, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 37);
            this.label2.TabIndex = 17;
            this.label2.Text = "도서 추가";
            // 
            // tb_quantity
            // 
            this.tb_quantity.Location = new System.Drawing.Point(68, 162);
            this.tb_quantity.Name = "tb_quantity";
            this.tb_quantity.Size = new System.Drawing.Size(121, 21);
            this.tb_quantity.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 18;
            this.label3.Text = "권수";
            // 
            // tb_author
            // 
            this.tb_author.Location = new System.Drawing.Point(68, 135);
            this.tb_author.Name = "tb_author";
            this.tb_author.Size = new System.Drawing.Size(121, 21);
            this.tb_author.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 20;
            this.label4.Text = "저자";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 22;
            this.label5.Text = "분류";
            // 
            // cb_category
            // 
            this.cb_category.FormattingEnabled = true;
            this.cb_category.Location = new System.Drawing.Point(68, 82);
            this.cb_category.Name = "cb_category";
            this.cb_category.Size = new System.Drawing.Size(121, 20);
            this.cb_category.TabIndex = 23;
            // 
            // btn_insert
            // 
            this.btn_insert.BackColor = System.Drawing.Color.Gold;
            this.btn_insert.Location = new System.Drawing.Point(119, 196);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(70, 23);
            this.btn_insert.TabIndex = 24;
            this.btn_insert.Text = "추가";
            this.btn_insert.UseVisualStyleBackColor = false;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.BackColor = System.Drawing.Color.LightGray;
            this.btn_reset.Location = new System.Drawing.Point(35, 196);
            this.btn_reset.Name = "button1";
            this.btn_reset.Size = new System.Drawing.Size(70, 23);
            this.btn_reset.TabIndex = 25;
            this.btn_reset.Text = "초기화";
            this.btn_reset.UseVisualStyleBackColor = false;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // InsertForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(225, 234);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_insert);
            this.Controls.Add(this.cb_category);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_author);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_quantity);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_title);
            this.Controls.Add(this.label1);
            this.Name = "InsertForm";
            this.Text = "InsertForm";
            this.Load += new System.EventHandler(this.InsertForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_title;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_quantity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_author;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cb_category;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.Button btn_reset;
    }
}