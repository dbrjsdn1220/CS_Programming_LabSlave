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
    public partial class SearchForm : Form
    {
        private BookService bookService;

        public SearchForm()
        {
            InitializeComponent();
            bookService = new BookService();
        }

        private void SearchFoam_Load(object sender, EventArgs e)
        {
            // list_book.Sorting = SortOrder.Ascending;
            list_book.Columns.Add("장르", (int)(list_book.Width * 0.12));
            list_book.Columns.Add("저자", (int)(list_book.Width * 0.2));
            list_book.Columns.Add("제목", (int)(list_book.Width * 0.58));
            list_book.Columns.Add("잔권", (int)(list_book.Width * 0.1));

            cb_category.Items.Add("제목");
            cb_category.Items.Add("저자");
            cb_category.SelectedIndex = 0;

            List<BookEntity> bookList = bookService.GetAllBooks();
            list_book_print(bookList);
        }
		
		private void btn_search_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(tb_search.Text))  // 문자열이 null이거나 빈 문자열 또는 공백 문자열일 경우
            {
                MessageBox.Show("검색어를 입력 해주세요."); return;
            }

            List<BookEntity> bookList = bookService.SearchOption(cb_category.Text, tb_search.Text);
            list_book_print(bookList);
        }

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
                list_book.Items.Add(item);
            }
        }

		private void list_book_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			List<BookEntity> bookList = bookService.GetAllBooks();
			int selectRow = list_book.SelectedItems[0].Index;
			long selectID = bookList[selectRow].getId();
			BookDetailForm_user subFrom = new BookDetailForm_user(selectID);
			subFrom.ShowDialog();
		}
	}
}
