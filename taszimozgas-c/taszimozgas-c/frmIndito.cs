using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;




namespace taszimozgas_c
{
      

    public partial class frmIndito : Form
    {
        

        public frmIndito()
        {
            InitializeComponent();
        }
        
       
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Helló!","Üzenet ablak",MessageBoxButtons.YesNoCancel);
            this.Close();
        }


        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (panel1.Width != panel1.PreferredSize.Width)
            {  
                panel1.Width = panel1.PreferredSize.Width;
                btnMenu.Left = panel1.Width - btnMenu.Width;
            }
            else
            {
                panel1.Width = 0;
                btnMenu.Left = panel1.Width;
            }

        }


        private void igazit()
        {
            btnMenu.Top = 0;
        }


        private void Form2_Load(object sender, EventArgs e)
        {
            igazit();
            panel1.Width = 0;
            btnMenu.Left = panel1.Width;
            btnLogin.Top = btnMenu.Height;
            //panel1.Top = btnLogin.Height;
            if (!DB.Belepve)
            {
                button4_Click(null,null);
            }
        }


        private void button4_Click(object sender, EventArgs e)
        {
            //button3_Click(null, null);
            if (DB.Belepve)
            {
                DialogResult ujlogin = MessageBox.Show("Már bejelentkezett " + DB.LogName + " néven."
                    + "\nÚjra belép?", "Belépés megerősítése", MessageBoxButtons.YesNo);
                if (ujlogin == DialogResult.Yes)
                {
                    frmLogin formlogin = new frmLogin();
                    DialogResult belep = formlogin.ShowDialog();
                }
                else
                {

                }
            }
            else
            {

                frmLogin formlogin = new frmLogin();
                DialogResult belep = formlogin.ShowDialog();
                btnMenu_Click(null, null);
            }
        }

        private void btnKilepes_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            if (DB.AdminUser)
            {
                MessageBox.Show("Adminisztrációs tennivalók.");
            }
            else
            {
                MessageBox.Show("Nincs jogosultsága ehhez a tartalomhoz.", "Hozzáférés megtagadva" , MessageBoxButtons.OK);

            }
        }

        private void btnMozgas_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mozgás rögzítés");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Lekérdezések.");
        }
    }
}
