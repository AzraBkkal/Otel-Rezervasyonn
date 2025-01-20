using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace OtelReervasyon
{
    public partial class Form2 : Form
    {
        private dbBaglatnı db = new dbBaglatnı();

        public Form2()
        {
            InitializeComponent();
            {



            }

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            listBox1.Visible = false;
        }

        private void btnREZERVASYON_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();

        }

        private void btnMUSTERİBİLGİLERİ_Click(object sender, EventArgs e)
        {
           using (MySqlConnection connection = db.baglantiGetir())
            {
                listBox1.Visible = true;
                listBox1.Items.Clear();
                
                
                    try
                    {
                        

                        string query = "SELECT rezervasyon_id, müsteriAdSoyad, müsteriTelefon, girisTarihi, cikisTarihi, odaTipi FROM rezervasyon";
                        MySqlCommand cmd = new MySqlCommand(query, connection);

                        using (MySqlDataReader reader = cmd.ExecuteReader())



                            while (reader.Read())
                    {
                        string rezervasyonBilgisi = $"ID: {reader["rezervasyon_id"]}, " +
                                                    $"Müşteri: {reader["müsteriAdSoyad"]}, " +
                                                    $"Telefon: {reader["müsteriTelefon"]}, " +
                                                    $"Giriş: {reader["girisTarihi"]}, " +
                                                    $"Çıkış: {reader["cikisTarihi"]}, " +
                                                    $"Oda Tipi: {reader["odaTipi"]}";
                        listBox1.Items.Add(rezervasyonBilgisi);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir hata oluştu: " + ex.Message);
                }
                
            }





        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnFATURA_Click(object sender, EventArgs e)
        {  
            listBox1.Visible = true;
            listBox1.Items.Clear();


            using (MySqlConnection connection = db.baglantiGetir())
                
            {

              using (MySqlConnection baglantı= db.baglantiGetir())
                {
                    

                    string query = "SELECT müsteriAdSoyad, odaTipi, girisTarihi, cikisTarihi FROM rezervasyon";
                    MySqlCommand cmd = new MySqlCommand(query, connection);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        string müsteriAdSoyad = reader["müsteriAdSoyad"].ToString();
                        string odaTipi = reader["odaTipi"].ToString();
                        DateTime girisTarihi = Convert.ToDateTime(reader["girisTarihi"]);
                        DateTime cikisTarihi = Convert.ToDateTime(reader["cikisTarihi"]);

                        int gunSayisi = (cikisTarihi - girisTarihi).Days;
                        if (gunSayisi <= 0)
                        {
                            continue;
                        }

                        decimal odaFiyati = OdaFiyatiGetir(odaTipi);

                        decimal toplamTutar = gunSayisi * odaFiyati;

                        string rezervasyon = $"{müsteriAdSoyad} | {odaTipi} | Ücret: {toplamTutar:C}";
                        listBox1.Items.Add(rezervasyon);
                    }

                    reader.Close(); // Reader'ı kapatıyoruz
                    connection.Close(); // Bağlantıyı kapatıyoruz
                }


            }
        }

      
              private decimal OdaFiyatiGetir(string odaTipi)
              {
              decimal fiyat = 0;

   
               using (MySqlConnection connection = db.baglantiGetir())
               {
                  string query = "SELECT odaFiyat FROM oda WHERE OdaTipi = @OdaTipi";
                  MySqlCommand cmd = new MySqlCommand(query, connection);
        
          
                 cmd.Parameters.AddWithValue("@OdaTipi", odaTipi);  
              try
              {
            
             object result = cmd.ExecuteScalar();  

              if (result != null)
              {
                fiyat = Convert.ToDecimal(result);  
              }
            }
             catch (Exception ex)
            {
              MessageBox.Show("Veritabanı hatası: " + ex.Message);
             }
    }

            return fiyat;  
        }
    }

    
    

       
        
    
}
