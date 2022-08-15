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
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        
        }

        private void Giris_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtGiris.Text, "  ^ [0-9]"))
            {
                txtGiris.Text = "";
            }
        }

        public static MySqlConnection baglanti = new MySqlConnection("Server=localhost; Database=bank; Uid=root; Pwd=20012001");

        public static void veritabani_baglantisi()
        {
            try 
            {
                baglanti.Open();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message); 
            }
        }

        bool giris_dogrulama_musteri(string id, string sifre) 
        {
            veritabani_baglantisi(); 
            MySqlCommand cmd = new MySqlCommand(); 
         
            cmd.CommandText = "SELECT * FROM musteri WHERE ID=@id AND SIFRE=@sifre"; 
            cmd.Parameters.AddWithValue("@id", id); 
            cmd.Parameters.AddWithValue("@sifre", sifre); 
            cmd.Connection = baglanti; 
            MySqlDataReader login = cmd.ExecuteReader(); 
            if (login.Read()) 
            {
                baglanti.Close();
                return true; 
            }
            else
            {
                baglanti.Close();
                return false;
            }
        }

        bool giris_dogrulama_temsilci(string id, string sifre) 
        {
            veritabani_baglantisi(); 
            MySqlCommand cmd = new MySqlCommand(); 
        
            cmd.CommandText = "SELECT * FROM musteri_temsilcisi WHERE ID=@id AND SIFRE=@sifre"; 
            cmd.Parameters.AddWithValue("@id", id); 
            cmd.Parameters.AddWithValue("@sifre", sifre); 
            cmd.Connection = baglanti; 
            MySqlDataReader login = cmd.ExecuteReader();
            if (login.Read()) 
            {
                baglanti.Close();
                return true; 
            }
            else
            {
                baglanti.Close();
                return false; 
            }
        }

        bool giris_dogrulama_mudur(string id, string sifre) 
        {
            veritabani_baglantisi(); 
            MySqlCommand cmd = new MySqlCommand(); 
            
            cmd.CommandText = "SELECT * FROM mudur WHERE ID=@id AND SIFRE=@sifre"; 
            cmd.Parameters.AddWithValue("@id", id); 
            cmd.Parameters.AddWithValue("@sifre", sifre); 
            cmd.Connection = baglanti; 
            MySqlDataReader login = cmd.ExecuteReader();
            if (login.Read()) 
            {
                baglanti.Close();
                return true; 
            }
            else
            {
                baglanti.Close();
                return false; 
            }
        }



        private void giris_buton_Click(object sender, EventArgs e)
        {
            string id = txtGiris.Text; 
            string sifre = txtSifre.Text;

            if (id == "" || sifre == "") 
            {
                MessageBox.Show("Lütfen tüm alanları doldurun");
                return;
            }
            else
            {
                bool a;

                if (musteri_button.Checked)
                {
                    a = giris_dogrulama_musteri(id, sifre);
                    if (a) 
                    {
                      new musteri(id).Show();
                      this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Hatalı Kullanıcı Adı veya Şifre!");
                    }
                 
                }
                else if (temsilci_button.Checked)
                {
                    a = giris_dogrulama_temsilci(id, sifre);
                    if (a)
                    {
                        new musteri_temsilcisi(id).Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Hatalı Kullanıcı Adı veya Şifre!");

                    }
                }
                else if (mudur_button.Checked)
                {
                    a = giris_dogrulama_mudur(id, sifre);
                    if (a)
                    {
                        new mudur(id).Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Hatalı Kullanıcı Adı veya Şifre!");
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen yukarıdan giriş yönteminizi seçin", "Hata Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
          

        private void sifre_goster_CheckedChanged(object sender, EventArgs e)
        {
            if (sifre_goster.Checked)
            {
                txtSifre.PasswordChar = '\0';
            }
            else
            {
                txtSifre.PasswordChar = '*';
            }
                
        }

        private void Kayit_buton_Click(object sender, EventArgs e)
        {
            new Kayit().Show();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            giris_no.Text = "Giriş No:";
            panel2.Visible = true;
            this.ClientSize = new Size(410, 500);

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            giris_no.Text = "Musteri No:";
            panel2.Visible = true;
            this.ClientSize = new Size(410, 500);
        }

        private void mudur_button_Click(object sender, EventArgs e)
        {
            giris_no.Text = "Giriş No:";
            panel2.Visible = true;
            this.ClientSize = new Size(410, 500);

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtSifre.Text, "  ^ [0-9]"))
            {
                txtSifre.Text = "";
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.'))
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.'))
            {
              
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Giris_Click(object sender, EventArgs e)
        {
      
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Giris_Shown(object sender, EventArgs e)
        {
            txtGiris.Focus();
        }

        private void Giris_Leave(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Giris_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
