﻿namespace E_Okul_Projesi
{
    partial class FrmOgretmenGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOgretmenGiris));
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtSifre = new System.Windows.Forms.TextBox();
            this.MskTC = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnGirisYap = new System.Windows.Forms.Button();
            this.LnkLblAdmin = new System.Windows.Forms.LinkLabel();
            this.BtnGeriDon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(98, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 25);
            this.label3.TabIndex = 14;
            this.label3.Text = "Şifre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "Öğretmen TC:";
            // 
            // TxtSifre
            // 
            this.TxtSifre.Location = new System.Drawing.Point(166, 217);
            this.TxtSifre.Name = "TxtSifre";
            this.TxtSifre.Size = new System.Drawing.Size(451, 31);
            this.TxtSifre.TabIndex = 2;
            this.TxtSifre.UseSystemPasswordChar = true;
            // 
            // MskTC
            // 
            this.MskTC.Location = new System.Drawing.Point(166, 168);
            this.MskTC.Mask = "00000000000";
            this.MskTC.Name = "MskTC";
            this.MskTC.Size = new System.Drawing.Size(451, 31);
            this.MskTC.TabIndex = 1;
            this.MskTC.ValidatingType = typeof(int);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(517, 55);
            this.label1.TabIndex = 10;
            this.label1.Text = "Öğretmen Giriş Sistemi";
            // 
            // BtnGirisYap
            // 
            this.BtnGirisYap.Location = new System.Drawing.Point(497, 281);
            this.BtnGirisYap.Name = "BtnGirisYap";
            this.BtnGirisYap.Size = new System.Drawing.Size(120, 41);
            this.BtnGirisYap.TabIndex = 3;
            this.BtnGirisYap.Text = "Giriş Yap";
            this.BtnGirisYap.UseVisualStyleBackColor = true;
            this.BtnGirisYap.Click += new System.EventHandler(this.BtnGirisYap_Click);
            // 
            // LnkLblAdmin
            // 
            this.LnkLblAdmin.AutoSize = true;
            this.LnkLblAdmin.Location = new System.Drawing.Point(161, 289);
            this.LnkLblAdmin.Name = "LnkLblAdmin";
            this.LnkLblAdmin.Size = new System.Drawing.Size(127, 25);
            this.LnkLblAdmin.TabIndex = 15;
            this.LnkLblAdmin.TabStop = true;
            this.LnkLblAdmin.Text = "Admin Girişi";
            this.LnkLblAdmin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnkLblAdmin_LinkClicked);
            // 
            // BtnGeriDon
            // 
            this.BtnGeriDon.Location = new System.Drawing.Point(371, 281);
            this.BtnGeriDon.Name = "BtnGeriDon";
            this.BtnGeriDon.Size = new System.Drawing.Size(120, 41);
            this.BtnGeriDon.TabIndex = 16;
            this.BtnGeriDon.Text = "Geri Dön";
            this.BtnGeriDon.UseVisualStyleBackColor = true;
            this.BtnGeriDon.Click += new System.EventHandler(this.BtnGeriDon_Click);
            // 
            // FrmOgretmenGiris
            // 
            this.AcceptButton = this.BtnGirisYap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(629, 334);
            this.Controls.Add(this.BtnGeriDon);
            this.Controls.Add(this.LnkLblAdmin);
            this.Controls.Add(this.BtnGirisYap);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtSifre);
            this.Controls.Add(this.MskTC);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "FrmOgretmenGiris";
            this.Text = "Öğretmen Girişi";
            this.Load += new System.EventHandler(this.FrmOgretmenGiris_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtSifre;
        private System.Windows.Forms.MaskedTextBox MskTC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnGirisYap;
        private System.Windows.Forms.LinkLabel LnkLblAdmin;
        private System.Windows.Forms.Button BtnGeriDon;
    }
}