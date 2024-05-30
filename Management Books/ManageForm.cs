using Management_Books.repository.book;
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
	public partial class ManageForm : Form
	{
		string userId;
		private BookEntity book;
		private BookService bookService;

		public ManageForm(string userId)
		{
			InitializeComponent();
			this.userId = userId;
			bookService = new BookService();
		}

		private void ManageFoam_Load(object sender, EventArgs e)
		{
			lb_userId.Text = "[관리자 : " + userId + "]";
			list_book.Columns.Add("장르", (int)(list_book.Width * 0.145));
			list_book.Columns.Add("저자", (int)(list_book.Width * 0.2));
			list_book.Columns.Add("제목", (int)(list_book.Width * 0.55));
			list_book.Columns.Add("잔권", (int)(list_book.Width * 0.1));

			cb_bookCategory.Items.Add("제목");
			cb_bookCategory.Items.Add("저자");
			cb_bookCategory.SelectedIndex = 0;

			List<BookEntity> bookList = bookService.GetAllBooks();
			list_book_print(bookList);
		}

		private void btn_insert_Click(object sender, EventArgs e)
		{
			InsertForm subFoam = new InsertForm();
			subFoam.DataSendEvent += new DataGetEventHandler(this.DataGet);
			subFoam.ShowDialog();

			if (CheckDate(book)) { return; }

			if (CheckString(book.getTitle())
				|| CheckString(book.getAuthor())
				|| CheckString(book.getCategory())
				|| book.getCopyCount() < 0)
			{
				MessageBox.Show("데이터를 제대로 입력 해주세요."); return;
			}

			if (!bookService.AddBook(book)) {
				MessageBox.Show("저장 실패!"); return;
			}

			List<BookEntity> bookList = bookService.GetAllBooks();
			list_book_print(bookList);
		}

		private void btn_search_Click(object sender, EventArgs e)
		{
			if (CheckString(tb_search.Text))  // 문자열이 null이거나 빈 문자열 또는 공백 문자열일 경우
			{
				MessageBox.Show("검색어를 입력 해주세요."); return;
			}

			List<BookEntity> bookList = bookService.SearchOption(cb_bookCategory.Text, tb_search.Text);
			list_book_print(bookList);
		}

		private void btn_reset_Click(object sender, EventArgs e)
		{
			List<BookEntity> bookList = bookService.GetAllBooks();
			list_book_print(bookList);
		}


		private void list_book_print(List<BookEntity> bookList)
		{
			list_book.Items.Clear();
			ListViewItem item;

			foreach (BookEntity book in bookList)
			{
				item = new ListViewItem(book.getCategory());
				item.SubItems.Add(book.getAuthor());
				item.SubItems.Add(book.getTitle());
				item.SubItems.Add(book.getCopyCount().ToString());
				list_book.Items.Add(item);
			}
		}
		private void list_book_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			List<BookEntity> bookList = bookService.GetAllBooks();
			int selectRow = list_book.SelectedItems[0].Index;
			long selectID = bookList[selectRow].getBookId();
			BookDetailForm subFrom = new BookDetailForm(selectID);
			subFrom.ShowDialog();
		}

		private void DataGet(string category, string title, string author, int copyCount)
		{
			book = new BookBuilder()
						.title(title)
						.author(author)
						.category(category)
						.copyCount(copyCount)
						.build();
		}

		private bool CheckDate(BookEntity book)
		{
			return book == null;
		}

		// String.IsNullOrWhiteSpace(value) 도 이하 동일
		private bool CheckString(string value)
		{
			return value == null || value.Trim().Length == 0;
		}

		private void tb_search_KeyDown(object sender, KeyEventArgs e)
		{
            if (e.KeyCode == Keys.Enter)
            {
                btn_search_Click(sender, e);
            }
        }

		private void btn_check_borrow_Click(object sender, EventArgs e)
		{
			CheckBorrowForm subForm = new CheckBorrowForm();
			subForm.ShowDialog();
		}
	}
}
