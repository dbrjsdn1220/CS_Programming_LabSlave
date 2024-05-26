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
            cb_category.Items.Add("경제/경영");
            cb_category.Items.Add("과학");
            cb_category.Items.Add("도감");
            cb_category.Items.Add("만화");
            cb_category.Items.Add("소설");
            cb_category.Items.Add("인문");
            cb_category.Items.Add("자기계발");
            cb_category.Items.Add("자소전");
            cb_category.Items.Add("희곡");
            cb_category.SelectedIndex = 0;
			tb_bookCount.Text = "1";
		}

        private void btn_reset_Click(object sender, EventArgs e)
        {
            cb_category.SelectedIndex = 0;
            tb_title.Text = "";
			tb_author.Text = "";
			tb_bookCount.Text = "1";
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
			// 비교문으로 입력안된 부분 있으면 입력하라고 안내하는 코드 (황상욱)
			// cb_category, tb_title, tb_author, tb_quantity 값 읽어서 DB에 저장하는 로직
			if (CheckString(tb_title.Text)
				|| CheckString(tb_author.Text)
				|| CheckString(tb_bookCount.Text))
			{
				MessageBox.Show("데이터를 전부 입력 해주세요."); return;
			}

			int copyCount;
			if (!int.TryParse(tb_bookCount.Text, out copyCount))
			{
				MessageBox.Show("숫자를 입력 해주세요."); return;
			}
			if (copyCount < 1)
			{
				MessageBox.Show("1 이상의 숫자를 입력 해주세요."); return;
			}

			DataSendEvent(cb_category.Text.Trim(), tb_title.Text.Trim(), tb_author.Text.Trim(), copyCount);
			this.Close();
		}

		private bool CheckString(string value)
		{
			return value == null || value.Trim().Length == 0;
		}
	}
}
