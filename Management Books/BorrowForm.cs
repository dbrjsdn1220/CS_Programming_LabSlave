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
		private long id;
		private BookService bookService;
		private LoanService loanService;

        public BorrowForm(long id)
        {
            InitializeComponent();
			this.id = id;
			bookService = new BookService();
			loanService = new LoanService();
        }

		private void BorrowForm_Load(object sender, EventArgs e)
		{
			tb_book.Text = id.ToString();
		}
	}
}
