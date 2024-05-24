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
			list_copy.Columns.Add("대출자", (int)(list_copy.Width * 0.25));
			list_copy.Columns.Add("대출 일자", (int)(list_copy.Width * 0.25));
			list_copy.Columns.Add("반납 예정", (int)(list_copy.Width * 0.25));
			list_copy.Columns.Add("책 존재", (int)(list_copy.Width * 0.10));

			book = bookService.FindBook(bookId);
			tb_category.Text = book.getCategory();
			tb_title.Text = book.getTitle();
			tb_author.Text = book.getAuthor();

			List<BookCopieEntity> copyList = bookService.FindAllCopiesByBookId(book.getId());
			List<LoanEntity> loanList = loanService.FindByCopyIdAll(bookId);

			list_copyBook_print(copyList, loanList);
		}

		private void list_copyBook_print(List<BookCopieEntity> copyList, List<LoanEntity> loanList)
		{
			list_copy.Items.Clear();
			ListViewItem item;

			foreach (BookCopieEntity copy in copyList)
			{
				item = new ListViewItem(copy.getId().ToString());
				item.SubItems.Add("---");
				item.SubItems.Add("---");
				item.SubItems.Add("---");
				item.SubItems.Add("1");
				list_copy.Items.Add(item);
			}

			foreach (LoanEntity copy in loanList)
			{
				item = new ListViewItem(l)
			}
		}

		private void btn_borrow_Click(object sender, EventArgs e)
		{
			if (list_copy.SelectedItems.Count == 0)
			{
				MessageBox.Show("대출할 책을 선택 해주세요."); return;
			}

			int selectRow = list_copy.SelectedItems[0].Index;
			if (list_copy.Items[selectRow].SubItems[4].Text == "0")
			{
				MessageBox.Show("현재 도서관에 존재하지 않는 책입니다."); return;
			}
			long selectID = long.Parse(list_copy.Items[selectRow].SubItems[0].Text);
			BorrowForm subFrom = new BorrowForm(selectID);
			subFrom.ShowDialog();
		}
	}
}
