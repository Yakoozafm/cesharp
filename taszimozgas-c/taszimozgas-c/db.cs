using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace taszimozgas_c
{
    class DB
    {
        public static String Felhnev;
        public static String Jelsz;

        static NpgsqlConnection connection;
        static NpgsqlDataAdapter adapter;
        static DataTable tbllogin;
        static NpgsqlCommand command;
        static string connectionString = ConfigurationManager.ConnectionStrings["taszimozgasCS"].ConnectionString;

        public static void Kapcsolodas()
        {
            using (connection = new NpgsqlConnection(connectionString))
            
            {
               connection.Open();
                
            }
        }
        public static bool Login(String str_login, String str_password)
            {
            connection = new NpgsqlConnection(connectionString);
            //connection.Open();
            NpgsqlParameter login = new NpgsqlParameter("LOGIN",DbType.String);
            NpgsqlParameter password = new NpgsqlParameter("PASSWORD", DbType.String);
            login.Value = str_login;
            password.Value = str_password;

            //using (adapter = new NpgsqlDataAdapter("Select * From public.user where login = @LOGIN and password = @PASSWORD", connection))
            //{
            command = new NpgsqlCommand("Select * From public.user where login = @LOGIN and password = md5(@PASSWORD)", connection);
            command.Parameters.Add(login);
            command.Parameters.Add(password);

            tbllogin = new DataTable();
            
            adapter = new NpgsqlDataAdapter(command);
            adapter.Fill(tbllogin);
            //lb.DataSource = tbllogin;
            //lb.DisplayMember = "login";
            //lb.ValueMember = "id";
            MessageBox.Show(tbllogin.Rows.Count.ToString());
            if (tbllogin.Rows.Count==1)
            {
                return true;
            }
            else
            {
                return false;
            }
            
            //}
        }
                

    }
}

