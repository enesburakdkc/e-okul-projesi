namespace E_Okul_Projesi
{
    partial class FrmOgretmenDetay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOgretmenDetay));
            this.BtnSonuclarOgretmen = new System.Windows.Forms.Button();
            this.LblBrans = new System.Windows.Forms.Label();
            this.LblSoyad = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnGirisEkrani = new System.Windows.Forms.Button();
            this.BtnDevamsizlikOgretmen = new System.Windows.Forms.Button();
            this.BtnDuyuruOgretmen = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.LblTC = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LblAd = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnSonuclarOgretmen
            // 
            this.BtnSonuclarOgretmen.Location = new System.Drawing.Point(6, 93);
            this.BtnSonuclarOgretmen.Name = "BtnSonuclarOgretmen";
            this.BtnSonuclarOgretmen.Size = new System.Drawing.Size(407, 46);
            this.BtnSonuclarOgretmen.TabIndex = 2;
            this.BtnSonuclarOgretmen.Text = "Sınavlar/Sözlüler";
            this.BtnSonuclarOgretmen.UseVisualStyleBackColor = true;
            this.BtnSonuclarOgretmen.Click += new System.EventHandler(this.BtnSonuclarOgretmen_Click);
            // 
            // LblBrans
            // 
            this.LblBrans.AutoSize = true;
            this.LblBrans.Location = new System.Drawing.Point(91, 99);
            this.LblBrans.Name = "LblBrans";
            this.LblBrans.Size = new System.Drawing.Size(49, 25);
            this.LblBrans.TabIndex = 6;
            this.LblBrans.Text = "Null";
            // 
            // LblSoyad
            // 
            this.LblSoyad.AutoSize = true;
            this.LblSoyad.Location = new System.Drawing.Point(91, 74);
            this.LblSoyad.Name = "LblSoyad";
            this.LblSoyad.Size = new System.Drawing.Size(49, 25);
            this.LblSoyad.TabIndex = 5;
            this.LblSoyad.Text = "Null";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Branş:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyad:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnGirisEkrani);
            this.groupBox2.Controls.Add(this.BtnDevamsizlikOgretmen);
            this.groupBox2.Controls.Add(this.BtnDuyuruOgretmen);
            this.groupBox2.Controls.Add(this.BtnSonuclarOgretmen);
            this.groupBox2.Location = new System.Drawing.Point(12, 214);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(419, 250);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "İşlemler";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // BtnGirisEkrani
            // 
            this.BtnGirisEkrani.Location = new System.Drawing.Point(6, 197);
            this.BtnGirisEkrani.Name = "BtnGirisEkrani";
            this.BtnGirisEkrani.Size = new System.Drawing.Size(407, 46);
            this.BtnGirisEkrani.TabIndex = 6;
            this.BtnGirisEkrani.Text = "Giriş Ekranına Dön";
            this.BtnGirisEkrani.UseVisualStyleBackColor = true;
            this.BtnGirisEkrani.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnDevamsizlikOgretmen
            // 
            this.BtnDevamsizlikOgretmen.Location = new System.Drawing.Point(6, 41);
            this.BtnDevamsizlikOgretmen.Name = "BtnDevamsizlikOgretmen";
            this.BtnDevamsizlikOgretmen.Size = new System.Drawing.Size(407, 46);
            this.BtnDevamsizlikOgretmen.TabIndex = 1;
            this.BtnDevamsizlikOgretmen.Text = "Öğrenci Devamsızlık";
            this.BtnDevamsizlikOgretmen.UseVisualStyleBackColor = true;
            this.BtnDevamsizlikOgretmen.Click += new System.EventHandler(this.BtnDevamsizlikOgretmen_Click);
            // 
            // BtnDuyuruOgretmen
            // 
            this.BtnDuyuruOgretmen.Location = new System.Drawing.Point(6, 145);
            this.BtnDuyuruOgretmen.Name = "BtnDuyuruOgretmen";
            this.BtnDuyuruOgretmen.Size = new System.Drawing.Size(407, 46);
            this.BtnDuyuruOgretmen.TabIndex = 3;
            this.BtnDuyuruOgretmen.Text = "Duyuru Ekle";
            this.BtnDuyuruOgretmen.UseVisualStyleBackColor = true;
            this.BtnDuyuruOgretmen.Click += new System.EventHandler(this.BtnDuyuruOgretmen_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.LblTC);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.LblBrans);
            this.groupBox4.Controls.Add(this.LblAd);
            this.groupBox4.Controls.Add(this.LblSoyad);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Location = new System.Drawing.Point(12, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(419, 196);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Bilgiler";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // LblTC
            // 
            this.LblTC.AutoSize = true;
            this.LblTC.Location = new System.Drawing.Point(91, 124);
            this.LblTC.Name = "LblTC";
            this.LblTC.Size = new System.Drawing.Size(49, 25);
            this.LblTC.TabIndex = 8;
            this.LblTC.Text = "Null";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "TC:";
            // 
            // LblAd
            // 
            this.LblAd.AutoSize = true;
            this.LblAd.Location = new System.Drawing.Point(91, 49);
            this.LblAd.Name = "LblAd";
            this.LblAd.Size = new System.Drawing.Size(49, 25);
            this.LblAd.TabIndex = 4;
            this.LblAd.Text = "Null";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(41, 49);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 25);
            this.label9.TabIndex = 0;
            this.label9.Text = "Ad:";
            // 
            // FrmOgretmenDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(443, 477);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox4);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "FrmOgretmenDetay";
            this.Text = "Öğretmen Arayüz";
            this.Load += new System.EventHandler(this.FrmOgretmenDetay_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BtnSonuclarOgretmen;
        private System.Windows.Forms.Label LblBrans;
        private System.Windows.Forms.Label LblSoyad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnDuyuruOgretmen;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label LblAd;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button BtnDevamsizlikOgretmen;
        private System.Windows.Forms.Label LblTC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnGirisEkrani;
    }
}