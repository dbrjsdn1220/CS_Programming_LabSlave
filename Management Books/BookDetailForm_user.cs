using Management_Books.repository.book;
using Management_Books.repository.bookCopies;
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
	public partial class BookDetailForm_user : Form
	{
		private long bookId;
		private BookEntity book;
		private BookService bookService;

		public BookDetailForm_user(long bookId)
		{
			InitializeComponent();
			this.bookId = bookId;
			bookService = new BookService();
		}

		private void BookDetailForm_user_Load(object sender, EventArgs e)
		{
			list_copy.Columns.Add("번호", (int)(list_copy.Width * 0.15));
			list_copy.Columns.Add("존재 유무", (int)(list_copy.Width * 0.10));

			book = bookService.FindBookByBookId(bookId);
			tb_category.Text = book.getCategory();
			tb_title.Text = book.getTitle();
			tb_author.Text = book.getAuthor();

			List<CopyBookEntity> copyList = bookService.FindAllBookIdByCopyBook(book.getBookId());
			list_copyBook_print(copyList);
		}

		private void list_copyBook_print(List<CopyBookEntity> bookList)
		{
			list_copy.Items.Clear();
			ListViewItem item;

			foreach (CopyBookEntity copy in bookList)
			{
				item = new ListViewItem(copy.getCopyBookId().ToString());
				item.SubItems.Add((copy.getAlive()) ? "O" : "X");
				list_copy.Items.Add(item);
			}
		}
	}
}
