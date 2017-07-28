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
            btnLogin.Top = btnMenu.Height + btnMenu.Top;
            btnMozgas.Top = btnLogin.Height + btnLogin.Top;
            btnLekerdezes.Top = btnMozgas.Height + btnMozgas.Top;
            btnAdmin.Top = btnLekerdezes.Height + btnLekerdezes.Top;
            btnKilepes.Top = btnAdmin.Top + btnAdmin.Height;
            
        }


        private void checkdb()
        {
            DB.GetLocalIPAddress();
            if (DB.Belepve)
            {
                statusStrip1.Items[0].Text = "Adatbázis állapot: Nyitva.";
                statusStrip1.Items[1].Text = "Belépett felhasználó: " + DB.LogName;
                statusStrip1.Items[2].Text  ="Admin felhasználó: " + DB.AdminUser;
                statusStrip1.Items[3].Text = "Helyi ip cím: " + DB.ipk;
            }
            else
            {
                statusStrip1.Items[0].Text = "Adatbázis állapot: Zárolt.";
                statusStrip1.Items[1].Text = "Belépett felhasználó: " + DB.LogName;
                statusStrip1.Items[2].Text = "Admin felhasználó: " + DB.AdminUser;
                statusStrip1.Items[3].Text = "Helyi ip cím: " + DB.ipk;
            }
        }
        private void Form2_Load(object sender, EventArgs e)
        {

            MdiClient ctlMDI;

            // Loop through all of the form's controls looking
            // for the control of type MdiClient.
            foreach (Control ctl in this.Controls)
            {
                try
                {
                    // Attempt to cast the control to type MdiClient.
                    ctlMDI = (MdiClient)ctl;

                    // Set the BackColor of the MdiClient control.
                    ctlMDI.BackColor = this.BackColor;
                }
                catch (InvalidCastException exc)
                {
                    
                    // Catch and ignore the error if casting failed.
                }
            }





            igazit();
            checkdb();
            panel1.Width = 0;
            btnMenu.Left = panel1.Width;
            btnLogin.Top = btnMenu.Height;

            if (!DB.Belepve)
            {
                button4_Click(null,null);
            }
            else
            {
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
                    DB.Belepve = false;
                    DB.AdminUser = false;
                    DB.LogName = "";
                    frmLogin formlogin = new frmLogin();
                    DialogResult belep = formlogin.ShowDialog();
                    checkdb();

                }
                else
                {
        
                }
            }
            else
            {

                frmLogin formlogin = new frmLogin();
                DialogResult belep = formlogin.ShowDialog();
                checkdb();
                btnMenu_Click(null, null);
            }
        }

        private void btnKilepes_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            checkdb();
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
            Form1 form1 = new Form1();
            form1.MdiParent = this;
            form1.Show();
            checkdb();
        }

        

        private void btnLekerdezes_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Lekérdezések.");
            checkdb();
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
