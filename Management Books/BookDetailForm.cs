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
    public partial class BookDetailForm : Form
    {
        private BookService bookService;
        private long selectID;

        public BookDetailForm(long selectID)
        {
            InitializeComponent();
            this.selectID = selectID;
            bookService = new BookService();
        }

        private void BookDetailForm_Load(object sender, EventArgs e)
        {
            list_copy.Columns.Add("번호", (int)(list_copy.Width * 0.1));
            list_copy.Columns.Add("대출자", (int)(list_copy.Width * 0.3));
            list_copy.Columns.Add("대출 일자", (int)(list_copy.Width * 0.3));
            list_copy.Columns.Add("반납 예정", (int)(list_copy.Width * 0.3));

            // 크게 어렵지는 않은데 시간이 부족하다보니 떠넘깁니다 ㅠㅠ
            // 책ID = selectID로 검색해서 tb_category, tb_name, tb_author에 Text 출력
            // selectID 이용해서 copies랑 loan에서 데이터 불러와 적절히 출력
        }
    }
}
