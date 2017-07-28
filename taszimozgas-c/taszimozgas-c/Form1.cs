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
        //SqlConnection connection;
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
        }

        private void Felelosleker()
        {

            using (connection = new NpgsqlConnection(connectionString))
            using (adapter = new NpgsqlDataAdapter("Select * From felelos", connection))
            {
                connection.Open();
                DataTable felelosTabla = new DataTable();
                adapter.Fill(felelosTabla);
                dataGridView1.DataSource = felelosTabla;

                listBox1.DataSource = felelosTabla;
                listBox1.DisplayMember = "Nev";
                listBox1.ValueMember = "id";

                

            }
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

    }
}
