using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using Npgsql;
using System.Data.Odbc;

namespace taszimozgas_c
{
    public partial class Form1 : Form
    {
        NpgsqlConnection connection;
        string connectionString;
        NpgsqlDataAdapter adapter;

        public Form1()
        {
            InitializeComponent();

            connectionString = ConfigurationManager.ConnectionStrings["taszimozgasCS"].ConnectionString;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Felelosleker();
            DB.Kapcs_Eszkoz();
            DB.Kapcs_Irany();

            comboBox1.DataSource = DB.tblEszkoz;
            comboBox1.ValueMember = "id";
            comboBox1.DisplayMember = "Nev";

            comboBox2.DataSource = DB.tblIrany;
            comboBox2.ValueMember = "id";
            comboBox2.DisplayMember = "Nev";

            dataGridView2.DataSource = DB.tblIrany;
            DB.iranycb = new NpgsqlCommandBuilder(DB.iranyadapter);
        }

        private void Felelosleker()
        {

           
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(listBox1.SelectedValue.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DB.Insert_Irany("Brexit.");
            comboBox2.DataSource = DB.tblIrany;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DB.iranyadapter.Update(DB.tblIrany);
            DB.tblIrany.Clear();
            DB.iranyadapter.Fill(DB.tblIrany);
            dataGridView2.Rows[dataGridView2.Rows.Count - 1].Selected = true;
        }
    }
}
