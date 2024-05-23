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
	public partial class ManageFoam : Form
	{
		string admin;
		private BookEntity book;
		private BookService bookService;

		public ManageFoam(string name)
		{
			InitializeComponent();
			admin = name;
			bookService = new BookService();
		}

		private void ManageFoam_Load(object sender, EventArgs e)
		{
			label_name.Text = admin + "님";
			list_book.Columns.Add("장르", (int)(list_book.Width * 0.12));
			list_book.Columns.Add("저자", (int)(list_book.Width * 0.2));
			list_book.Columns.Add("제목", (int)(list_book.Width * 0.56));
			list_book.Columns.Add("잔권", (int)(list_book.Width * 0.1));

			cb_category.Items.Add("제목");
			cb_category.Items.Add("저자");
			cb_category.SelectedIndex = 0;

			List<BookEntity> bookList = bookService.GetAllBooks();
			list_book_print(bookList);
		}

		private void btn_insert_Click(object sender, EventArgs e)
		{
			InsertForm subFoam = new InsertForm();
			subFoam.DataSendEvent += new DataGetEventHandler(this.DataGet);
			subFoam.ShowDialog();

			if (!bookService.AddBook(book)) {
				MessageBox.Show("저장 실패!"); return;
			}

			List<BookEntity> bookList = bookService.GetAllBooks();
			list_book_print(bookList);
		}

		private void btn_search_Click(object sender, EventArgs e)
		{
			if (String.IsNullOrWhiteSpace(tb_search.Text))	// 문자열이 null이거나 빈 문자열 또는 공백 문자열일 경우
			{
				MessageBox.Show("검색어를 입력 해주세요."); return;
			}

			List<BookEntity> bookList = bookService.SearchOption(cb_category.Text, tb_search.Text);
			list_book_print(bookList);
		}
		/**
		 * 단순 list 출력용 method
		 */
		private void list_book_print(List<BookEntity> bookList)
		{
			list_book.Items.Clear();
			ListViewItem item;

			foreach (BookEntity book in bookList)
			{
				item = new ListViewItem(book.getCategory());
				item.SubItems.Add(book.getTitle());
				item.SubItems.Add(book.getAuthor());
				item.SubItems.Add(book.getCopyCount().ToString());
				item.SubItems.Add("[ + ]");
				item.SubItems.Add("[ - ]");
				list_book.Items.Add(item);
			}
		}
		
		private void DataGet(string title, string author, string category, int copyCount)
		{
			book = new BookBuilder()
						.title(title)
						.author(author)
						.category(category)
						.copyCount(copyCount)
						.build();
		}

		private void list_book_MouseDoubleClick(object sender, MouseEventArgs e)
		{
            List<BookEntity> bookList = bookService.GetAllBooks();
            int selectRow = list_book.SelectedItems[0].Index;
			long selectID = bookList[selectRow].getId();
            BookDetailForm subFrom = new BookDetailForm(selectID);
            subFrom.ShowDialog();
        }
	}
}
