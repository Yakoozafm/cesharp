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
using System.Net;
using System.Net.Sockets;

namespace taszimozgas_c
{
    class DB
    {
        public static bool Belepve = false;
        public static string LogName ="";
        public static Boolean AdminUser = false;
        public static int userid = -1;
        public static string ipk;

        static NpgsqlConnection connection;
        static NpgsqlDataAdapter adapter;
        static DataTable tbllogin;
        static NpgsqlCommand command;
        static string connectionString = ConfigurationManager.ConnectionStrings["taszimozgasCS"].ConnectionString;

        public static void GetLocalIPAddress()
        {
            ipk = "";
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    ipk += ip.ToString() + "---";
                }
            }
        }

        public static void Kapcsolodas()
        {
            //using (connection = new NpgsqlConnection(connectionString))
            
            //{
               
            //}
        }
        public static bool Login(String str_login, String str_password)
            {
            connection = new NpgsqlConnection(connectionString);
            NpgsqlParameter login = new NpgsqlParameter("LOGIN",DbType.String);
            NpgsqlParameter password = new NpgsqlParameter("PASSWORD", DbType.String);
            login.Value = str_login;
            password.Value = str_password;

            command = new NpgsqlCommand("Select * From public.user where login = @LOGIN and password = md5(@PASSWORD)", connection);
            command.Parameters.Add(login);
            command.Parameters.Add(password);
            tbllogin = new DataTable();
            
            adapter = new NpgsqlDataAdapter(command);
            adapter.Fill(tbllogin);
            
            if (tbllogin.Rows.Count==1)
            {

                
                DataRow dr = tbllogin.Rows[0];
                if (Convert.ToBoolean(dr["engedve"]))
                {
                    AdminUser = Convert.ToBoolean(dr["admin"]);
                    Belepve = true;
                    LogName = login.Value.ToString();
                    userid = Convert.ToInt32(dr["id"]);
                    logol();
                    return true;
                }
                else
                {
                    MessageBox.Show("Zárolt felhasználó, nem léphet be.","Engedély megtagadva.", MessageBoxButtons.OK);
                    return false;
                }
            }
            else
            {
                Belepve = false;
                return false;
            }
        }
        public static void logol()
        {
            command = new NpgsqlCommand("insert into public.naplo (juser, ip, idopont) values (@LOGNAME, @IP, @IDOPONT)", connection);
            NpgsqlParameter logname = new NpgsqlParameter("LOGNAME", DbType.Int32);
            NpgsqlParameter ip = new NpgsqlParameter("IP", DbType.String);
            NpgsqlParameter idopont = new NpgsqlParameter("IDOPONT", DbType.Date);

            logname.Value = Convert.ToInt32(userid);
            ip.Value = ipk;
            DateTime most = DateTime.Now;
            idopont.Value = most;

            command.Parameters.Add(logname);
            command.Parameters.Add(ip);
            command.Parameters.Add(idopont);
            


            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            
            command.ExecuteNonQuery();
        }
    }
}

