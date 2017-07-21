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

            connectionString = ConfigurationManager.ConnectionStrings["taszimozgas_c.Properties.Settings.taszimozgasConnectionString"].ConnectionString;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Felelosleker();
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
            MessageBox.Show(listBox1.SelectedValue.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Application.Exit();
        }
    }
}
