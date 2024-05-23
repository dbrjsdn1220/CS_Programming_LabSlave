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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            SearchForm subForm = new SearchForm();
            subForm.ShowDialog();
            this.Visible = true;
        }

        private void btn_manage_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            LoginForm subForm = new LoginForm();
            subForm.ShowDialog();
            this.Visible = true;
        }
        private void btn_borrow_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            BorrowForm subForm = new BorrowForm();
            subForm.ShowDialog();
            this.Visible = true;
        }
    }
}
