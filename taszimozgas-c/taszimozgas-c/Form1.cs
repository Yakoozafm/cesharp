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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'taszimozgasDataSet.irany' table. You can move, or remove it, as needed.
            this.iranyTableAdapter.Fill(this.taszimozgasDataSet.irany);
            
            dataGridView1.BackgroundColor = Color.DarkGray;
            dataGridView1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void iranyBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
           

        }

        private void q_iranyosToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.iranyTableAdapter.q_iranyos(this.taszimozgasDataSet.irany);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
