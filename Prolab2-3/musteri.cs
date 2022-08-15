using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace Prolab2_3
{   
   
    public partial class musteri : Form
    {
        MySqlConnection baglanti;
        MySqlCommand komut;
        MySqlDataAdapter da;
        public musteri()
        {
            InitializeComponent();
        }
        public musteri(string value)
        {  
            Value = value;
            InitializeComponent();
           
        }

        void MusteriGetir()
        {
            int id = Convert.ToInt32(Value);
            
            baglanti = new MySqlConnection("Server=localhost; Database=bank; Uid=root; Pwd=20012001");
            baglanti.Open();
            komut = new MySqlCommand("SELECT * FROM bank.musteri WHERE ID = '" + id + "'", baglanti);
            komut.ExecuteNonQuery();
            MySqlDataReader oku;
            oku = komut.ExecuteReader();
            while (oku.Read())
            {

                txtmusteri_no.Text = oku["ID"].ToString();
                txtmusteri_ad.Text = oku["AD"].ToString();
                txtmusteri_soyad.Text = oku["SOYAD"].ToString();
                txtmusteri_tc.Text = oku["TC"].ToString();
                txtmusteri_sifre.Text = oku["SIFRE"].ToString();
                txtmusteri_eposta.Text = oku["EPOSTA"].ToString();
                txtmusteri_adres.Text = oku["ADRES"].ToString();
                txtmusteri_tel.Text = oku["TELEFON"].ToString();
                musteri_id= oku["ID"].ToString();

            }
            oku.Close();
            baglanti.Close();

        }

        void HesapGetir()
        {
            int id = Convert.ToInt32(musteri_id);
            baglanti = new MySqlConnection("Server=localhost; Database=bank; Uid=root; Pwd=20012001");
            baglanti.Open();
            da = new MySqlDataAdapter("SELECT * FROM bank.hesap WHERE MUSTERI_ID= '"+id+"'", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();

        }

        void DovizHesapGetir()
        {
            int id = Convert.ToInt32(Value);
            baglanti = new MySqlConnection("Server=localhost; Database=bank; Uid=root; Pwd=20012001");
            baglanti.Open();
            da = new MySqlDataAdapter("SELECT * FROM bank.doviz_hesap WHERE ID= '" + id + "'", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView3.DataSource = tablo;
            baglanti.Close();

        }

        void DovizGetir()
        {
            int id = Convert.ToInt32(musteri_id);
            baglanti = new MySqlConnection("Server=localhost; Database=bank; Uid=root; Pwd=20012001");
            baglanti.Open();
            da = new MySqlDataAdapter("SELECT DOVIZ_ISIM,DOVIZ_ALIS,DOVIZ_SATIS FROM bank.doviz", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView2.DataSource = tablo;
            baglanti.Close();

        }

        void ToplamPara()
        {
            int id = Convert.ToInt32(musteri_id);
            baglanti = new MySqlConnection("Server=localhost; Database=bank; Uid=root; Pwd=20012001");
            baglanti.Open();
            komut = new MySqlCommand("SELECT SUM(BAKIYE) AS toplam FROM bank.hesap WHERE MUSTERI_ID = '" + id + "'", baglanti);
            komut.ExecuteNonQuery();
            MySqlDataReader oku;
            oku = komut.ExecuteReader();
            while (oku.Read())
            {
                toplam_para_txt.Text= oku["toplam"].ToString();


            }
            oku.Close();
            baglanti.Close();
        }


        public string Value { get; set; }
        public string musteri_id { get; set; }


        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MusteriGetir();
        }

      

        private void label1_Click(object sender, EventArgs e)
        {

        }

       


   
        private void Bilgi_Goruntule_Click(object sender, EventArgs e)
        {
            panel3.Height = Bilgi_Goruntule.Height;
            panel3.Top = Bilgi_Goruntule.Top;
            bilgi_panel.Visible = true;
            para_islem_panel.Visible = false;
            doviz_panel.Visible = false;
            MusteriGetir();
           


        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            new Giris().Show();
            this.Hide();
        }           
     


        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();

        }

        

        private void txtmusteri_no_TextChanged(object sender, EventArgs e)
        {
     
        }

        private void txtmusteri_ad_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtmusteri_soyad_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtmusteri_tc_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtmusteri_eposta_TextChanged(object sender, EventArgs e)
        {
        }

        private void musteri_guncelle_Click(object sender, EventArgs e)
        {
            MySqlConnection baglanti = new MySqlConnection("Server=localhost; Database=bank; Uid=root; Pwd=20012001");

            string sorgu = "UPDATE bank.musteri SET AD=@ad,SOYAD=@soyad,SIFRE=@sifre,TELEFON=@telefon,TC=@tc,ADRES=@adres,EPOSTA=@eposta WHERE ID=@id";
            komut = new MySqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@id", Convert.ToInt32(txtmusteri_no.Text));
            komut.Parameters.AddWithValue("@ad", txtmusteri_ad.Text);
            komut.Parameters.AddWithValue("@soyad", txtmusteri_soyad.Text);
            komut.Parameters.AddWithValue("@tc", Convert.ToInt64(txtmusteri_tc.Text));
            komut.Parameters.AddWithValue("@sifre", Convert.ToInt64(txtmusteri_sifre.Text));
            komut.Parameters.AddWithValue("@eposta", txtmusteri_eposta.Text);
            komut.Parameters.AddWithValue("@adres", txtmusteri_adres.Text);
            komut.Parameters.AddWithValue("@telefon", Convert.ToInt64(txtmusteri_tel.Text));
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            MusteriGetir();
            MessageBox.Show("Başarıyla Güncellendi");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            para_hesap_no.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            para_bakiye.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();

            doviz_hesap_no.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            doviz_bky.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();

        }

        private void toplam_para_Click(object sender, EventArgs e)
        {

        }

        private void hesap_olustur_button_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Value);
            try
            {
                MySqlConnection baglanti = new MySqlConnection("Server=localhost; Database=bank; Uid=root; Pwd=20012001");

                string Query = "insert into bank.talepler(TALEP_TURU,GONDEREN_HESAP_NO,TALEP_DURUM) values('" + "hesap acma" + "','" + id + "','" + "beklemede" + "');";//,'" + id + "'

                MySqlCommand MyCommand2 = new MySqlCommand(Query, baglanti);
                MySqlDataReader MyReader2;
                baglanti.Open();
                MyReader2 = MyCommand2.ExecuteReader();  

                while (MyReader2.Read())
                {
                }
                baglanti.Close();
                MessageBox.Show("Hesap Açma Talebiniz Gönderildi.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void kredi_basvuru_button_Click(object sender, EventArgs e)
        {
            if(para_hesap_no.Text == "")
            {
                MessageBox.Show("Hesabınız Seçili Olmadığından İşlem Yapılamıyor");
            }
            else
            {
                 int hesap_no = Convert.ToInt32(para_hesap_no.Text);
                new para_islem(5, hesap_no).ShowDialog();
                HesapGetir();
            }
    
        }

        private void havale_button_Click(object sender, EventArgs e)
        {
            if (para_hesap_no.Text == "")
            {
                MessageBox.Show("Hesabınız Seçili Olmadığından İşlem Yapılamıyor");
            }
            else
            {
                int hesap_no = Convert.ToInt32(para_hesap_no.Text);
                new para_islem(4,hesap_no).ShowDialog();
                HesapGetir();
            }

                

        }

        private void para_yükle_button_Click(object sender, EventArgs e)
        {
            if (para_hesap_no.Text == "")
            {
                MessageBox.Show("Hesabınız Seçili Olmadığından İşlem Yapılamıyor");
            }
            else
            {
                int hesap_no = Convert.ToInt32(para_hesap_no.Text);
                new para_islem(1,hesap_no).ShowDialog();
                HesapGetir();
            }
              

        }

        private void para_cek_button_Click(object sender, EventArgs e)
        {
            if (para_hesap_no.Text == "")
            {
                MessageBox.Show("Hesabınız Seçili Olmadığından İşlem Yapılamıyor");
            }
            else
            {
                int hesap_no = Convert.ToInt32(para_hesap_no.Text);
                new para_islem(2,hesap_no).ShowDialog();
                HesapGetir();
            }
        }

        private void kredi_ödeme_button_Click(object sender, EventArgs e)
        {
            if (para_hesap_no.Text == "")
            {
                MessageBox.Show("Hesabınız Seçili Olmadığından İşlem Yapılamıyor");
            }
            else
            {
               int hesap_no = Convert.ToInt32(para_hesap_no.Text);
               new para_islem(3,hesap_no).ShowDialog();
               HesapGetir();
            }
        }
        public string Bakiye { get; set; }
       
        void bakiye()
        {
            int hesap_no = Convert.ToInt32(para_hesap_no.Text);

            baglanti = new MySqlConnection("Server=localhost; Database=bank; Uid=root; Pwd=20012001");
            baglanti.Open();
            komut = new MySqlCommand("SELECT * FROM bank.hesap WHERE HESAP_NO = '" + hesap_no + "'", baglanti);
            komut.ExecuteNonQuery();
            MySqlDataReader oku;
            oku = komut.ExecuteReader();
            while (oku.Read())
            {
                Bakiye = oku["BAKIYE"].ToString();
            }
            oku.Close();
            baglanti.Close();
        }


        private void hesap_sil_talep_Click_1(object sender, EventArgs e)
        {
            if (para_hesap_no.Text == "")
            {
                MessageBox.Show("Hesabınız Seçili Olmadığından İşlem Yapılamıyor");
            }
            else
            {
                bakiye();

                if (Bakiye == "0")
                {
                    string sorgu = "DELETE FROM bank.hesap WHERE HESAP_NO = @id";
                    komut = new MySqlCommand(sorgu, baglanti);
                    komut.Parameters.AddWithValue("@id", Convert.ToInt32(para_hesap_no.Text));
                    baglanti.Open();
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("Hesabınız başarıyla silinmiştir");

                    HesapGetir();
                }
                else
                    MessageBox.Show("Hesap Bakiyeniz Sıfır Olmadan" + "\n" + "Hesabınız Silinemez");
                }
        }

        
        private void doviz_islemleri_button_Click(object sender, EventArgs e)
        {
            panel3.Height = doviz_islemleri_button.Height;
            panel3.Top = doviz_islemleri_button.Top;
            para_islem_panel.Visible = true;
            bilgi_panel.Visible = false;
            doviz_panel.Visible = true;
            HesapGetir();
            DovizGetir();
            DovizHesapGetir();

        }


      

        private void dataGridView2_CellEnter_1(object sender, DataGridViewCellEventArgs e)
        {
            doviz_isim.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            doviz_alis.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            doviz_satis.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
        }

        public string Doviz_istenen { get; set; }

        void dovizMikar(string istenen)
        {
            int id = Convert.ToInt32(Value);

            baglanti = new MySqlConnection("Server=localhost; Database=bank; Uid=root; Pwd=20012001");
            baglanti.Open();
            komut = new MySqlCommand("SELECT "+istenen+ " AS istenen FROM bank.doviz_hesap  WHERE ID = '" + id + "'", baglanti);
            komut.ExecuteNonQuery();
            MySqlDataReader oku;
            oku = komut.ExecuteReader();
            while (oku.Read())
            {

               Doviz_istenen = oku["istenen"].ToString();

            }
            oku.Close();
            baglanti.Close();
        }


        private void doviz_button_Click_1(object sender, EventArgs e)
        {
            double alis = Convert.ToDouble(doviz_alis.Text);
            double satis = Convert.ToDouble(doviz_satis.Text);

            double alinacak_doviz = Convert.ToInt64(doviz_al_txt.Text)*satis;

            double bakiye = Convert.ToDouble(doviz_bky.Text);

            dovizMikar(doviz_isim.Text);

            int doviz_bakiye = Convert.ToInt32(Doviz_istenen);

            if (alinacak_doviz > bakiye)
            {
                MessageBox.Show("Bakiyeniz Yetersiz");
            }
            else
            {
                try
                {
                    MySqlConnection baglanti = new MySqlConnection("Server=localhost; Database=bank; Uid=root; Pwd=20012001");
                    string isim = doviz_isim.Text;

                    string sorgu = "UPDATE bank.doviz_hesap SET "+isim+"=@miktar WHERE ID=@id;";
                    komut = new MySqlCommand(sorgu, baglanti);

                    komut.Parameters.AddWithValue("@id", Convert.ToInt32(Value));
                    komut.Parameters.AddWithValue("@miktar", Convert.ToInt32(doviz_al_txt.Text)+ doviz_bakiye);
                   
                    baglanti.Open();
                    komut.ExecuteNonQuery();
                    baglanti.Close();

                   
                    sorgu = "UPDATE bank.hesap SET BAKIYE=@bakiye WHERE HESAP_NO=@hesap_no;";
                    komut = new MySqlCommand(sorgu, baglanti);
                    komut.Parameters.AddWithValue("@bakiye", bakiye-alinacak_doviz);
                    komut.Parameters.AddWithValue("@hesap_no", Convert.ToInt32(doviz_hesap_no.Text));
                    baglanti.Open();
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("Başarıyla İşlem Gerçekleşti");
                    HesapGetir();
                    DovizGetir();
                    DovizHesapGetir();


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
       
        }

        private void doviz_sat_button_Click_1(object sender, EventArgs e)
        {
            double alis = Convert.ToDouble(doviz_alis.Text);
            double satis = Convert.ToDouble(doviz_satis.Text);

            double satilacak_doviz = Convert.ToInt64(doviz_sat_txt.Text) * alis;

            double bakiye = Convert.ToDouble(doviz_bky.Text);

            dovizMikar(doviz_isim.Text);

            int doviz_bakiye = Convert.ToInt32(Doviz_istenen);

            
          
                try
                {
                    MySqlConnection baglanti = new MySqlConnection("Server=localhost; Database=bank; Uid=root; Pwd=20012001");
                    string isim = doviz_isim.Text;

                    string sorgu = "UPDATE bank.doviz_hesap SET " + isim + "=@miktar WHERE ID=@id;";
                    komut = new MySqlCommand(sorgu, baglanti);

                    komut.Parameters.AddWithValue("@id", Convert.ToInt32(Value));
                    komut.Parameters.AddWithValue("@miktar",doviz_bakiye-Convert.ToInt32(doviz_sat_txt.Text));

                    baglanti.Open();
                    komut.ExecuteNonQuery();
                    baglanti.Close();


                    sorgu = "UPDATE bank.hesap SET BAKIYE=@bakiye WHERE HESAP_NO=@hesap_no;";
                    komut = new MySqlCommand(sorgu, baglanti);
                    komut.Parameters.AddWithValue("@bakiye",satilacak_doviz + bakiye );
                    komut.Parameters.AddWithValue("@hesap_no", Convert.ToInt32(doviz_hesap_no.Text));
                    baglanti.Open();
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("Başarıyla İşlem Gerçekleşti");
                    HesapGetir();
                    DovizGetir();
                    DovizHesapGetir();


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            
        }


        private void dataGridView3_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void para_islem_button_Click(object sender, EventArgs e)
        {
            panel3.Height = para_islem_button.Height;
            panel3.Top = para_islem_button.Top;
            para_islem_panel.Visible = true;
            bilgi_panel.Visible = false;
            doviz_panel.Visible = false;
            para_no.Text = txtmusteri_no.Text;
            para_ad.Text = txtmusteri_ad.Text;
            para_soyad.Text = txtmusteri_soyad.Text;
            HesapGetir();
            ToplamPara();
        }
    }
}
