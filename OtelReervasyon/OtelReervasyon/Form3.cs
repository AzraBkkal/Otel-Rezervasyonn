using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtelReervasyon
{
    public partial class Form3 : Form
    {

        private dbBaglatnı db = new dbBaglatnı();
        public Form3()
        {
            InitializeComponent();
        }

        private void btnREZERVASYON_Click(object sender, EventArgs e)
        {

            try
            {

                string müsteriAdSoyad = txtAD.Text;
                string müsteriTelefon = txtTEL.Text;
                DateTime girisTarihi = dateGİRİS.Value;
                DateTime cikisTarihi = dateCIKIS.Value;
                string odaTipi = comboODA.SelectedItem.ToString();


                if (odaTipi == null)
                {
                    MessageBox.Show("Lütfen oda tipi seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                
                string query = "INSERT INTO rezervasyon (müsteriAdSoyad, müsteriTelefon, girisTarihi, cikisTarihi, odaTipi) " +
                               "VALUES (@müsteriAdSoyad, @müsteriTelefon, @girisTarihi, @cikisTarihi, @odaTipi)";
                using (MySqlConnection baglanti = db.baglantiGetir())
                {
                    if (baglanti.State != System.Data.ConnectionState.Open)
                    {
                        baglanti.Open();
                    }
                    
                    MySqlCommand cmd = new MySqlCommand(query, baglanti);

                    
                    cmd.Parameters.AddWithValue("@müsteriAdSoyad", müsteriAdSoyad);
                    cmd.Parameters.AddWithValue("@müsteriTelefon", müsteriTelefon);
                    cmd.Parameters.AddWithValue("@girisTarihi", girisTarihi);
                    cmd.Parameters.AddWithValue("@cikisTarihi", cikisTarihi);
                    cmd.Parameters.AddWithValue("@odaTipi", odaTipi);

                    
                    
                    cmd.ExecuteNonQuery();

                    
                    MessageBox.Show("Rezervasyon başarılı bir şekilde kaydedildi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           








        }

        private void btnANAMENU_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();              
            this.Close();
        }
    }
}
