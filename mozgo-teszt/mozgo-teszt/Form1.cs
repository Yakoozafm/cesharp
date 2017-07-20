using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mozgo_teszt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void iranyBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.iranyBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.taszimozgasDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'taszimozgasDataSet.irany' table. You can move, or remove it, as needed.
            this.iranyTableAdapter.Fill(this.taszimozgasDataSet.irany);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.iskolaTableAdapter.FillBy(this.taszimozgasDataSet.iskola);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void iranyBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
