using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace taszimozgas_c
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblLogin_Click(object sender, EventArgs e)
        {

        }

        private void txtUser_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "Felhasználónév")
            {
                txtUser.Text = "";
               
            }
            else
                txtUser.Text = "Felhasználónév";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            db.setFelhnev(txtUser.Text);
            db.setJelsz(txtPassword.Text);
            
            MessageBox.Show("Test");
        }
    }
}
