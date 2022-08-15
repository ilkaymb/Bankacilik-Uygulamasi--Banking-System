
namespace Prolab2_3
{
    partial class Giris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Giris));
            this.panel1 = new System.Windows.Forms.Panel();
            this.mudur_button = new Guna.UI2.WinForms.Guna2Button();
            this.temsilci_button = new Guna.UI2.WinForms.Guna2Button();
            this.musteri_button = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.baslik = new System.Windows.Forms.Label();
            this.giris_no = new System.Windows.Forms.Label();
            this.txtGiris = new System.Windows.Forms.TextBox();
            this.giris_sifre = new System.Windows.Forms.Label();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.sifre_goster = new System.Windows.Forms.CheckBox();
            this.giris_buton = new System.Windows.Forms.Button();
            this.Kayit_buton = new System.Windows.Forms.Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Sienna;
            this.panel1.Controls.Add(this.mudur_button);
            this.panel1.Controls.Add(this.temsilci_button);
            this.panel1.Controls.Add(this.musteri_button);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.baslik);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(551, 175);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // mudur_button
            // 
            this.mudur_button.BackColor = System.Drawing.SystemColors.Control;
            this.mudur_button.BorderColor = System.Drawing.Color.White;
            this.mudur_button.BorderRadius = 4;
            this.mudur_button.BorderThickness = 2;
            this.mudur_button.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.mudur_button.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.mudur_button.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.mudur_button.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.mudur_button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.mudur_button.FillColor = System.Drawing.Color.Sienna;
            this.mudur_button.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mudur_button.ForeColor = System.Drawing.Color.White;
            this.mudur_button.Location = new System.Drawing.Point(368, 111);
            this.mudur_button.Name = "mudur_button";
            this.mudur_button.Size = new System.Drawing.Size(176, 53);
            this.mudur_button.TabIndex = 10;
            this.mudur_button.Text = "Banka Müdürü Girişi";
            this.mudur_button.Click += new System.EventHandler(this.mudur_button_Click);
            // 
            // temsilci_button
            // 
            this.temsilci_button.BackColor = System.Drawing.SystemColors.Control;
            this.temsilci_button.BorderColor = System.Drawing.Color.White;
            this.temsilci_button.BorderRadius = 4;
            this.temsilci_button.BorderThickness = 2;
            this.temsilci_button.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.temsilci_button.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.temsilci_button.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.temsilci_button.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.temsilci_button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.temsilci_button.FillColor = System.Drawing.Color.Sienna;
            this.temsilci_button.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.temsilci_button.ForeColor = System.Drawing.Color.White;
            this.temsilci_button.Location = new System.Drawing.Point(186, 111);
            this.temsilci_button.Name = "temsilci_button";
            this.temsilci_button.Size = new System.Drawing.Size(176, 53);
            this.temsilci_button.TabIndex = 17;
            this.temsilci_button.Text = "Müşteri Temsilcisi Girşi";
            this.temsilci_button.Click += new System.EventHandler(this.guna2Button3_Click);
            // 
            // musteri_button
            // 
            this.musteri_button.BackColor = System.Drawing.SystemColors.Control;
            this.musteri_button.BorderColor = System.Drawing.Color.White;
            this.musteri_button.BorderRadius = 4;
            this.musteri_button.BorderThickness = 2;
            this.musteri_button.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.musteri_button.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.musteri_button.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.musteri_button.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.musteri_button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.musteri_button.FillColor = System.Drawing.Color.Sienna;
            this.musteri_button.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.musteri_button.ForeColor = System.Drawing.Color.White;
            this.musteri_button.Location = new System.Drawing.Point(4, 111);
            this.musteri_button.Name = "musteri_button";
            this.musteri_button.Size = new System.Drawing.Size(176, 53);
            this.musteri_button.TabIndex = 9;
            this.musteri_button.Text = "Müşteri Girişi";
            this.musteri_button.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(420, 60);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(61, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(55, 60);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(61, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 14;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(238, 60);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(61, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // baslik
            // 
            this.baslik.AutoSize = true;
            this.baslik.Font = new System.Drawing.Font("Perpetua Titling MT", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baslik.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.baslik.Location = new System.Drawing.Point(63, 9);
            this.baslik.Name = "baslik";
            this.baslik.Size = new System.Drawing.Size(418, 48);
            this.baslik.TabIndex = 3;
            this.baslik.Text = "GRİNGOTTS BANK";
            // 
            // giris_no
            // 
            this.giris_no.AutoSize = true;
            this.giris_no.Font = new System.Drawing.Font("Yu Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.giris_no.Location = new System.Drawing.Point(101, 60);
            this.giris_no.Name = "giris_no";
            this.giris_no.Size = new System.Drawing.Size(130, 35);
            this.giris_no.TabIndex = 1;
            this.giris_no.Text = "Giriş No:";
            // 
            // txtGiris
            // 
            this.txtGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtGiris.Location = new System.Drawing.Point(106, 107);
            this.txtGiris.Multiline = true;
            this.txtGiris.Name = "txtGiris";
            this.txtGiris.Size = new System.Drawing.Size(304, 34);
            this.txtGiris.TabIndex = 0;
            this.txtGiris.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtGiris.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // giris_sifre
            // 
            this.giris_sifre.AutoSize = true;
            this.giris_sifre.Font = new System.Drawing.Font("Yu Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.giris_sifre.Location = new System.Drawing.Point(101, 144);
            this.giris_sifre.Name = "giris_sifre";
            this.giris_sifre.Size = new System.Drawing.Size(78, 35);
            this.giris_sifre.TabIndex = 3;
            this.giris_sifre.Text = "Şifre";
            // 
            // txtSifre
            // 
            this.txtSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSifre.Location = new System.Drawing.Point(107, 181);
            this.txtSifre.Multiline = true;
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.PasswordChar = '*';
            this.txtSifre.Size = new System.Drawing.Size(304, 34);
            this.txtSifre.TabIndex = 1;
            this.txtSifre.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.txtSifre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // sifre_goster
            // 
            this.sifre_goster.AutoSize = true;
            this.sifre_goster.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sifre_goster.Location = new System.Drawing.Point(258, 233);
            this.sifre_goster.Name = "sifre_goster";
            this.sifre_goster.Size = new System.Drawing.Size(153, 30);
            this.sifre_goster.TabIndex = 5;
            this.sifre_goster.Text = "Şifre Göster";
            this.sifre_goster.UseVisualStyleBackColor = true;
            this.sifre_goster.CheckedChanged += new System.EventHandler(this.sifre_goster_CheckedChanged);
            // 
            // giris_buton
            // 
            this.giris_buton.Font = new System.Drawing.Font("Yu Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.giris_buton.Location = new System.Drawing.Point(275, 328);
            this.giris_buton.Name = "giris_buton";
            this.giris_buton.Size = new System.Drawing.Size(136, 44);
            this.giris_buton.TabIndex = 2;
            this.giris_buton.Text = "Giriş";
            this.giris_buton.UseVisualStyleBackColor = true;
            this.giris_buton.Click += new System.EventHandler(this.giris_buton_Click);
            // 
            // Kayit_buton
            // 
            this.Kayit_buton.Font = new System.Drawing.Font("Yu Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Kayit_buton.Location = new System.Drawing.Point(107, 328);
            this.Kayit_buton.Name = "Kayit_buton";
            this.Kayit_buton.Size = new System.Drawing.Size(136, 44);
            this.Kayit_buton.TabIndex = 7;
            this.Kayit_buton.Text = "Kayıt Ol";
            this.Kayit_buton.UseVisualStyleBackColor = true;
            this.Kayit_buton.Click += new System.EventHandler(this.Kayit_buton_Click);
            // 
            // guna2Button1
            // 
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(-315, 357);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(180, 45);
            this.guna2Button1.TabIndex = 8;
            this.guna2Button1.Text = "guna2Button1";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Kayit_buton);
            this.panel2.Controls.Add(this.giris_buton);
            this.panel2.Controls.Add(this.sifre_goster);
            this.panel2.Controls.Add(this.txtSifre);
            this.panel2.Controls.Add(this.giris_sifre);
            this.panel2.Controls.Add(this.txtGiris);
            this.panel2.Controls.Add(this.giris_no);
            this.panel2.Location = new System.Drawing.Point(1, 176);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(549, 415);
            this.panel2.TabIndex = 9;
            this.panel2.Visible = false;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // Giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 173);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Giris";
            this.Text = "Giris";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Giris_FormClosed);
            this.Load += new System.EventHandler(this.Giris_Load);
            this.Shown += new System.EventHandler(this.Giris_Shown);
            this.Click += new System.EventHandler(this.Giris_Click);
            this.Leave += new System.EventHandler(this.Giris_Leave);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label baslik;
        private System.Windows.Forms.Label giris_no;
        private System.Windows.Forms.TextBox txtGiris;
        private System.Windows.Forms.Label giris_sifre;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.CheckBox sifre_goster;
        private System.Windows.Forms.Button giris_buton;
        private System.Windows.Forms.Button Kayit_buton;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button mudur_button;
        private Guna.UI2.WinForms.Guna2Button temsilci_button;
        private Guna.UI2.WinForms.Guna2Button musteri_button;
        private System.Windows.Forms.Panel panel2;
    }
}