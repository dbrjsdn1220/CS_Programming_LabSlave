using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Management_Books.repository.loan;
using Management_Books.service;

namespace Management_Books
{
    public partial class CheckBorrowForm : Form
    {
		private LoanService loanService;

        public CheckBorrowForm()
        {
            InitializeComponent();
			loanService = new LoanService();
		}

        private void CheckBorrowForm_Load(object sender, EventArgs e)
        {
            cb_grade.Items.Add("학년");
            for (int n = 1; n < 7; n++) { cb_grade.Items.Add(n.ToString()); }
            cb_grade.SelectedIndex = 0;

            cb_class.Items.Add("반");
            for (int n = 1; n < 11; n++)
            {
                if (n < 10) { cb_class.Items.Add("0" + n.ToString()); continue; }
                cb_class.Items.Add(n.ToString());
            }
            cb_class.SelectedIndex = 0;

            cb_number.Items.Add("번호");
            for (int n = 1; n < 31; n++)
            {
                if (n < 10) { cb_number.Items.Add("0" + n.ToString()); continue; }
                cb_number.Items.Add(n.ToString());
            }
            cb_number.SelectedIndex = 0;


            list_loan.Columns.Add("번호", (int)(list_loan.Width * 0.15));
            list_loan.Columns.Add("대출자", (int)(list_loan.Width * 0.20));
            list_loan.Columns.Add("대출 일자", (int)(list_loan.Width * 0.25));
            list_loan.Columns.Add("반납 예정", (int)(list_loan.Width * 0.25));
            list_loan.Columns.Add("연장 유무", (int)(list_loan.Width * 0.15));
        }

        private void btn_select_Click(object sender, EventArgs e)
        {
            int studentId;
            if (!int.TryParse(cb_grade.Text + cb_class.Text + cb_number.Text, out studentId))
            {
                MessageBox.Show("학년, 반, 번호를 선택 해주세요."); return;
            }
            List<LoanEntity> loanList = loanService.SelectStudentIdByLoans(studentId);
            list_loan_print(loanList);
        }

		private void list_loan_print(List<LoanEntity> loanList)
		{
			list_loan.Items.Clear();
			ListViewItem item;

			foreach (LoanEntity loan in loanList)
			{
				item = new ListViewItem(loan.getCopyBookId().ToString());
				item.SubItems.Add(loan.getStudentId().ToString());
				item.SubItems.Add(loan.getStartDate().ToString("yyyy-MM-dd"));
				item.SubItems.Add(loan.getEndDate().ToString("yyyy-MM-dd"));
				item.SubItems.Add((loan.getExtend()) ? "O" : "X");
				list_loan.Items.Add(item);
			}
		}

	}
}
