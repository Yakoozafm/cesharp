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
        public static DataTable tbllogin;
        public static DataTable tblEszkoz;
        public static DataTable tblFelelos;
        public static DataTable tblForras;
        public static DataTable tblIrany;
        public static DataTable tblIskola;
        public static DataTable tblMegnevezes;
        public static DataTable tblMozgas;
        public static DataTable tblNaplo;
        public static DataTable tblOprendszer;
        public static DataTable tblTarhely;
        public static DataTable tblTechnologia;

        static NpgsqlCommand command;
        static string connectionString = ConfigurationManager.ConnectionStrings["taszimozgasCS"].ConnectionString;
        static string connectionString2 = ConfigurationManager.ConnectionStrings["taszimozgasCSt"].ConnectionString;

        //Helyi ip cím lekérése
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

        
        public static bool Login(String str_login, String str_password)
            {
            connection = new NpgsqlConnection(connectionString);

            try
            {
                connection.Open();
            }
            catch (System.TimeoutException)
            {

                //MessageBox.Show("A szerver nem elérhető");
                connection.Close();
                connection = null;
                connection = new NpgsqlConnection(connectionString2);
            

                try
                {
                    connection.Open();
                }
                catch (System.TimeoutException)
                {
                    MessageBox.Show("Nincsenek szerverek.\nKilépés","Végzetes hiba");
                    Environment.Exit(1);
                }
                catch
                {
                    MessageBox.Show("Minden szerver leállt. \nKilépés.", "Végzetes hiba");
                    Environment.Exit(1);
                }
            }

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

        //Naplózás
        public static void logol()
        {
            command = new NpgsqlCommand("insert into public.naplo (juser) values (@LOGNAME)", connection);
            NpgsqlParameter logname = new NpgsqlParameter("LOGNAME", DbType.Int32);
            //NpgsqlParameter ip = new NpgsqlParameter("IP", DbType.String);
            //NpgsqlParameter idopont = new NpgsqlParameter("IDOPONT", DbType.Date);

            logname.Value = Convert.ToInt32(userid);
            //ip.Value = ipk;
            //DateTime most = DateTime.Now;
            //idopont.Value = most;

            command.Parameters.Add(logname);
            //command.Parameters.Add(ip);
            //command.Parameters.Add(idopont);
            


            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            
            command.ExecuteNonQuery();
        }

        public static void Kapcs_Eszkoz()
        {
            string sql = "Select * from eszkoz";
            command = new NpgsqlCommand(sql, connection);
            adapter = new NpgsqlDataAdapter(command);
            tblEszkoz = new DataTable();
            adapter.Fill(tblEszkoz);

        }
    }
}

