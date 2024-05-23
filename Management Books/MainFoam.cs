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
    public partial class MainFoam : Form
    {
        public MainFoam()
        {
            InitializeComponent();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            SearchFoam subFoam = new SearchFoam();
            subFoam.ShowDialog();
            this.Visible = true;
        }

        private void btn_borrow_Click(object sender, EventArgs e)
        {

        }

        private void btn_manage_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            LoginFoam subFoam = new LoginFoam();
            subFoam.ShowDialog();
            this.Visible = true;
        }
    }
}
