using Management_Books.repository.book;
using Management_Books.repository.bookCopies;
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
    public partial class BookDetailForm : Form
    {
		private long bookId;
		private BookEntity book;
		private BookService bookService;
		private LoanService loanService;

		public BookDetailForm(long bookId)
        {
			InitializeComponent();
			this.bookId = bookId;
			bookService = new BookService();
			loanService = new LoanService();
		}

        private void BookDetailForm_Load(object sender, EventArgs e)
        {
			list_copy.Columns.Add("번호", (int)(list_copy.Width * 0.15));
			list_copy.Columns.Add("대출자", (int)(list_copy.Width * 0.15));
			list_copy.Columns.Add("대출 일자", (int)(list_copy.Width * 0.20));
			list_copy.Columns.Add("반납 예정", (int)(list_copy.Width * 0.20));
			list_copy.Columns.Add("대출 연장", (int)(list_copy.Width * 0.15));
			list_copy.Columns.Add("책 존재", (int)(list_copy.Width * 0.15));

			book = bookService.FindBookByBookId(bookId);
			tb_category.Text = book.getCategory();
			tb_title.Text = book.getTitle();
			tb_author.Text = book.getAuthor();
			Request();
		}

		private void btn_borrow_Click(object sender, EventArgs e)
		{
			if (list_copy.SelectedItems.Count == 0)
			{
				MessageBox.Show("대출할 책을 선택 해주세요."); return;
			}

			int selectRow = list_copy.SelectedItems[0].Index;
			int studentId = -1;
			long CopyBookId = long.Parse(list_copy.Items[selectRow].SubItems[0].Text);
			int.TryParse(list_copy.Items[selectRow].SubItems[1].Text, out studentId);
			BorrowForm subFrom = new BorrowForm(CopyBookId, studentId, tb_title.Text, tb_author.Text);
			subFrom.ShowDialog();
			Request();
		}

		private void btn_extend_Click(object sender, EventArgs e)
		{
			if (list_copy.SelectedItems.Count == 0)
			{
				MessageBox.Show("대출을 연장할 책을 선택 해주세요."); return;
			}

			int selectRow = list_copy.SelectedItems[0].Index;
			if (list_copy.Items[selectRow].SubItems[4].Text.Equals("O"))
			{
				MessageBox.Show("이미 대출 연장을 한 책입니다."); return;
			}
			long copyBookId = long.Parse(list_copy.Items[selectRow].SubItems[0].Text);
			DateTime endDate;
			DateTime.TryParse(list_copy.Items[selectRow].SubItems[3].Text, out endDate);
			if (!loanService.BookExtend(copyBookId, endDate))
			{
				MessageBox.Show("대출 연장을 실패했습니다."); return;
			}
			int studentId = int.Parse(list_copy.Items[selectRow].SubItems[1].Text);
			MessageBox.Show("[이용자 : " + studentId.ToString() + "]님이 " + book.getTitle() + "(" + copyBookId.ToString() + ")의 책의 대출 기한을 연장(+7일) 하였습니다.");
			Request();
		}

		private void Request()
		{
			List<CopyBookEntity> copyList = bookService.FindAllBookIdByCopyBook(book.getBookId());
			List<LoanEntity> loanList = loanService.FindByCopyIdAll(bookId);
			list_copyBook_print(copyList, loanList);
		}
		
		private void list_copyBook_print(List<CopyBookEntity> copyList, List<LoanEntity> loanList)
		{
			list_copy.Items.Clear();
			ListViewItem item;

			foreach (CopyBookEntity copy in copyList)
			{
				item = new ListViewItem(copy.getCopyBookId().ToString());
				item.SubItems.Add("---");
				item.SubItems.Add("---");
				item.SubItems.Add("---");
				item.SubItems.Add("O");
				item.SubItems.Add("O");
				list_copy.Items.Add(item);
			}

			foreach (LoanEntity loan in loanList)
			{
				item = new ListViewItem(loan.getCopyBookId().ToString());
				item.SubItems.Add(loan.getStudentId().ToString());
				item.SubItems.Add(loan.getStartDate().ToString("yyyy-MM-dd"));
				item.SubItems.Add(loan.getEndDate().ToString("yyyy-MM-dd"));
				item.SubItems.Add((loan.getExtend()) ? "O" : "X");
				item.SubItems.Add("X");
				list_copy.Items.Add(item);
			}
		}
	}
}
