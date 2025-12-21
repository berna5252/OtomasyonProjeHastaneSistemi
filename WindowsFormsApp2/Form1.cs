using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        private string connectionString;


        public Form1()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["HastaneOtomasyonuConnectionString"].ConnectionString;
        }

        private void btn_connection_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    if (connection.State == ConnectionState.Open)
                    {
                        MessageBox.Show("Lütfen bekleyiniz...", "Bağlantı Açık",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                Thread.Sleep(1000);
                form_user_login_cs form2 = new form_user_login_cs();
                this.Hide();
                form2.ShowDialog();
                this.Close();
               



            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata = " + ex);
            }

        }
    }
}  




      
