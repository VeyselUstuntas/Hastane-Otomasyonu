
namespace _200707048_VeyselÜstüntaş_HastaneOtomasyonu
{
    partial class FrmDoktorErişebilirlikleri_HastaEkle
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
            this.picBxReturn = new System.Windows.Forms.PictureBox();
            this.picBxHome = new System.Windows.Forms.PictureBox();
            this.label14 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.mskSifre = new System.Windows.Forms.MaskedTextBox();
            this.btnKayitOl = new System.Windows.Forms.Button();
            this.mskTc = new System.Windows.Forms.MaskedTextBox();
            this.mksTel = new System.Windows.Forms.MaskedTextBox();
            this.cmbCins = new System.Windows.Forms.ComboBox();
            this.richtxtAdres = new System.Windows.Forms.RichTextBox();
            this.cmbKanGrb = new System.Windows.Forms.ComboBox();
            this.txtAnneAd = new System.Windows.Forms.TextBox();
            this.txtBabaAd = new System.Windows.Forms.TextBox();
            this.txtKullAd = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtKlinikId = new System.Windows.Forms.TextBox();
            this.txtHasID = new System.Windows.Forms.TextBox();
            this.txtDoktorID = new System.Windows.Forms.TextBox();
            this.txtYoneticiId = new System.Windows.Forms.TextBox();
            this.txtDogumT = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBxReturn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBxHome)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // picBxReturn
            // 
            this.picBxReturn.Image = global::_200707048_VeyselÜstüntaş_HastaneOtomasyonu.Properties.Resources._return;
            this.picBxReturn.Location = new System.Drawing.Point(531, 13);
            this.picBxReturn.Name = "picBxReturn";
            this.picBxReturn.Size = new System.Drawing.Size(38, 25);
            this.picBxReturn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBxReturn.TabIndex = 22;
            this.picBxReturn.TabStop = false;
            this.picBxReturn.Click += new System.EventHandler(this.picBxReturn_Click);
            // 
            // picBxHome
            // 
            this.picBxHome.Image = global::_200707048_VeyselÜstüntaş_HastaneOtomasyonu.Properties.Resources.home;
            this.picBxHome.Location = new System.Drawing.Point(575, 13);
            this.picBxHome.Name = "picBxHome";
            this.picBxHome.Size = new System.Drawing.Size(38, 25);
            this.picBxHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBxHome.TabIndex = 21;
            this.picBxHome.TabStop = false;
            this.picBxHome.Click += new System.EventHandler(this.picBxHome_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(304, 316);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(276, 20);
            this.label14.TabIndex = 20;
            this.label14.Text = "Şifre 5 karakterli Sayısal Değer Olmalıdır";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBox1.Location = new System.Drawing.Point(408, 292);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(107, 21);
            this.checkBox1.TabIndex = 14;
            this.checkBox1.Text = "Şifreyi Göster";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckStateChanged += new System.EventHandler(this.checkBox1_CheckStateChanged);
            // 
            // mskSifre
            // 
            this.mskSifre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(231)))), ((int)(((byte)(146)))));
            this.mskSifre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(77)))), ((int)(((byte)(103)))));
            this.mskSifre.Location = new System.Drawing.Point(408, 259);
            this.mskSifre.Mask = "00000";
            this.mskSifre.Name = "mskSifre";
            this.mskSifre.Size = new System.Drawing.Size(150, 27);
            this.mskSifre.TabIndex = 13;
            this.mskSifre.UseSystemPasswordChar = true;
            this.mskSifre.ValidatingType = typeof(int);
            // 
            // btnKayitOl
            // 
            this.btnKayitOl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(77)))), ((int)(((byte)(103)))));
            this.btnKayitOl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(231)))), ((int)(((byte)(146)))));
            this.btnKayitOl.Location = new System.Drawing.Point(408, 350);
            this.btnKayitOl.Name = "btnKayitOl";
            this.btnKayitOl.Size = new System.Drawing.Size(150, 66);
            this.btnKayitOl.TabIndex = 15;
            this.btnKayitOl.Text = "Hastayı Kaydet";
            this.btnKayitOl.UseVisualStyleBackColor = false;
            this.btnKayitOl.Click += new System.EventHandler(this.btnKayitOl_Click);
            // 
            // mskTc
            // 
            this.mskTc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(231)))), ((int)(((byte)(146)))));
            this.mskTc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(77)))), ((int)(((byte)(103)))));
            this.mskTc.Location = new System.Drawing.Point(112, 118);
            this.mskTc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mskTc.Mask = "00000000000";
            this.mskTc.Name = "mskTc";
            this.mskTc.Size = new System.Drawing.Size(150, 27);
            this.mskTc.TabIndex = 3;
            // 
            // mksTel
            // 
            this.mksTel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(231)))), ((int)(((byte)(146)))));
            this.mksTel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(77)))), ((int)(((byte)(103)))));
            this.mksTel.Location = new System.Drawing.Point(112, 301);
            this.mksTel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mksTel.Mask = "0(999) 000-0000";
            this.mksTel.Name = "mksTel";
            this.mksTel.Size = new System.Drawing.Size(150, 27);
            this.mksTel.TabIndex = 7;
            // 
            // cmbCins
            // 
            this.cmbCins.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(231)))), ((int)(((byte)(146)))));
            this.cmbCins.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(77)))), ((int)(((byte)(103)))));
            this.cmbCins.FormattingEnabled = true;
            this.cmbCins.Items.AddRange(new object[] {
            "E",
            "K"});
            this.cmbCins.Location = new System.Drawing.Point(112, 256);
            this.cmbCins.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbCins.Name = "cmbCins";
            this.cmbCins.Size = new System.Drawing.Size(150, 28);
            this.cmbCins.TabIndex = 5;
            // 
            // richtxtAdres
            // 
            this.richtxtAdres.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(231)))), ((int)(((byte)(146)))));
            this.richtxtAdres.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(77)))), ((int)(((byte)(103)))));
            this.richtxtAdres.Location = new System.Drawing.Point(112, 485);
            this.richtxtAdres.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.richtxtAdres.Name = "richtxtAdres";
            this.richtxtAdres.Size = new System.Drawing.Size(150, 84);
            this.richtxtAdres.TabIndex = 11;
            this.richtxtAdres.Text = "";
            // 
            // cmbKanGrb
            // 
            this.cmbKanGrb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(231)))), ((int)(((byte)(146)))));
            this.cmbKanGrb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(77)))), ((int)(((byte)(103)))));
            this.cmbKanGrb.FormattingEnabled = true;
            this.cmbKanGrb.Items.AddRange(new object[] {
            "A Rh+",
            "A Rh-",
            "B Rh+",
            "B Rh-",
            "AB Rh+",
            "AB Rh-",
            "0 Rh+",
            "0 Rh-"});
            this.cmbKanGrb.Location = new System.Drawing.Point(112, 209);
            this.cmbKanGrb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbKanGrb.Name = "cmbKanGrb";
            this.cmbKanGrb.Size = new System.Drawing.Size(150, 28);
            this.cmbKanGrb.TabIndex = 5;
            // 
            // txtAnneAd
            // 
            this.txtAnneAd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(231)))), ((int)(((byte)(146)))));
            this.txtAnneAd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(77)))), ((int)(((byte)(103)))));
            this.txtAnneAd.Location = new System.Drawing.Point(112, 439);
            this.txtAnneAd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAnneAd.Name = "txtAnneAd";
            this.txtAnneAd.Size = new System.Drawing.Size(150, 27);
            this.txtAnneAd.TabIndex = 10;
            // 
            // txtBabaAd
            // 
            this.txtBabaAd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(231)))), ((int)(((byte)(146)))));
            this.txtBabaAd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(77)))), ((int)(((byte)(103)))));
            this.txtBabaAd.Location = new System.Drawing.Point(112, 393);
            this.txtBabaAd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBabaAd.Name = "txtBabaAd";
            this.txtBabaAd.Size = new System.Drawing.Size(150, 27);
            this.txtBabaAd.TabIndex = 9;
            // 
            // txtKullAd
            // 
            this.txtKullAd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(231)))), ((int)(((byte)(146)))));
            this.txtKullAd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(77)))), ((int)(((byte)(103)))));
            this.txtKullAd.Location = new System.Drawing.Point(408, 213);
            this.txtKullAd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtKullAd.Name = "txtKullAd";
            this.txtKullAd.Size = new System.Drawing.Size(150, 27);
            this.txtKullAd.TabIndex = 12;
            // 
            // txtMail
            // 
            this.txtMail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(231)))), ((int)(((byte)(146)))));
            this.txtMail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(77)))), ((int)(((byte)(103)))));
            this.txtMail.Location = new System.Drawing.Point(112, 347);
            this.txtMail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(150, 27);
            this.txtMail.TabIndex = 8;
            // 
            // txtSoyad
            // 
            this.txtSoyad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(231)))), ((int)(((byte)(146)))));
            this.txtSoyad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(77)))), ((int)(((byte)(103)))));
            this.txtSoyad.Location = new System.Drawing.Point(112, 72);
            this.txtSoyad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(150, 27);
            this.txtSoyad.TabIndex = 2;
            // 
            // txtAd
            // 
            this.txtAd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(231)))), ((int)(((byte)(146)))));
            this.txtAd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(77)))), ((int)(((byte)(103)))));
            this.txtAd.Location = new System.Drawing.Point(112, 26);
            this.txtAd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(150, 27);
            this.txtAd.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 488);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 20);
            this.label10.TabIndex = 9;
            this.label10.Text = "Adres";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 442);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 20);
            this.label9.TabIndex = 8;
            this.label9.Text = "Anne Adı";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(304, 262);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(40, 20);
            this.label13.TabIndex = 7;
            this.label13.Text = "Şifre";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 396);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Baba Adı";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(304, 216);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(94, 20);
            this.label12.TabIndex = 6;
            this.label12.Text = "Kullanıcı Adı";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 351);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Mail";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 305);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Telefon";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 259);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Cinsiyet";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Kan Grubu";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 167);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(102, 20);
            this.label11.TabIndex = 2;
            this.label11.Text = "Doğum Tarihi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "TC No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyadı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adı";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtKlinikId);
            this.groupBox1.Controls.Add(this.txtHasID);
            this.groupBox1.Controls.Add(this.txtDoktorID);
            this.groupBox1.Controls.Add(this.txtYoneticiId);
            this.groupBox1.Controls.Add(this.picBxReturn);
            this.groupBox1.Controls.Add(this.picBxHome);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.mskSifre);
            this.groupBox1.Controls.Add(this.btnKayitOl);
            this.groupBox1.Controls.Add(this.mskTc);
            this.groupBox1.Controls.Add(this.mksTel);
            this.groupBox1.Controls.Add(this.cmbCins);
            this.groupBox1.Controls.Add(this.richtxtAdres);
            this.groupBox1.Controls.Add(this.cmbKanGrb);
            this.groupBox1.Controls.Add(this.txtAnneAd);
            this.groupBox1.Controls.Add(this.txtBabaAd);
            this.groupBox1.Controls.Add(this.txtKullAd);
            this.groupBox1.Controls.Add(this.txtMail);
            this.groupBox1.Controls.Add(this.txtDogumT);
            this.groupBox1.Controls.Add(this.txtSoyad);
            this.groupBox1.Controls.Add(this.txtAd);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(620, 592);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hasta Bilgileri";
            // 
            // txtKlinikId
            // 
            this.txtKlinikId.Location = new System.Drawing.Point(332, 151);
            this.txtKlinikId.Name = "txtKlinikId";
            this.txtKlinikId.Size = new System.Drawing.Size(122, 27);
            this.txtKlinikId.TabIndex = 2;
            this.txtKlinikId.Visible = false;
            // 
            // txtHasID
            // 
            this.txtHasID.Location = new System.Drawing.Point(332, 118);
            this.txtHasID.Name = "txtHasID";
            this.txtHasID.Size = new System.Drawing.Size(122, 27);
            this.txtHasID.TabIndex = 2;
            this.txtHasID.Visible = false;
            // 
            // txtDoktorID
            // 
            this.txtDoktorID.Location = new System.Drawing.Point(332, 80);
            this.txtDoktorID.Name = "txtDoktorID";
            this.txtDoktorID.Size = new System.Drawing.Size(122, 27);
            this.txtDoktorID.TabIndex = 2;
            this.txtDoktorID.Visible = false;
            // 
            // txtYoneticiId
            // 
            this.txtYoneticiId.Location = new System.Drawing.Point(332, 47);
            this.txtYoneticiId.Name = "txtYoneticiId";
            this.txtYoneticiId.Size = new System.Drawing.Size(122, 27);
            this.txtYoneticiId.TabIndex = 2;
            this.txtYoneticiId.Visible = false;
            // 
            // txtDogumT
            // 
            this.txtDogumT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(231)))), ((int)(((byte)(146)))));
            this.txtDogumT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(77)))), ((int)(((byte)(103)))));
            this.txtDogumT.Location = new System.Drawing.Point(112, 160);
            this.txtDogumT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDogumT.Name = "txtDogumT";
            this.txtDogumT.Size = new System.Drawing.Size(150, 27);
            this.txtDogumT.TabIndex = 2;
            // 
            // FrmDoktorErişebilirlikleri_HastaEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(204)))), ((int)(((byte)(175)))));
            this.ClientSize = new System.Drawing.Size(648, 598);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDoktorErişebilirlikleri_HastaEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doktor Erişebilirlikleri Hasta Ekle";
            this.Load += new System.EventHandler(this.FrmDoktorErişebilirlikleri_HastaEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBxReturn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBxHome)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picBxReturn;
        private System.Windows.Forms.PictureBox picBxHome;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.MaskedTextBox mskSifre;
        private System.Windows.Forms.Button btnKayitOl;
        private System.Windows.Forms.MaskedTextBox mskTc;
        private System.Windows.Forms.MaskedTextBox mksTel;
        private System.Windows.Forms.ComboBox cmbCins;
        private System.Windows.Forms.RichTextBox richtxtAdres;
        private System.Windows.Forms.ComboBox cmbKanGrb;
        private System.Windows.Forms.TextBox txtAnneAd;
        private System.Windows.Forms.TextBox txtBabaAd;
        private System.Windows.Forms.TextBox txtKullAd;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.TextBox txtDoktorID;
        public System.Windows.Forms.TextBox txtYoneticiId;
        public System.Windows.Forms.TextBox txtKlinikId;
        public System.Windows.Forms.TextBox txtHasID;
        private System.Windows.Forms.TextBox txtDogumT;
    }
}