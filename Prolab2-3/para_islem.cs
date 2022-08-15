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
    public partial class para_islem : Form
    {
        MySqlConnection baglanti;
        MySqlCommand komut;
        MySqlDataAdapter da;
        public para_islem()
        {
            InitializeComponent();
        }

      
        public para_islem(int value,int hesap_no)
        {
            InitializeComponent();
            Value = value;
            Hesap_no = hesap_no;
            if(value==1)
            {
                ust.Text = "Yüklenecek Miktarı Giriniz";
                alt.Visible = false;
                txt_alt.Visible = false;
            }
            else if (value == 2)
            {
                ust.Text = "Çekilecek Miktarı Giriniz";
                alt.Visible = false;
                txt_alt.Visible = false;
            }
            else if (value == 3)
            {
                ust.Text = "Ödenecek Kredi Tutarını Giriniz";
                alt.Visible = false;
                txt_alt.Visible = false;
            }
            else if (value == 4)
            {
                ust.Text = "Havale Yapılacak Hesabı Giriniz";
                alt.Text = "Yollanacak Miktarı Giriniz";
                alt.Visible = true;
                txt_alt.Visible = true;
            }
            else if (value == 5)
            {
                ust.Text = "Çekilecek Kredi Tutarını Giriniz";
                alt.Visible = false;
                txt_alt.Visible = false;
            }         
        }
        public int Value { get; set; }
        public int Hesap_no { get; set; }
        public string Bakiye { get; set; }
        public string Kredi { get; set; }


        void bakiye()
        {
            

            baglanti = new MySqlConnection("Server=localhost; Database=bank; Uid=root; Pwd=20012001");
            baglanti.Open();
            komut = new MySqlCommand("SELECT * FROM bank.hesap WHERE HESAP_NO = '" + Hesap_no + "'", baglanti);
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

        void kredi()
        {
            baglanti = new MySqlConnection("Server=localhost; Database=bank; Uid=root; Pwd=20012001");
            baglanti.Open();
            komut = new MySqlCommand("SELECT * FROM bank.hesap WHERE HESAP_NO = '" + Hesap_no + "'", baglanti);
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

        

        private void miktar_Click(object sender, EventArgs e)
        {

        }

        private void ust_Click(object sender, EventArgs e)
        {

        }

        private void onay_buton_Click(object sender, EventArgs e)
        {
            bakiye();
            double _bakiye = Convert.ToDouble(Bakiye);
            int girilen_miktar = Convert.ToInt32(txt_ust.Text);
            baglanti = new MySqlConnection("Server=localhost; Database=bank; Uid=root; Pwd=20012001");



            if (Value == 1)
            {

                string sorgu = "UPDATE bank.hesap SET BAKIYE=@para WHERE HESAP_NO=@hesap_no";

                komut = new MySqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@para", _bakiye+girilen_miktar);
                komut.Parameters.AddWithValue("@hesap_no", Hesap_no);

                baglanti.Open();
                komut.ExecuteNonQuery();
                baglanti.Close();

            
                MessageBox.Show("Para Yükleme İşleminiz"+"\n"+"Başarıyla Onaylandı.");
                this.Close();



            }
            else if (Value == 2)
            {
               
                if(girilen_miktar>_bakiye)
                {
                    MessageBox.Show("Girdiğiniz Miktar Bakiyenizden Fazladır");
                }
                else 
                {
                    string sorgu = "UPDATE bank.hesap SET BAKIYE=@para WHERE HESAP_NO=@hesap_no";

                    komut = new MySqlCommand(sorgu, baglanti);
                    komut.Parameters.AddWithValue("@para",_bakiye-girilen_miktar);
                    komut.Parameters.AddWithValue("@hesap_no", Hesap_no);

                    baglanti.Open();
                    komut.ExecuteNonQuery();
                    baglanti.Close();

                    MessageBox.Show("Para Çekme İşleminiz" + "\n" + "Başarıyla Onaylandı.");
                    this.Close();
                }
               
            }
            else if (Value == 3)
            {
                kredi();
                double _kredi = Convert.ToDouble(Kredi);
                if (girilen_miktar > _bakiye)
                {
                    MessageBox.Show("Bakiyenizde Yeterli Para Yoktur!");
                }
                else if (girilen_miktar > _kredi)
                {
                    MessageBox.Show("Girdiğiniz Miktar"+"\n"+"Kredi Borcunuzdan Fazla!");
                }
                else
                {
                    string sorgu = "UPDATE bank.hesap SET KREDI=@kredi,BAKIYE=@bakiye WHERE HESAP_NO=@hesap_no";

                    komut = new MySqlCommand(sorgu, baglanti);
                    komut.Parameters.AddWithValue("@kredi", _kredi - girilen_miktar);
                    komut.Parameters.AddWithValue("@bakiye", _bakiye - girilen_miktar);
                    komut.Parameters.AddWithValue("@hesap_no", Hesap_no);

                    baglanti.Open();
                    komut.ExecuteNonQuery();
                    baglanti.Close();

                    MessageBox.Show("Kredi Ödeme İşleminiz" + "\n" + "Başarıyla Onaylandı.");
                    this.Close();
                }
            }
            else if (Value == 4)
            {

                if(girilen_miktar > _bakiye)
                {
                    MessageBox.Show("Girdiğiniz Miktar Bakiyenizden Fazladır");
                }
                else
                {
                    try
                    {
                        int gonderilecek_hesap = Convert.ToInt32(txt_ust.Text);
                        int islem_miktar = Convert.ToInt32(txt_alt.Text);




                        MySqlConnection baglanti = new MySqlConnection("Server=localhost; Database=bank; Uid=root; Pwd=20012001");

                        string Query = "insert into bank.talepler(TALEP_TURU,ISLEM_MIKTARI,GONDEREN_HESAP_NO,ALAN_HESAP_NO,TALEP_DURUM) values('" + "havale" + "','" + islem_miktar + "','" + Hesap_no + "','" + gonderilecek_hesap + "','" + "beklemede" + "');";//(TALEP_TURU,GONDEREN_HESAP_NO,GBAKIYE,ALAN_HESAP_NO,ABAKIYE,TALEP_DURUM)

                        MySqlCommand MyCommand2 = new MySqlCommand(Query, baglanti);
                        MySqlDataReader MyReader2;
                        baglanti.Open();
                        MyReader2 = MyCommand2.ExecuteReader();

                        while (MyReader2.Read())
                        {
                        }
                        baglanti.Close();
                        MessageBox.Show("Havale Talebiniz Gönderildi.");
                        this.Close();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }

               
            }
            else if(Value == 5)
            {
                int kredi=Convert.ToInt32(txt_ust.Text);
                try
                {
                    MySqlConnection baglanti = new MySqlConnection("Server=localhost; Database=bank; Uid=root; Pwd=20012001");

                    string Query = "insert into bank.talepler(TALEP_TURU,ISLEM_MIKTARI,GONDEREN_HESAP_NO,TALEP_DURUM) values('" + "kredi basvurusu" + "','" + kredi + "','" + Hesap_no + "','" + "beklemede" + "');";//(TALEP_TURU,GONDEREN_HESAP_NO,GBAKIYE,ALAN_HESAP_NO,ABAKIYE,TALEP_DURUM)

                    MySqlCommand MyCommand2 = new MySqlCommand(Query, baglanti);
                    MySqlDataReader MyReader2;
                    baglanti.Open();
                    MyReader2 = MyCommand2.ExecuteReader();

                    while (MyReader2.Read())
                    {
                    }
                    baglanti.Close();
                    MessageBox.Show("Kredi Talebiniz Gönderildi.");
                    this.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            
        }

        private void para_islem_Load(object sender, EventArgs e)
        {

        }
    }
}
