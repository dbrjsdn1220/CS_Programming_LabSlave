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
	public delegate void DataGetEventHandler(string category, string title, string author, int copyCount);

    public partial class InsertForm : Form
    {
		public DataGetEventHandler DataSendEvent;

		public InsertForm()
        {
            InitializeComponent();
        }

        private void InsertForm_Load(object sender, EventArgs e)
        {
            cb_bookCategory.Items.Add("경제/경영");
            cb_bookCategory.Items.Add("과학");
            cb_bookCategory.Items.Add("도감");
            cb_bookCategory.Items.Add("만화");
            cb_bookCategory.Items.Add("소설");
            cb_bookCategory.Items.Add("인문");
            cb_bookCategory.Items.Add("자기계발");
            cb_bookCategory.Items.Add("자소전");
            cb_bookCategory.Items.Add("희곡");
            cb_bookCategory.SelectedIndex = 0;
			tb_bookCount.Value = 1;
		}

        private void btn_reset_Click(object sender, EventArgs e)
        {
            // cb_bookCategory.SelectedIndex = 0;
            tb_bookTitle.Text = "";
			tb_bookAuthor.Text = "";
			tb_bookCount.Value = 1;
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
			if (CheckString(tb_bookTitle.Text))
			{
				MessageBox.Show("도서 제목을 입력해 주세요."); return;
			}

			if (CheckString(tb_bookAuthor.Text))
			{
				MessageBox.Show("도서 저자를 입력해 주세요."); return;
			}

			int bookCount = (int) tb_bookCount.Value;
			
			if (bookCount > 1000 || bookCount < 1)
			{
				MessageBox.Show("[책 갯수 입력값 Error]\n\n[입력한 값 : " + bookCount  + "]\n(1 ~ 1000) 사이의 값을 입력해 주세요."); return;
			}
			DataSendEvent(cb_bookCategory.Text.Trim(), tb_bookTitle.Text.Trim(), tb_bookAuthor.Text.Trim(), bookCount);
			this.Close();
		}

		private bool CheckString(string value)
		{
			return value == null || value.Trim().Length == 0;
		}
	}
}
