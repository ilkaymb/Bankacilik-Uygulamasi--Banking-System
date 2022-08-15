
namespace Prolab2_3
{
    partial class para_islem
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.baslik = new System.Windows.Forms.Label();
            this.txt_ust = new System.Windows.Forms.TextBox();
            this.ust = new System.Windows.Forms.Label();
            this.onay_buton = new System.Windows.Forms.Button();
            this.alt = new System.Windows.Forms.Label();
            this.txt_alt = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Sienna;
            this.panel1.Controls.Add(this.baslik);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(386, 80);
            this.panel1.TabIndex = 2;
            // 
            // baslik
            // 
            this.baslik.AutoSize = true;
            this.baslik.Font = new System.Drawing.Font("Perpetua Titling MT", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baslik.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.baslik.Location = new System.Drawing.Point(10, 25);
            this.baslik.Name = "baslik";
            this.baslik.Size = new System.Drawing.Size(351, 41);
            this.baslik.TabIndex = 3;
            this.baslik.Text = "GRİNGOTTS BANK";
            // 
            // txt_ust
            // 
            this.txt_ust.Font = new System.Drawing.Font("Yu Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_ust.Location = new System.Drawing.Point(30, 138);
            this.txt_ust.Multiline = true;
            this.txt_ust.Name = "txt_ust";
            this.txt_ust.Size = new System.Drawing.Size(290, 42);
            this.txt_ust.TabIndex = 14;
            // 
            // ust
            // 
            this.ust.AutoSize = true;
            this.ust.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ust.Location = new System.Drawing.Point(25, 107);
            this.ust.Name = "ust";
            this.ust.Size = new System.Drawing.Size(295, 28);
            this.ust.TabIndex = 11;
            this.ust.Text = "Havale Yapılacak Hesabı Giriniz";
            this.ust.Click += new System.EventHandler(this.ust_Click);
            // 
            // onay_buton
            // 
            this.onay_buton.Font = new System.Drawing.Font("Yu Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.onay_buton.Location = new System.Drawing.Point(184, 286);
            this.onay_buton.Name = "onay_buton";
            this.onay_buton.Size = new System.Drawing.Size(136, 44);
            this.onay_buton.TabIndex = 17;
            this.onay_buton.Text = "Onayla";
            this.onay_buton.UseVisualStyleBackColor = true;
            this.onay_buton.Click += new System.EventHandler(this.onay_buton_Click);
            // 
            // alt
            // 
            this.alt.AutoSize = true;
            this.alt.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.alt.Location = new System.Drawing.Point(25, 195);
            this.alt.Name = "alt";
            this.alt.Size = new System.Drawing.Size(196, 28);
            this.alt.TabIndex = 12;
            this.alt.Text = "Gönderilecek Miktar";
            this.alt.Click += new System.EventHandler(this.miktar_Click);
            // 
            // txt_alt
            // 
            this.txt_alt.Font = new System.Drawing.Font("Yu Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_alt.Location = new System.Drawing.Point(30, 226);
            this.txt_alt.Multiline = true;
            this.txt_alt.Name = "txt_alt";
            this.txt_alt.Size = new System.Drawing.Size(290, 42);
            this.txt_alt.TabIndex = 15;
            // 
            // para_islem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 367);
            this.Controls.Add(this.onay_buton);
            this.Controls.Add(this.txt_alt);
            this.Controls.Add(this.txt_ust);
            this.Controls.Add(this.alt);
            this.Controls.Add(this.ust);
            this.Controls.Add(this.panel1);
            this.Name = "para_islem";
            this.Text = "para_islem";
            this.Load += new System.EventHandler(this.para_islem_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label baslik;
        private System.Windows.Forms.TextBox txt_ust;
        private System.Windows.Forms.Label ust;
        private System.Windows.Forms.Button onay_buton;
        private System.Windows.Forms.Label alt;
        private System.Windows.Forms.TextBox txt_alt;
    }
}