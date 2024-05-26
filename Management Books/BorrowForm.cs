using Management_Books.repository.book;
using Management_Books.repository.loan;
using Management_Books.service;
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
    public partial class BorrowForm : Form
    {
		private long copyBookId;
		private int studentId;
		private string title;
		private string author;
		private BookService bookService;
		private LoanService loanService;

        public BorrowForm(long copyBookId, int studentId, string title, string author)
        {
            InitializeComponent();
			this.copyBookId = copyBookId;
			this.studentId = studentId;
			this.title = title;
			this.author = author;

			bookService = new BookService();
			loanService = new LoanService();
		}

		private void BorrowForm_Load(object sender, EventArgs e)
		{
			tb_bookId.Text = copyBookId.ToString();
			tb_bookTitle.Text = title;
			tb_bookAuthor.Text = author;

			cb_grade.Items.Add("학년");
			for (int n = 1; n < 7; n++) { cb_grade.Items.Add(n.ToString()); }
			cb_grade.SelectedIndex = 0;

			cb_class.Items.Add("반");
			for (int n = 1; n < 11; n++){
				if (n < 10) { cb_class.Items.Add("0" + n.ToString()); continue; }
				cb_class.Items.Add(n.ToString());
			}
			cb_class.SelectedIndex = 0;

			cb_number.Items.Add("번호");
			for (int n = 1; n < 31; n++){
				if (n < 10) { cb_number.Items.Add("0" + n.ToString()); continue; }
				cb_number.Items.Add(n.ToString());
			}
			cb_number.SelectedIndex = 0;

			list_loan.Columns.Add("번호", (int)(list_loan.Width * 0.15));
			list_loan.Columns.Add("대출자", (int)(list_loan.Width * 0.20));
			list_loan.Columns.Add("대출 일자", (int)(list_loan.Width * 0.25));
			list_loan.Columns.Add("반납 예정", (int)(list_loan.Width * 0.25));
			list_loan.Columns.Add("연장 유무", (int)(list_loan.Width * 0.15));

			List<LoanEntity> loanList = loanService.SelectStudentIdByLoans(studentId);
			list_loan_print(loanList);
		}

		private void btn_borrow_Click(object sender, EventArgs e)
		{
			bool result = false;
			int studentId;
			string str;
			if (!int.TryParse(cb_grade.Text + cb_class.Text + cb_number.Text, out studentId))
			{
				MessageBox.Show("학년, 반, 번호를 선택 해주세요."); return;
			}

			str = loanService.BookBorrow(copyBookId, studentId);
			if (!str.Equals("대출 성공"))
			{
				MessageBox.Show(str); return;
			}

			result = bookService.BookBorrow(copyBookId);
			if (!result)
			{
				MessageBox.Show(copyBookId.ToString() + " : 사본 책이 없어짐을 갱신 실패"); return;
			}

			List<LoanEntity> loanList = loanService.SelectStudentIdByLoans(studentId);
			list_loan_print(loanList);
		}

		private void btn_return_Click(object sender, EventArgs e)
		{
			bool result = false;
			int studentId;
			string str;
			if (!int.TryParse(cb_grade.Text + cb_class.Text + cb_number.Text, out studentId))
			{
				MessageBox.Show("학년, 반, 번호를 선택 해주세요."); return;
			}

			str = loanService.BookReturn(copyBookId, studentId);
			if (!str.Equals("반납 성공"))
			{
				MessageBox.Show(str); return;
			}

			result = bookService.BookReturn(copyBookId);
			if (!result)
			{
				MessageBox.Show(copyBookId.ToString() + " : 사본 책이 돌아옴을 갱신 실패"); return;
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
