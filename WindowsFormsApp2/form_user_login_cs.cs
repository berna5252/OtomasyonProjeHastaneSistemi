using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;


namespace WindowsFormsApp2
{
    public partial class form_user_login_cs : Form

    {


        private string connectionString;
        public form_user_login_cs()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["HastaneOtomasyonuConnectionString"].ConnectionString;
        }
       




        private void form_user_login_cs_Load(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                // Hastalar
                string query = "SELECT hasta_id, ad_soyad FROM tablo_hastalar";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cmb_hasta.DataSource = dt;
                cmb_hasta.DisplayMember = "ad_soyad";
                cmb_hasta.ValueMember = "hasta_id";

                string query2 = "SELECT doktor_id, ad_soyad FROM tablo_doktorlar";
                SqlDataAdapter da2 = new SqlDataAdapter(query2, conn);
                DataTable dt2 = new DataTable();
                da2.Fill(dt2);
                cmb_doktor.DataSource = dt2;  
                cmb_doktor.DisplayMember = "ad_soyad";
                cmb_doktor.ValueMember = "doktor_id";

               
                cmb_durum.Items.Clear();
                cmb_durum.Items.Add("Aktif");
                cmb_durum.Items.Add("İptal");
                cmb_durum.Items.Add("Onay bekliyor");
            }

            cmb_hasta.SelectedIndex = -1;
            cmb_doktor.SelectedIndex = -1;
            cmb_durum.SelectedIndex = -1;
        }
   


     


















        private void btn_save_Click(object sender, EventArgs e)
        {

            if (cmb_hasta.SelectedValue == null || cmb_doktor.SelectedValue == null || cmb_durum.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz!");
                return;
            }

            int hasta_id = Convert.ToInt32(cmb_hasta.SelectedValue);
            int doktor_id = Convert.ToInt32(cmb_doktor.SelectedValue);
            DateTime r_tarih = dtp_randevutarihi.Value;
            string r_durum = cmb_durum.Text;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("sp_tablo_randevular_insert_into", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@hasta_id", hasta_id);
                        cmd.Parameters.AddWithValue("@doktor_id", doktor_id);
                        cmd.Parameters.AddWithValue("@randevu_tarihi", r_tarih);
                        cmd.Parameters.AddWithValue("@durum", r_durum);

                        connection.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Randevu başarıyla oluşturuldu!");
                        Listele();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

    



       
        private void btn_select_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
              
                    using (SqlCommand cmd = new SqlCommand("sp_tablo_randevu_select", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                     
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();

                    
                        connection.Open();
                        da.Fill(dt);

                        dataGridView1.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata = " + ex.Message);
            }
        }



        private void btn_delete_Click(object sender, EventArgs e)
        {

            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Lütfen listeden silinecek bir kayıt seçiniz!");
                return;
            }

            try
            {
                int selectedRowId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ID"].Value);
                MessageBox.Show("Bu randevu kaydını silmek istediğinize emin misiniz?");


                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("sp_tablo_randevu_delete", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                      
                        cmd.Parameters.AddWithValue("@randevu_id", selectedRowId);

                        connection.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Kayıt başarıyla silindi!");
                        Listele();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Silme hatası: " + ex.Message);
            }
        }



        public void Listele()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                
                    string query = "SELECT * FROM tablo_randevular";
                    SqlDataAdapter da = new SqlDataAdapter(query, connection);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Listeleme hatası: " + ex.Message);
            }
        }

        private void btn_starting_update_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                string r_tarih = selectedRow.Cells[1].Value.ToString();
                string r_durum = selectedRow.Cells[2].Value.ToString();
                string r_hasta = selectedRow.Cells[3].Value.ToString();
                string  r_tc = selectedRow.Cells[4].Value.ToString();
                string r_doktor = selectedRow.Cells[5].Value.ToString();
                try
                {
                    dtp_randevutarihi.Text = r_tarih;
                    cmb_durum.Text = r_durum;
                    cmb_hasta.Text = r_hasta;
                    txt_tc.Text = r_tc;
                    cmb_doktor.Text = r_doktor;
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Aktarma işlemi esnasında hata oluştu: " + ex.Message);
                }





            }
            else
            {
                MessageBox.Show("Lütfen, güncellemek için bir kayıt seçiniz");
            }


        }






        private void btn_update_Click(object sender, EventArgs e)
        {
            int selected_ID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
            string r_tarih = dtp_randevutarihi.Value.ToString("yyyy-MM-dd HH:mm:ss.s");
            string r_durum = cmb_durum.Text;




            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("sp_tablo_randevular_update", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@randevu_id", selected_ID);
                        cmd.Parameters.AddWithValue("@yeni_tarih", r_tarih);
                        cmd.Parameters.AddWithValue("@yeni_durum", r_durum);



                        connection.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Randevu kaydı başarıyla güncellendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        txt_tc.Clear();
                        dtp_randevutarihi.Format = DateTimePickerFormat.Custom;
                        dtp_randevutarihi.CustomFormat = " ";
                        cmb_hasta.SelectedIndex = -1;
                        cmb_durum.SelectedIndex = -1;
                        cmb_doktor.SelectedIndex = -1;





                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Güncelleme işlemi esnasında hata oluştu: " + ex.Message);
            }

        }
    }
}



