
namespace Prolab2_3
{
    partial class Kayit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kayit));
            this.panel1 = new System.Windows.Forms.Panel();
            this.back_button = new System.Windows.Forms.Button();
            this.baslik = new System.Windows.Forms.Label();
            this.isim = new System.Windows.Forms.Label();
            this.soyad = new System.Windows.Forms.Label();
            this.TC = new System.Windows.Forms.Label();
            this.e_posta = new System.Windows.Forms.Label();
            this.adres = new System.Windows.Forms.Label();
            this.isim_kayit = new System.Windows.Forms.TextBox();
            this.eposta_kayit = new System.Windows.Forms.TextBox();
            this.soyad_kayit = new System.Windows.Forms.TextBox();
            this.tc_kayit = new System.Windows.Forms.TextBox();
            this.adres_kayit = new System.Windows.Forms.TextBox();
            this.onay_buton = new System.Windows.Forms.Button();
            this.sifre_kayit = new System.Windows.Forms.TextBox();
            this.sifre = new System.Windows.Forms.Label();
            this.sifre_tekrar_kayit = new System.Windows.Forms.TextBox();
            this.sifre_tekrar = new System.Windows.Forms.Label();
            this.telefon = new System.Windows.Forms.Label();
            this.tel_kayit = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Sienna;
            this.panel1.Controls.Add(this.back_button);
            this.panel1.Controls.Add(this.baslik);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(820, 74);
            this.panel1.TabIndex = 1;
            // 
            // back_button
            // 
            this.back_button.Image = ((System.Drawing.Image)(resources.GetObject("back_button.Image")));
            this.back_button.Location = new System.Drawing.Point(10, 9);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(58, 54);
            this.back_button.TabIndex = 4;
            this.back_button.UseVisualStyleBackColor = false;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // baslik
            // 
            this.baslik.AutoSize = true;
            this.baslik.Font = new System.Drawing.Font("Perpetua Titling MT", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baslik.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.baslik.Location = new System.Drawing.Point(220, 15);
            this.baslik.Name = "baslik";
            this.baslik.Size = new System.Drawing.Size(418, 48);
            this.baslik.TabIndex = 3;
            this.baslik.Text = "GRİNGOTTS BANK";
            // 
            // isim
            // 
            this.isim.AutoSize = true;
            this.isim.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.isim.Location = new System.Drawing.Point(29, 90);
            this.isim.Name = "isim";
            this.isim.Size = new System.Drawing.Size(50, 28);
            this.isim.TabIndex = 2;
            this.isim.Text = "İsim";
            // 
            // soyad
            // 
            this.soyad.AutoSize = true;
            this.soyad.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.soyad.Location = new System.Drawing.Point(30, 166);
            this.soyad.Name = "soyad";
            this.soyad.Size = new System.Drawing.Size(67, 28);
            this.soyad.TabIndex = 3;
            this.soyad.Text = "Soyad";
            // 
            // TC
            // 
            this.TC.AutoSize = true;
            this.TC.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TC.Location = new System.Drawing.Point(30, 242);
            this.TC.Name = "TC";
            this.TC.Size = new System.Drawing.Size(68, 28);
            this.TC.TabIndex = 4;
            this.TC.Text = "TC No";
            // 
            // e_posta
            // 
            this.e_posta.AutoSize = true;
            this.e_posta.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.e_posta.Location = new System.Drawing.Point(283, 90);
            this.e_posta.Name = "e_posta";
            this.e_posta.Size = new System.Drawing.Size(80, 28);
            this.e_posta.TabIndex = 5;
            this.e_posta.Text = "E-posta";
            // 
            // adres
            // 
            this.adres.AutoSize = true;
            this.adres.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.adres.Location = new System.Drawing.Point(539, 166);
            this.adres.Name = "adres";
            this.adres.Size = new System.Drawing.Size(64, 28);
            this.adres.TabIndex = 6;
            this.adres.Text = "Adres";
            // 
            // isim_kayit
            // 
            this.isim_kayit.Font = new System.Drawing.Font("Yu Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.isim_kayit.Location = new System.Drawing.Point(34, 121);
            this.isim_kayit.Multiline = true;
            this.isim_kayit.Name = "isim_kayit";
            this.isim_kayit.Size = new System.Drawing.Size(231, 42);
            this.isim_kayit.TabIndex = 7;
            // 
            // eposta_kayit
            // 
            this.eposta_kayit.Font = new System.Drawing.Font("Yu Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.eposta_kayit.Location = new System.Drawing.Point(288, 121);
            this.eposta_kayit.Multiline = true;
            this.eposta_kayit.Name = "eposta_kayit";
            this.eposta_kayit.Size = new System.Drawing.Size(236, 42);
            this.eposta_kayit.TabIndex = 8;
            // 
            // soyad_kayit
            // 
            this.soyad_kayit.Font = new System.Drawing.Font("Yu Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.soyad_kayit.Location = new System.Drawing.Point(34, 197);
            this.soyad_kayit.Multiline = true;
            this.soyad_kayit.Name = "soyad_kayit";
            this.soyad_kayit.Size = new System.Drawing.Size(231, 42);
            this.soyad_kayit.TabIndex = 9;
            // 
            // tc_kayit
            // 
            this.tc_kayit.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tc_kayit.Location = new System.Drawing.Point(35, 273);
            this.tc_kayit.Multiline = true;
            this.tc_kayit.Name = "tc_kayit";
            this.tc_kayit.Size = new System.Drawing.Size(231, 42);
            this.tc_kayit.TabIndex = 10;
            // 
            // adres_kayit
            // 
            this.adres_kayit.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.adres_kayit.Location = new System.Drawing.Point(544, 197);
            this.adres_kayit.Multiline = true;
            this.adres_kayit.Name = "adres_kayit";
            this.adres_kayit.Size = new System.Drawing.Size(236, 118);
            this.adres_kayit.TabIndex = 11;
            // 
            // onay_buton
            // 
            this.onay_buton.Font = new System.Drawing.Font("Yu Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.onay_buton.Location = new System.Drawing.Point(644, 342);
            this.onay_buton.Name = "onay_buton";
            this.onay_buton.Size = new System.Drawing.Size(136, 44);
            this.onay_buton.TabIndex = 12;
            this.onay_buton.Text = "Onay";
            this.onay_buton.UseVisualStyleBackColor = true;
            this.onay_buton.Click += new System.EventHandler(this.onay_buton_Click);
            // 
            // sifre_kayit
            // 
            this.sifre_kayit.Font = new System.Drawing.Font("Yu Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sifre_kayit.Location = new System.Drawing.Point(288, 197);
            this.sifre_kayit.Multiline = true;
            this.sifre_kayit.Name = "sifre_kayit";
            this.sifre_kayit.Size = new System.Drawing.Size(231, 42);
            this.sifre_kayit.TabIndex = 14;
            // 
            // sifre
            // 
            this.sifre.AutoSize = true;
            this.sifre.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sifre.Location = new System.Drawing.Point(283, 166);
            this.sifre.Name = "sifre";
            this.sifre.Size = new System.Drawing.Size(55, 28);
            this.sifre.TabIndex = 13;
            this.sifre.Text = "Şifre";
            // 
            // sifre_tekrar_kayit
            // 
            this.sifre_tekrar_kayit.Font = new System.Drawing.Font("Yu Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sifre_tekrar_kayit.Location = new System.Drawing.Point(288, 273);
            this.sifre_tekrar_kayit.Multiline = true;
            this.sifre_tekrar_kayit.Name = "sifre_tekrar_kayit";
            this.sifre_tekrar_kayit.Size = new System.Drawing.Size(231, 42);
            this.sifre_tekrar_kayit.TabIndex = 16;
            // 
            // sifre_tekrar
            // 
            this.sifre_tekrar.AutoSize = true;
            this.sifre_tekrar.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sifre_tekrar.Location = new System.Drawing.Point(283, 242);
            this.sifre_tekrar.Name = "sifre_tekrar";
            this.sifre_tekrar.Size = new System.Drawing.Size(116, 28);
            this.sifre_tekrar.TabIndex = 15;
            this.sifre_tekrar.Text = "Şifre Tekrar";
            // 
            // telefon
            // 
            this.telefon.AutoSize = true;
            this.telefon.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.telefon.Location = new System.Drawing.Point(539, 90);
            this.telefon.Name = "telefon";
            this.telefon.Size = new System.Drawing.Size(99, 35);
            this.telefon.TabIndex = 5;
            this.telefon.Text = "Telefon";
            // 
            // tel_kayit
            // 
            this.tel_kayit.Font = new System.Drawing.Font("Yu Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tel_kayit.Location = new System.Drawing.Point(544, 121);
            this.tel_kayit.Multiline = true;
            this.tel_kayit.Name = "tel_kayit";
            this.tel_kayit.Size = new System.Drawing.Size(236, 42);
            this.tel_kayit.TabIndex = 8;
            // 
            // Kayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 416);
            this.Controls.Add(this.sifre_tekrar_kayit);
            this.Controls.Add(this.sifre_tekrar);
            this.Controls.Add(this.sifre_kayit);
            this.Controls.Add(this.sifre);
            this.Controls.Add(this.onay_buton);
            this.Controls.Add(this.adres_kayit);
            this.Controls.Add(this.tc_kayit);
            this.Controls.Add(this.soyad_kayit);
            this.Controls.Add(this.tel_kayit);
            this.Controls.Add(this.eposta_kayit);
            this.Controls.Add(this.isim_kayit);
            this.Controls.Add(this.telefon);
            this.Controls.Add(this.adres);
            this.Controls.Add(this.e_posta);
            this.Controls.Add(this.TC);
            this.Controls.Add(this.soyad);
            this.Controls.Add(this.isim);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Kayit";
            this.Text = "Kayıt Formu";
            this.Load += new System.EventHandler(this.Kayit_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label baslik;
        private System.Windows.Forms.Label isim;
        private System.Windows.Forms.Label soyad;
        private System.Windows.Forms.Label TC;
        private System.Windows.Forms.Label e_posta;
        private System.Windows.Forms.Label adres;
        private System.Windows.Forms.TextBox isim_kayit;
        private System.Windows.Forms.TextBox eposta_kayit;
        private System.Windows.Forms.TextBox soyad_kayit;
        private System.Windows.Forms.TextBox tc_kayit;
        private System.Windows.Forms.TextBox adres_kayit;
        private System.Windows.Forms.Button onay_buton;
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.TextBox sifre_kayit;
        private System.Windows.Forms.Label sifre;
        private System.Windows.Forms.TextBox sifre_tekrar_kayit;
        private System.Windows.Forms.Label sifre_tekrar;
        private System.Windows.Forms.Label telefon;
        private System.Windows.Forms.TextBox tel_kayit;
    }
}