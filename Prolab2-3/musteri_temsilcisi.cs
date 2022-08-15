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
    public partial class musteri_temsilcisi : Form
    {
        MySqlConnection baglanti;
        MySqlCommand komut;
        MySqlDataAdapter da;
        public musteri_temsilcisi()
        {
            InitializeComponent();
        }

        public musteri_temsilcisi(string id)
        {
            InitializeComponent();
        }


        private void musteri_bilgi_Click(object sender, EventArgs e)
        {
            panel3.Height = musteri_bilgi.Height;
            panel3.Top = musteri_bilgi.Top;
            musteri_panel.Visible = true;
            talep_panel.Visible = false;
            hesap_panel.Visible = false;
            MusteriGetir();
        }

        private void talepler_Click(object sender, EventArgs e)
        {
            panel3.Height = talepler.Height;
            panel3.Top = talepler.Top;
            talep_panel.Visible = true;
            musteri_panel.Visible = false;
            hesap_panel.Visible = false;

            TalepGetir();

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            new Giris().Show();
            this.Hide();
        }

        private void musteri_temsilcisi_FormClosed(object sender, FormClosedEventArgs e)
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

        void TalepGetir()
        {
            baglanti = new MySqlConnection("Server=localhost; Database=bank; Uid=root; Pwd=20012001");
            baglanti.Open();
            da = new MySqlDataAdapter("SELECT * FROM bank.talepler WHERE TALEP_DURUM='beklemede';", baglanti);
     
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView2.DataSource = tablo;
            baglanti.Close();

        }

        void HesapGetir()
        {
            baglanti = new MySqlConnection("Server=localhost; Database=bank; Uid=root; Pwd=20012001");
            baglanti.Open();
            da = new MySqlDataAdapter("SELECT * FROM bank.hesap", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView3.DataSource = tablo;
            baglanti.Close();

        }

        private void musteri_temsilcisi_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
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

        private void musteri_ekle_button_Click(object sender, EventArgs e)
        {
            new Kayit().ShowDialog();
            MusteriGetir();
        }

      
        private void musteri_guncelle_button_Click(object sender, EventArgs e)
        {
            string sorgu = "UPDATE bank.musteri SET AD=@ad,SOYAD=@soyad,SIFRE=@sifre,TELEFON=@telefon,TC=@tc,EPOSTA=@eposta,ADRES=@adres,EPOSTA=@eposta WHERE ID=@id";
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
            MusteriGetir();
        }


        private void telefon_Click(object sender, EventArgs e)
        {

        }

        public string Kredi { get; set; }
        public string AlanHesap { get; set; }
        public string IslemMiktari { get; set; }
        public string Bakiye { get; set; }
        public string MusteriID { get; set; }
        public string Faiz { get; set; }


        void bakiye(int hesap_no)
        {
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

        void kredi(int hesap_no)
        {
            baglanti = new MySqlConnection("Server=localhost; Database=bank; Uid=root; Pwd=20012001");
            baglanti.Open();
            komut = new MySqlCommand("SELECT * FROM bank.hesap WHERE HESAP_NO = '" + hesap_no + "'", baglanti);
            komut.ExecuteNonQuery();
            MySqlDataReader oku;
            oku = komut.ExecuteReader();
            while (oku.Read())
            {
                Kredi = oku["KREDI"].ToString();
            }
            oku.Close();
            baglanti.Close();

        }

        void talep_bilgi()
        {
            int Talep_no = Convert.ToInt32(talep_no.Text);
            baglanti = new MySqlConnection("Server=localhost; Database=bank; Uid=root; Pwd=20012001");
            baglanti.Open();
            komut = new MySqlCommand("SELECT * FROM bank.talepler WHERE TALEP_ID = '" + Talep_no  + "'", baglanti);
            komut.ExecuteNonQuery();
            MySqlDataReader oku;
            oku = komut.ExecuteReader();
            while (oku.Read())
            {
                MusteriID = oku["GONDEREN_HESAP_NO"].ToString();
                AlanHesap = oku["ALAN_HESAP_NO"].ToString();
                IslemMiktari = oku["ISLEM_MIKTARI"].ToString();
            }
            oku.Close();
            baglanti.Close();

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
                Faiz = oku["BANKA_FAIZ"].ToString();
        
            }
            oku.Close();
            baglanti.Close();
        }

      
        private void talep_onay_Click(object sender, EventArgs e)
        {
            string durum = "onaylandi";
            string sorgu = "UPDATE bank.talepler SET TALEP_DURUM=@durum WHERE TALEP_ID=@id";

            komut = new MySqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@id", Convert.ToInt32(talep_no.Text));
            komut.Parameters.AddWithValue("@durum",durum);

            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();

            talep_bilgi();
            

            if(talep_tur.Text=="kredi basvurusu")
            {
                double _islem_miktari = Convert.ToDouble(IslemMiktari);

                faiz();
                double _faiz = Convert.ToDouble(Faiz);


                kredi(Convert.ToInt32(talep_hesap_no.Text));
                double _kredi = Convert.ToInt32(Kredi);
                
                bakiye(Convert.ToInt32(talep_hesap_no.Text));
                double bakiyeKredi = Convert.ToDouble(Bakiye);
              
                sorgu = "UPDATE bank.hesap SET KREDI=@kredi , BAKIYE=@bakiye WHERE HESAP_NO=@hesap";
                komut = new MySqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@hesap", Convert.ToInt32(talep_hesap_no.Text));
                komut.Parameters.AddWithValue("@kredi", (_islem_miktari*((_faiz+100)/100)) +_kredi);
                komut.Parameters.AddWithValue("@bakiye",_islem_miktari + bakiyeKredi);
              
                baglanti.Open();
                komut.ExecuteNonQuery();
                baglanti.Close();
            }
            else if (talep_tur.Text == "havale")
            {
                int gonderen_hesap = Convert.ToInt32(talep_hesap_no.Text);

                int alan_hesap = Convert.ToInt32(AlanHesap);

                bakiye(gonderen_hesap);
                double gonderen_hesap_bakiye=Convert.ToDouble(Bakiye);
                bakiye(alan_hesap);
                double alan_hesap_bakiye = Convert.ToDouble(Bakiye);

                int islem_miktari = Convert.ToInt32(IslemMiktari);


                 sorgu = "UPDATE bank.hesap SET BAKIYE=@bakiye WHERE HESAP_NO=@GonderenHesap";
                komut = new MySqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@GonderenHesap", gonderen_hesap);
                komut.Parameters.AddWithValue("@bakiye", gonderen_hesap_bakiye - islem_miktari);
                baglanti.Open();
                komut.ExecuteNonQuery();
                baglanti.Close();

                 sorgu = "UPDATE bank.hesap SET BAKIYE=@bakiye WHERE HESAP_NO=@AlanHesap";
                komut = new MySqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@AlanHesap", alan_hesap);
                komut.Parameters.AddWithValue("@bakiye", alan_hesap_bakiye + islem_miktari);
                baglanti.Open();
                komut.ExecuteNonQuery();
                baglanti.Close();
            }
            else if (talep_tur.Text == "hesap acma")
            {
                int musteri_id = Convert.ToInt32(MusteriID);
                try
                {
                    MySqlConnection baglanti = new MySqlConnection("Server=localhost; Database=bank; Uid=root; Pwd=20012001");

                    string Query = "insert into bank.hesap(MUSTERI_ID,BAKIYE,KREDI) values("+musteri_id+",0,0);";

                    
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
            }
            TalepGetir();
            MessageBox.Show("Başarıyla Onaylandı.");
        }

        private void dataGridView2_CellEnter_1(object sender, DataGridViewCellEventArgs e)
        {
            talep_no.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            talep_tur.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            talep_hesap_no.Text = dataGridView2.CurrentRow.Cells[3].Value.ToString();
        }

        private void talep_ret_Click(object sender, EventArgs e)
        {
            string durum = "reddedildi";
            string sorgu = "UPDATE bank.talepler SET TALEP_DURUM=@durum WHERE TALEP_ID=@id";
            MySqlConnection baglanti = new MySqlConnection("Server=localhost; Database=bank; Uid=root; Pwd=20012001");

            komut = new MySqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@id", Convert.ToInt32(talep_no.Text));
            komut.Parameters.AddWithValue("@durum", durum);

            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            TalepGetir();
            MessageBox.Show("Reddedildi.");
        }

        private void dataGridView3_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            hesap_musteri_no.Text = dataGridView3.CurrentRow.Cells[0].Value.ToString();
            hesap_no.Text = dataGridView3.CurrentRow.Cells[1].Value.ToString();
            hesap_bakiye.Text = dataGridView3.CurrentRow.Cells[2].Value.ToString();
            hesap_kredi.Text = dataGridView3.CurrentRow.Cells[3].Value.ToString();
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void hesap_button_Click_1(object sender, EventArgs e)
        {
            panel3.Height = hesap_button.Height;
            panel3.Top = hesap_button.Top;
            talep_panel.Visible = false;
            musteri_panel.Visible = false;
            hesap_panel.Visible = true;

            HesapGetir();
        }


        private void hesap_sil_button_Click(object sender, EventArgs e)
        {
            bakiye(Convert.ToInt32(hesap_no.Text));


            if (Bakiye == "0")
            {
                MySqlConnection baglanti = new MySqlConnection("Server=localhost; Database=bank; Uid=root; Pwd=20012001");
                baglanti.Open();
                string sorgu = "DELETE FROM bank.hesap WHERE HESAP_NO = @id";
                komut = new MySqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@id", Convert.ToInt32(hesap_no.Text));
                
                komut.ExecuteNonQuery();
                baglanti.Close();
                HesapGetir();
            }
            else
                MessageBox.Show("Hesabın Bakiyesi Sıfır Olmadan" + "\n" + "Hesap Silinemez");


           
        }
    }
}
