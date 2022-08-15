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
    public partial class mudur : Form
    {
        MySqlConnection baglanti;
        MySqlCommand komut;
        MySqlDataAdapter da;
        public mudur()
        {
            InitializeComponent();
        }

        public mudur(string id)
        {
            InitializeComponent();
            ID = id;
        }

        public string ID { get; set; }


        private void guna2Button1_Click(object sender, EventArgs e)
        {
            new Giris().Show();
            this.Hide();
        }

        private void mudur_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();

        }

        void MusteriGetir()
        {
            baglanti = new MySqlConnection("Server=localhost; Database=bank; Uid=root; Pwd=20012001");
            baglanti.Open();
            da = new MySqlDataAdapter("SELECT * FROM bank.musteri", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();

        }

        void TemsilciGetir()
        {
            baglanti = new MySqlConnection("Server=localhost; Database=bank; Uid=root; Pwd=20012001");
            baglanti.Open();
            da = new MySqlDataAdapter("SELECT * FROM bank.musteri_temsilcisi", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView2.DataSource = tablo;
            baglanti.Close();

        }

        void TalepGetir()
        {
            baglanti = new MySqlConnection("Server=localhost; Database=bank; Uid=root; Pwd=20012001");
            baglanti.Open();
            da = new MySqlDataAdapter("SELECT * FROM bank.talepler", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView4.DataSource = tablo;
            baglanti.Close();

        }

        private void musteri_guncelle_button_Click(object sender, EventArgs e)
        {
            string sorgu = "UPDATE bank.musteri SET AD=@ad,SOYAD=@soyad,SIFRE=@sifre,TELEFON=@telefon,TC=@tc,ADRES=@adres,EPOSTA=@adres WHERE ID=@id";
            komut = new MySqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@id", Convert.ToInt32(txtmusteri_no.Text));
            komut.Parameters.AddWithValue("@ad", txtmusteri_ad.Text);
            komut.Parameters.AddWithValue("@soyad", txtmusteri_soyad.Text);
            komut.Parameters.AddWithValue("@tc", Convert.ToInt64(txtmusteri_tc.Text));
            komut.Parameters.AddWithValue("@sifre", Convert.ToInt64(txtmusteri_sifre.Text));
            komut.Parameters.AddWithValue("@eposta", txtmusteri_eposta.Text);
            komut.Parameters.AddWithValue("@adres", txtmusteri_adres.Text);
            komut.Parameters.AddWithValue("@telefon", Convert.ToUInt64(txtmusteri_tel.Text));
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            MusteriGetir();
            MessageBox.Show("Başarıyla Güncellendi");
        }

        private void musteri_ekle_button_Click(object sender, EventArgs e)
        {
            new Kayit().ShowDialog();
            MusteriGetir();
        }

        private void müsteri_sil_button_Click(object sender, EventArgs e)
        {
            string sorgu = "DELETE FROM bank.musteri WHERE ID = @id";
            komut = new MySqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@id", Convert.ToInt32(txtmusteri_no.Text));
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            MusteriGetir();
        }

        private void musteri_bilgi_Click(object sender, EventArgs e)
        {
            panel3.Height = musteri_bilgi.Height;
            panel3.Top = musteri_bilgi.Top;
            musteri_panel.Visible = true;
            temsilci_panel.Visible = false;
            kullanici_bilgi_panel.Visible = false;
            banka_bilgi_panel.Visible = false;
            para_birimleri_panel.Visible = false;
            talep_panel.Visible = false;


            MusteriGetir();
        }

        private void mudur_Load(object sender, EventArgs e)
        {
          
        }

        private void musteri_ekle_button_Click_1(object sender, EventArgs e)
        {
            new Kayit().ShowDialog();
            MusteriGetir();

        }

        private void temsilci_bilgi_button_Click(object sender, EventArgs e)
        {
            panel3.Height = temsilci_bilgi_button.Height;
            panel3.Top = temsilci_bilgi_button.Top;
            musteri_panel.Visible = false;
            temsilci_panel.Visible = true;
            kullanici_bilgi_panel.Visible = false;
            banka_bilgi_panel.Visible = false;
            para_birimleri_panel.Visible = false;
            talep_panel.Visible = false;



            TemsilciGetir();
        }

        private void dataGridView2_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            temsilci_no.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            temsilci_ad.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            temsilci_soyad.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
            temsilci_sifre.Text = dataGridView2.CurrentRow.Cells[3].Value.ToString();
            temsilci_tel.Text = dataGridView2.CurrentRow.Cells[4].Value.ToString();
            temsilci_tc.Text = dataGridView2.CurrentRow.Cells[5].Value.ToString();
            temsilci_eposta.Text = dataGridView2.CurrentRow.Cells[6].Value.ToString();
            temsilci_adres.Text = dataGridView2.CurrentRow.Cells[7].Value.ToString();
        }

        private void dataGridView1_CellEnter_1(object sender, DataGridViewCellEventArgs e)
        {
            txtmusteri_no.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtmusteri_ad.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtmusteri_soyad.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtmusteri_sifre.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtmusteri_tel.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtmusteri_tc.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtmusteri_adres.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            txtmusteri_eposta.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
        }

        private void musteri_guncelle_button_Click_1(object sender, EventArgs e)
        {
            string sorgu = "UPDATE bank.musteri SET AD=@ad,SOYAD=@soyad,SIFRE=@sifre,TELEFON=@telefon,TC=@tc,ADRES=@adres,EPOSTA=@eposta WHERE ID=@id";
            baglanti = new MySqlConnection("Server=localhost; Database=bank; Uid=root; Pwd=20012001");
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

        private void müsteri_sil_button_Click_1(object sender, EventArgs e)
        {
            string sorgu = "DELETE FROM bank.musteri WHERE ID = @id";
            baglanti = new MySqlConnection("Server=localhost; Database=bank; Uid=root; Pwd=20012001");
            komut = new MySqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@id", Convert.ToInt32(txtmusteri_no.Text));
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            MusteriGetir();
        }

        private void temsilci_guncelle_button_Click(object sender, EventArgs e)
        {
            string sorgu = "UPDATE bank.musteri_temsilcisi SET AD=@ad,SOYAD=@soyad,SIFRE=@sifre,TELEFON=@telefon,TC=@tc,EPOSTA=@eposta,ADRES=@adres WHERE ID=@id";
            baglanti = new MySqlConnection("Server=localhost; Database=bank; Uid=root; Pwd=20012001");
            komut = new MySqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@id", Convert.ToInt32(temsilci_no.Text));
            komut.Parameters.AddWithValue("@ad", temsilci_ad.Text);
            komut.Parameters.AddWithValue("@soyad", temsilci_soyad.Text);
            komut.Parameters.AddWithValue("@tc", Convert.ToInt64(temsilci_tc.Text));
            komut.Parameters.AddWithValue("@sifre", Convert.ToInt64(temsilci_sifre.Text));
            komut.Parameters.AddWithValue("@eposta", temsilci_eposta.Text);
            komut.Parameters.AddWithValue("@adres", temsilci_adres.Text);
            komut.Parameters.AddWithValue("@telefon", Convert.ToInt64(temsilci_tel.Text));
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Başarıyla Güncellendi");
            TemsilciGetir();
        }

        private void temsilci_ekle_button_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection baglanti = new MySqlConnection("Server=localhost; Database=bank; Uid=root; Pwd=20012001");
                string isim = doviz_isim.Text;
                string Query = "insert into bank.musteri_temsilcisi(AD,SOYAD,SIFRE,TC,TELEFON,EPOSTA,ADRES)  values('" + temsilci_ad.Text + "','" + temsilci_soyad.Text + "','" + Convert.ToInt64(temsilci_sifre.Text) + "','" + Convert.ToInt64(temsilci_tc.Text) + "','" + Convert.ToInt64(temsilci_tel.Text) + "','" + temsilci_eposta.Text + "','" + temsilci_adres.Text + "');";

                MySqlCommand MyCommand2 = new MySqlCommand(Query, baglanti);
                MySqlDataReader MyReader2;
                baglanti.Open();
                MyReader2 = MyCommand2.ExecuteReader();
                while (MyReader2.Read())
                {
                }
                baglanti.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            TemsilciGetir();
        }

        private void temsilci_sil_button_Click(object sender, EventArgs e)
        {
            string sorgu = "DELETE FROM bank.musteri_temsilcisi WHERE ID = @id";
            baglanti = new MySqlConnection("Server=localhost; Database=bank; Uid=root; Pwd=20012001");
            komut = new MySqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@id", Convert.ToInt32(temsilci_no.Text));
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            TemsilciGetir();

        }

        void KullaniciGetir()
        {

            int kullanici_id = Convert.ToInt32(ID);
            baglanti = new MySqlConnection("Server=localhost; Database=bank; Uid=root; Pwd=20012001");
            baglanti.Open();
            komut = new MySqlCommand("SELECT * FROM bank.mudur WHERE ID = " + kullanici_id + ";", baglanti);
            komut.ExecuteNonQuery();
            MySqlDataReader oku;
            oku = komut.ExecuteReader();
            while (oku.Read())
            {

                mudur_no.Text = oku["ID"].ToString();
                mudur_ad.Text = oku["AD"].ToString();
                mudur_soyad.Text = oku["SOYAD"].ToString();
                mudur_tc.Text = oku["TC"].ToString();
                mudur_tel.Text = oku["TELEFON"].ToString();
                mudur_eposta.Text = oku["EPOSTA"].ToString();
                mudur_adres.Text = oku["ADRES"].ToString();
                mudur_sifre.Text = oku["SIFRE"].ToString();
                

            }
            oku.Close();
            baglanti.Close();

        }

        void TemsilciSayi()
        {
            baglanti = new MySqlConnection("Server=localhost; Database=bank; Uid=root; Pwd=20012001");
            baglanti.Open();
            komut = new MySqlCommand("SELECT COUNT(ID) AS temsilciSayisi FROM bank.musteri_temsilcisi;", baglanti);
            komut.ExecuteNonQuery();
            MySqlDataReader oku;
            oku = komut.ExecuteReader();
            while (oku.Read())
            {
               temsilci_sayisi.Text = oku["temsilciSayisi"].ToString();            
            }
            oku.Close();
            baglanti.Close();
        }

        void MusteriSayi()
        {
            baglanti = new MySqlConnection("Server=localhost; Database=bank; Uid=root; Pwd=20012001");
            baglanti.Open();
            komut = new MySqlCommand("SELECT COUNT(ID) AS musteriSayisi FROM bank.musteri;", baglanti);
            komut.ExecuteNonQuery();
            MySqlDataReader oku;
            oku = komut.ExecuteReader();
            while (oku.Read())
            {
                musteri_sayisi.Text = oku["musteriSayisi"].ToString();
            }
            oku.Close();
            baglanti.Close();
        }

        void ToplamPara()
        {
            baglanti = new MySqlConnection("Server=localhost; Database=bank; Uid=root; Pwd=20012001");
            baglanti.Open();
            komut = new MySqlCommand("SELECT * FROM bank.banka_para;", baglanti);
            komut.ExecuteNonQuery();
            MySqlDataReader oku;
            oku = komut.ExecuteReader();
            while (oku.Read())
            {
                banka_no.Text = oku["banka_id"].ToString();
                toplam_para.Text = oku["BANKA_PARA"].ToString();
            }
            oku.Close();
            baglanti.Close();
        }

        void MudurMaas()
        {
            baglanti = new MySqlConnection("Server=localhost; Database=bank; Uid=root; Pwd=20012001");
            baglanti.Open();
            komut = new MySqlCommand("SELECT * FROM bank.maas WHERE BANKA_ROL='mudur';", baglanti);
            komut.ExecuteNonQuery();
            MySqlDataReader oku;
            oku = komut.ExecuteReader();
            while (oku.Read())
            {
                mudur_maas.Text = oku["MAAS"].ToString();
            }
            oku.Close();
            baglanti.Close();
        }

        void TemsilciMaas()
        {
            baglanti = new MySqlConnection("Server=localhost; Database=bank; Uid=root; Pwd=20012001");
            baglanti.Open();
            komut = new MySqlCommand("SELECT * FROM bank.maas WHERE BANKA_ROL='musteri_temsilci';", baglanti);
            komut.ExecuteNonQuery();
            MySqlDataReader oku;
            oku = komut.ExecuteReader();
            while (oku.Read())
            {
                temsilci_maas.Text = oku["MAAS"].ToString();
            }
            oku.Close();
            baglanti.Close();
        }

        private void mudur_bilgi_button_Click_1(object sender, EventArgs e)
        {
            panel3.Height = mudur_bilgi_button.Height;
            panel3.Top = mudur_bilgi_button.Top;
            musteri_panel.Visible = false;
            temsilci_panel.Visible = false;
            kullanici_bilgi_panel.Visible = true;
            banka_bilgi_panel.Visible = false;
            para_birimleri_panel.Visible = false;
            talep_panel.Visible = false;



            KullaniciGetir();
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        void faiz()
        {

            baglanti = new MySqlConnection("Server=localhost; Database=bank; Uid=root; Pwd=20012001");
            baglanti.Open();
            komut = new MySqlCommand("SELECT BANKA_FAIZ FROM bank.banka_para WHERE banka_id =1", baglanti);
            komut.ExecuteNonQuery();
            MySqlDataReader oku;
            oku = komut.ExecuteReader();
            while (oku.Read())
            {
                faiz_txt.Text = oku["BANKA_FAIZ"].ToString();

            }
            oku.Close();
            baglanti.Close();
        }
        private void banka_bilgi_Click_1(object sender, EventArgs e)
        {
            panel3.Height = banka_bilgi.Height;
            panel3.Top = banka_bilgi.Top;
            musteri_panel.Visible = false;
            temsilci_panel.Visible = false;
            kullanici_bilgi_panel.Visible = false;
            banka_bilgi_panel.Visible = true;
            para_birimleri_panel.Visible = false;
            talep_panel.Visible = false;


            TemsilciMaas();
            MudurMaas();
            ToplamPara();
            MusteriSayi();
            TemsilciSayi();
            faiz();
        }

        private void mudur_maas_guncelle_button_Click(object sender, EventArgs e)
        {
            string sorgu = "UPDATE bank.maas SET MAAS=@maas WHERE BANKA_ROL='mudur';";
            baglanti = new MySqlConnection("Server=localhost; Database=bank; Uid=root; Pwd=20012001");
            komut = new MySqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@maas", Convert.ToInt64(mudur_maas.Text));
           
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Başarıyla Güncellendi");
            MudurMaas();


        }

        private void temsilci_maas_guncelle_button_Click(object sender, EventArgs e)
        {
            string sorgu = "UPDATE bank.maas SET MAAS=@maas WHERE BANKA_ROL='musteri_temsilci';";
            baglanti = new MySqlConnection("Server=localhost; Database=bank; Uid=root; Pwd=20012001");
            komut = new MySqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@maas", Convert.ToInt64(temsilci_maas.Text));

            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Başarıyla Güncellendi");
            TemsilciMaas();
        }

        void DovizGetir()
        {
            baglanti = new MySqlConnection("Server=localhost; Database=bank; Uid=root; Pwd=20012001");
            baglanti.Open();
            da = new MySqlDataAdapter("SELECT * FROM bank.doviz", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView3.DataSource = tablo;
            baglanti.Close();

        }

        private void dataGridView3_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            doviz_no.Text = dataGridView3.CurrentRow.Cells[0].Value.ToString();
            doviz_isim.Text = dataGridView3.CurrentRow.Cells[1].Value.ToString();
            doviz_alis.Text = dataGridView3.CurrentRow.Cells[2].Value.ToString();
            doviz_satis.Text = dataGridView3.CurrentRow.Cells[3].Value.ToString();
        }

        private void para_birimi_Click(object sender, EventArgs e)
        {
            panel3.Height = para_birimi.Height;
            panel3.Top = para_birimi.Top;
            musteri_panel.Visible = false;
            temsilci_panel.Visible = false;
            kullanici_bilgi_panel.Visible = false;
            banka_bilgi_panel.Visible = false;
            para_birimleri_panel.Visible = true;
            talep_panel.Visible = false;

            DovizGetir();
        }

        private void doviz_guncelle_button_Click(object sender, EventArgs e)
        {
            string sorgu = "UPDATE bank.doviz SET DOVIZ_ISIM=@isim,DOVIZ_ALIS=@alis,DOVIZ_SATIS=@satis WHERE DOVIZ_ID=@id;";
            baglanti = new MySqlConnection("Server=localhost; Database=bank; Uid=root; Pwd=20012001");
            komut = new MySqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@id", Convert.ToInt32(doviz_no.Text));
            komut.Parameters.AddWithValue("@isim",doviz_isim.Text);          
            komut.Parameters.AddWithValue("@alis", Convert.ToDouble(doviz_alis.Text));
            komut.Parameters.AddWithValue("@satis", Convert.ToDouble(doviz_satis.Text));

            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Başarıyla Güncellendi");
            DovizGetir();
        }

        private void doviz_ekle_button_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection baglanti = new MySqlConnection("Server=localhost; Database=bank; Uid=root; Pwd=20012001");
                string isim = doviz_isim.Text;
               
                string sorgu = "insert into bank.doviz(DOVIZ_ISIM,DOVIZ_ALIS,DOVIZ_SATIS) values(@isim,@alis,@satis);";//values("  + isim + "," + Convert.ToDouble(doviz_alis.Text) + ","+ Convert.ToDouble(doviz_satis.Text) + ");"
                komut = new MySqlCommand(sorgu, baglanti);

                komut.Parameters.AddWithValue("@isim", isim);
                komut.Parameters.AddWithValue("@alis", Convert.ToDouble(doviz_alis.Text));
                komut.Parameters.AddWithValue("@satis", Convert.ToDouble(doviz_satis.Text));   
                baglanti.Open();
                komut.ExecuteNonQuery();
                baglanti.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            DovizGetir();

        }

        private void doviz_sil_button_Click(object sender, EventArgs e)
        {
            string sorgu = "DELETE FROM bank.doviz WHERE DOVIZ_ID = @id";
            baglanti = new MySqlConnection("Server=localhost; Database=bank; Uid=root; Pwd=20012001");
            komut = new MySqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@id", Convert.ToInt32(doviz_no.Text));
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Başarıyla Silindi");
            DovizGetir();

        }

        private void musteri_guncelle_Click(object sender, EventArgs e)
        {
            string sorgu = "UPDATE bank.musteri_temsilcisi SET AD=@ad,SOYAD=@soyad,SIFRE=@sifre,TELEFON=@telefon,TC=@tc,EPOSTA=@eposta,ADRES=@adres WHERE ID=@id";
            baglanti = new MySqlConnection("Server=localhost; Database=bank; Uid=root; Pwd=20012001");
            komut = new MySqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@id", Convert.ToInt32(temsilci_no.Text));
            komut.Parameters.AddWithValue("@ad", temsilci_ad.Text);
            komut.Parameters.AddWithValue("@soyad", temsilci_soyad.Text);
            komut.Parameters.AddWithValue("@tc", Convert.ToInt64(temsilci_tc.Text));
            komut.Parameters.AddWithValue("@sifre", Convert.ToInt64(temsilci_sifre.Text));
            komut.Parameters.AddWithValue("@eposta", temsilci_eposta.Text);
            komut.Parameters.AddWithValue("@adres", temsilci_adres.Text);
            komut.Parameters.AddWithValue("@telefon", Convert.ToInt64(temsilci_tel.Text));
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Başarıyla Güncellendi");

        }

        private void mudur_guncelle_Click(object sender, EventArgs e)
        {
            string sorgu = "UPDATE bank.mudur SET AD=@ad,SOYAD=@soyad,SIFRE=@sifre,TC=@tc,TELEFON=@telefon,EPOSTA=@eposta,ADRES=@adres WHERE ID=@id";
            baglanti = new MySqlConnection("Server=localhost; Database=bank; Uid=root; Pwd=20012001");
            komut = new MySqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@id", Convert.ToInt32(mudur_no.Text));
            komut.Parameters.AddWithValue("@ad", mudur_ad.Text);
            komut.Parameters.AddWithValue("@soyad", mudur_soyad.Text);
            komut.Parameters.AddWithValue("@tc", Convert.ToInt64(mudur_tc.Text));
            komut.Parameters.AddWithValue("@sifre", Convert.ToInt64(mudur_sifre.Text));
            komut.Parameters.AddWithValue("@eposta", mudur_eposta.Text);
            komut.Parameters.AddWithValue("@adres", mudur_adres.Text);
            komut.Parameters.AddWithValue("@telefon", Convert.ToInt64(mudur_tel.Text));
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Başarıyla Güncellendi");
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            string sorgu = "UPDATE bank.banka_para SET BANKA_FAIZ=@faiz WHERE banka_id=1;";
            baglanti = new MySqlConnection("Server=localhost; Database=bank; Uid=root; Pwd=20012001");
            komut = new MySqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@faiz", Convert.ToDouble(faiz_txt.Text));

            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Başarıyla Güncellendi");
        }

        private void talepler_button_Click(object sender, EventArgs e)
        {
            panel3.Height = talepler_button.Height;
            panel3.Top = talepler_button.Top;
            musteri_panel.Visible = false;
            temsilci_panel.Visible = false;
            kullanici_bilgi_panel.Visible = false;
            banka_bilgi_panel.Visible = false;
            para_birimleri_panel.Visible = false;
            talep_panel.Visible = true;
            TalepGetir();
        }

        private void dataGridView4_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            talep_no.Text = dataGridView4.CurrentRow.Cells[0].Value.ToString();
            talep_tur.Text = dataGridView4.CurrentRow.Cells[1].Value.ToString();
            talep_hesap_no.Text = dataGridView4.CurrentRow.Cells[3].Value.ToString();
            talep_durum.Text = dataGridView4.CurrentRow.Cells[5].Value.ToString();
        }
    }
}
