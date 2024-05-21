using Management_Books.repository.book;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Management_Books
{
    public partial class ManageFoam : Form
    {
        string admin;

        public ManageFoam(string name)
        {
            InitializeComponent();
            admin = name;
        }

        private void ManageFoam_Load(object sender, EventArgs e)
        {
            label_name.Text = admin+"님";
            list_book.Columns.Add("장르", (int)(list_book.Width * 0.12));
            list_book.Columns.Add("저자", (int)(list_book.Width * 0.2));
            list_book.Columns.Add("제목", (int)(list_book.Width * 0.58));
            list_book.Columns.Add("잔권", (int)(list_book.Width * 0.1));

            cb_category.Items.Add("제목");
            cb_category.Items.Add("저자");
            cb_category.SelectedIndex = 0;
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            InsertForm subFoam = new InsertForm();
            subFoam.ShowDialog();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
			// 검색 알고리즘

		}

		private void list_book_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            // 이게 특정 컬럼 클릭할 때 실행되는 기능인지 모르겠네;
            BookDetailForm subForm = new BookDetailForm();
            subForm.ShowDialog();
        }
    }
}
