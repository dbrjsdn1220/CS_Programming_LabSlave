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
        public BookDetailForm()
        {
            InitializeComponent();
        }

        private void BookDetailForm_Load(object sender, EventArgs e)
        {
            list_copy.Columns.Add("번호", (int)(list_copy.Width * 0.1));
            list_copy.Columns.Add("대출자", (int)(list_copy.Width * 0.3));
            list_copy.Columns.Add("대출 일자", (int)(list_copy.Width * 0.3));
            list_copy.Columns.Add("반납 예정", (int)(list_copy.Width * 0.3));
        }
    }
}
