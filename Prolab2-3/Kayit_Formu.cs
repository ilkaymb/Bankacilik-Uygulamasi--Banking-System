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
    public partial class Kayit : Form
    {
        MySqlConnection baglanti;
        MySqlCommand komut;
        MySqlDataAdapter da;
        public Kayit()
        {
            InitializeComponent();
        }

    

        private void back_button_Click(object sender, EventArgs e)
        {
            new Giris().Show();
            this.Hide();
        }
        public string TemsilciID { get; set; }
        public string ID { get; set; }

     
        void temsilci()
        {
            baglanti = new MySqlConnection("Server=localhost; Database=bank; Uid=root; Pwd=20012001");
            baglanti.Open();
            komut = new MySqlCommand("SELECT ID FROM bank.musteri_temsilcisi GROUP BY ID ORDER BY MIN(MUSTERI_SAYISI) LIMIT 1 ;", baglanti);
            komut.ExecuteNonQuery();
            MySqlDataReader oku;
            oku = komut.ExecuteReader();
            while (oku.Read())
            {
               TemsilciID  = oku["ID"].ToString();
            }
            oku.Close();
            baglanti.Close();

        }




        private void onay_buton_Click(object sender, EventArgs e)
        {
            string isim = isim_kayit.Text; //textboxtaki değerleri string değişkenlere atadım
            string soyad = soyad_kayit.Text;
            string sifre = sifre_kayit.Text;
            string sifre_tekrar = sifre_tekrar_kayit.Text;
            string eposta = eposta_kayit.Text;
            string adres = adres_kayit.Text;
            string tc = tc_kayit.Text;
            string tel = tel_kayit.Text;

            if (isim == "" || soyad == "" || sifre == "" || sifre_tekrar == "" || eposta == "" || adres == "" || tc == "") //Eğer textboxlardan biri boşsa beni uyarsın ve işlem yapmasın
            {
                MessageBox.Show("Lütfen tüm alanları doldurun");
                return;
            }
            else
            {
                if(sifre != sifre_tekrar)
                {
                    MessageBox.Show("Girdiğiniz şifre eşleşmiyor!");
                    return;
                }
                else
                {
                    temsilci();
                    int temsilci_id = Convert.ToInt32(TemsilciID);

                    try
                    {
                        MySqlConnection baglanti = new MySqlConnection("Server=localhost; Database=bank; Uid=root; Pwd=20012001");
                        string Query = "insert into bank.musteri(AD,SOYAD,SIFRE,TELEFON,TC,ADRES,EPOSTA) values('" + isim + "','" + soyad + "','" + sifre + "','" + tel + "','" + tc + "','"+adres+ "','" + eposta + "');";
                        
                        MySqlCommand MyCommand2 = new MySqlCommand(Query, baglanti);
                        MySqlDataReader MyReader2;
                        baglanti.Open();
                        MyReader2 = MyCommand2.ExecuteReader();    
                        while (MyReader2.Read())
                        {
                        }
                        baglanti.Close();
                        Query = "insert into bank.doviz_hesap() values();";


                        MyCommand2 = new MySqlCommand(Query, baglanti);

                        baglanti.Open();
                        MyReader2 = MyCommand2.ExecuteReader();
                        while (MyReader2.Read())
                        {
                        }
                        baglanti.Close();
                        /*
                          Query = "SELECT ID FROM bank.musteri WHERE AD=@isim,SOYAD=@soyad,SIFRE=@sifre,TELEFON=@telefon,TC=@tc,ADRES=@adre,EPOSTA=@eposta;";

                         MyCommand2 = new MySqlCommand(Query, baglanti);
                         MyCommand2.Parameters.AddWithValue("@ad", isim);
                         MyCommand2.Parameters.AddWithValue("@soyad", soyad);
                         MyCommand2.Parameters.AddWithValue("@sifre", sifre);
                         MyCommand2.Parameters.AddWithValue("@telefon", tel);
                         MyCommand2.Parameters.AddWithValue("@tc", tc);
                         MyCommand2.Parameters.AddWithValue("@adres", adres);
                         MyCommand2.Parameters.AddWithValue("@eposta", eposta);
                         baglanti.Open();
                         MyReader2 = MyCommand2.ExecuteReader();
                         while (MyReader2.Read())
                         {
                             ID = MyReader2["ID"].ToString();
                         }
                         baglanti.Close();
                         int id = Convert.ToInt32(ID);

                         Query = "insert into bank.doviz_hesap(ID) values("+id+");";


                         MyCommand2 = new MySqlCommand(Query, baglanti);

                         baglanti.Open();
                         MyReader2 = MyCommand2.ExecuteReader();
                         while (MyReader2.Read())
                         {
                         }
                         baglanti.Close();
                         Query = "insert into bank.temsilci(TEMSILCI_ID,MUSTERI_ID) values("+ temsilci_id + ","+id+");";
                         MyCommand2 = new MySqlCommand(Query, baglanti);


                         baglanti.Open();
                         MyReader2 = MyCommand2.ExecuteReader();
                         while (MyReader2.Read())
                         {
                         }
                         baglanti.Close();
                        */
                        /*
                        string sorgu = "UPDATE bank.musteri_temsilcisi SET AD=@ad,SOYAD=@soyad,SIFRE=@sifre,TELEFON=@telefon,TC=@tc,ADRES=@adres,EPOSTA=@eposta WHERE ID=@id";
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
                        */

                        MessageBox.Show("Başarılı");

                        this.Hide();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void Kayit_Load(object sender, EventArgs e)
        {

        }
    }
}
