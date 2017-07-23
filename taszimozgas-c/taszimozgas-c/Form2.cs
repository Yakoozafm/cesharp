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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Helló!","Üzenet ablak",MessageBoxButtons.YesNoCancel);
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Módosítás");
            if (panel1.Width != 75)
            {
                string source = "Hello World!";
                using (MD5 md5Hash = MD5.Create())
                {
                    string hash = GetMd5Hash(md5Hash, source);

                    Console.WriteLine("The MD5 hash of " + source + " is: " + hash + ".");
                    panel1.Width = 75;
                    listBox1.Left = 75;
                    listBox1.Top = 0;
                }
            }
            else
            {
                panel1.Width = panel1.PreferredSize.Width;
                listBox1.Left = panel1.Width;
                listBox1.Top = 0;
            }

            }
        

        private void Form2_Resize(object sender, EventArgs e)
        {
            button3_Click(null,null);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            button3_Click(null,null);
        }

            static string GetMd5Hash(MD5 md5Hash, string input)
            {

                // Convert the input string to a byte array and compute the hash.
                byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

                // Create a new Stringbuilder to collect the bytes
                // and create a string.
                StringBuilder sBuilder = new StringBuilder();

                // Loop through each byte of the hashed data 
                // and format each one as a hexadecimal string.
                for (int i = 0; i < data.Length; i++)
                {
                    sBuilder.Append(data[i].ToString("x2"));
                }

                // Return the hexadecimal string.
                return sBuilder.ToString();
            }
        }
}
