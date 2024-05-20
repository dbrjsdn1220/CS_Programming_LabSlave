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

        public ManageFoam(string name)
        {
            InitializeComponent();
            admin = name;
        }

        private void ManageFoam_Load(object sender, EventArgs e)
        {
            label_name.Text = admin+"님";
        }
    }
}
