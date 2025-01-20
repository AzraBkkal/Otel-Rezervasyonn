

using MySql.Data.MySqlClient;
using System.Data;
namespace OtelReervasyon

{
    public partial class Form1 : Form

    {
        private readonly Image[] images = {
        Properties.Resources.Ekran_görüntüsü_2025_01_10_193211,
        Properties.Resources.Ekran_görüntüsü_2025_01_10_193308,
        Properties.Resources.Ekran_görüntüsü_2025_01_10_193354,

         };
        private int currentImageIndex = 0;
        private readonly dbBaglatný dbBaglanti = new dbBaglatný();
        public Form1()
        {
            InitializeComponent();
            timer1.Interval = 2000;
            timer1.Tick += timer1_Tick;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            currentImageIndex = (currentImageIndex + 1) % images.Length;
            pictureBox1.Image = images[currentImageIndex];
        }

        private void button1_Click(object sender, EventArgs e)
        {


            try
            {
                using (MySqlConnection baglanti = dbBaglanti.baglantiGetir())
                {
                    string kullaniciAdi = txtAD.Text;
                    string sifre = txtSÝFRE.Text;

                    string query = "SELECT * FROM yonetici WHERE kullanici_adi = @kullanici_adi AND sifre = @sifre";
                    MySqlCommand komut = new MySqlCommand(query, baglanti);
                    komut.Parameters.AddWithValue("@kullanici_adi", kullaniciAdi);
                    komut.Parameters.AddWithValue("@sifre", sifre);

                    using (MySqlDataReader okuyucu = komut.ExecuteReader())
                    {
                        if (okuyucu.Read())
                        {
                            this.Hide();
                            Form2 yeniForm = new Form2();
                            yeniForm.Show();
                        }
                        else
                        {
                            MessageBox.Show("Kullanýcý adý veya þifre hatalý.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}", "Baðlantý Hatasý", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



    }
}


     