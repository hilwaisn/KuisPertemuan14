using KuisPertemuan14.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KuisPertemuan14.View
{
    public partial class Form3 : Form
    {
        GetListController getlist;
        public Form3()
        {
            getlist = new GetListController();
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtKS_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void lblKS_Click(object sender, EventArgs e)
        {

        }

        private void lblEmail_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if ((txtEmail.Text == "") || (txtKS.Text == ""))
            {
                MessageBox.Show("Need login data", "Wrong login");
            }
        }
    }
}
