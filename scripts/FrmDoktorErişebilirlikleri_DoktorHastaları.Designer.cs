
namespace _200707048_VeyselÜstüntaş_HastaneOtomasyonu
{
    partial class FrmDoktorErişebilirlikleri_DoktorHastaları
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblDoktorAdSoyad = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAra = new System.Windows.Forms.Button();
            this.btnListele = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.txtArancak = new System.Windows.Forms.TextBox();
            this.txtSilinecek = new System.Windows.Forms.TextBox();
            this.richTxtSikayet = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSika_IlacKadyt = new System.Windows.Forms.Button();
            this.txtDoktorId = new System.Windows.Forms.TextBox();
            this.txtYoneticiId = new System.Windows.Forms.TextBox();
            this.txtHastaId = new System.Windows.Forms.TextBox();
            this.cmbBxIlacAd = new System.Windows.Forms.ComboBox();
            this.btnIlacYaz = new System.Windows.Forms.Button();
            this.txtMuayeneId = new System.Windows.Forms.TextBox();
            this.btnTahlil = new System.Windows.Forms.Button();
            this.picBxReturn = new System.Windows.Forms.PictureBox();
            this.picBxHome = new System.Windows.Forms.PictureBox();
            this.txtKlinikId = new System.Windows.Forms.TextBox();
            this.txtHastaneId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBxReturn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBxHome)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 295);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(765, 219);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // lblDoktorAdSoyad
            // 
            this.lblDoktorAdSoyad.AutoSize = true;
            this.lblDoktorAdSoyad.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDoktorAdSoyad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(35)))), ((int)(((byte)(23)))));
            this.lblDoktorAdSoyad.Location = new System.Drawing.Point(12, 9);
            this.lblDoktorAdSoyad.Name = "lblDoktorAdSoyad";
            this.lblDoktorAdSoyad.Size = new System.Drawing.Size(44, 17);
            this.lblDoktorAdSoyad.TabIndex = 1;
            this.lblDoktorAdSoyad.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(129, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Silinecek Hasta ID\'si";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Şikayetleri";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(129, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Aranacak Hasta ID\'si";
            // 
            // btnAra
            // 
            this.btnAra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(231)))), ((int)(((byte)(146)))));
            this.btnAra.Font = new System.Drawing.Font("Segoe UI Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(77)))), ((int)(((byte)(103)))));
            this.btnAra.Location = new System.Drawing.Point(12, 112);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(111, 47);
            this.btnAra.TabIndex = 5;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = false;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // btnListele
            // 
            this.btnListele.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(231)))), ((int)(((byte)(146)))));
            this.btnListele.Font = new System.Drawing.Font("Segoe UI Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnListele.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(77)))), ((int)(((byte)(103)))));
            this.btnListele.Location = new System.Drawing.Point(12, 48);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(111, 47);
            this.btnListele.TabIndex = 5;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = false;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(231)))), ((int)(((byte)(146)))));
            this.btnSil.Font = new System.Drawing.Font("Segoe UI Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(77)))), ((int)(((byte)(103)))));
            this.btnSil.Location = new System.Drawing.Point(12, 176);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(111, 47);
            this.btnSil.TabIndex = 5;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // txtArancak
            // 
            this.txtArancak.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(231)))), ((int)(((byte)(146)))));
            this.txtArancak.Font = new System.Drawing.Font("Segoe UI Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtArancak.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(35)))), ((int)(((byte)(23)))));
            this.txtArancak.Location = new System.Drawing.Point(129, 131);
            this.txtArancak.Name = "txtArancak";
            this.txtArancak.Size = new System.Drawing.Size(125, 28);
            this.txtArancak.TabIndex = 6;
            // 
            // txtSilinecek
            // 
            this.txtSilinecek.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(231)))), ((int)(((byte)(146)))));
            this.txtSilinecek.Font = new System.Drawing.Font("Segoe UI Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSilinecek.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(35)))), ((int)(((byte)(23)))));
            this.txtSilinecek.Location = new System.Drawing.Point(129, 195);
            this.txtSilinecek.Name = "txtSilinecek";
            this.txtSilinecek.Size = new System.Drawing.Size(125, 28);
            this.txtSilinecek.TabIndex = 6;
            // 
            // richTxtSikayet
            // 
            this.richTxtSikayet.Location = new System.Drawing.Point(6, 54);
            this.richTxtSikayet.Name = "richTxtSikayet";
            this.richTxtSikayet.Size = new System.Drawing.Size(261, 96);
            this.richTxtSikayet.TabIndex = 7;
            this.richTxtSikayet.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSika_IlacKadyt);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.richTxtSikayet);
            this.groupBox1.Location = new System.Drawing.Point(502, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(275, 223);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // btnSika_IlacKadyt
            // 
            this.btnSika_IlacKadyt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(231)))), ((int)(((byte)(146)))));
            this.btnSika_IlacKadyt.Font = new System.Drawing.Font("Segoe UI Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSika_IlacKadyt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(77)))), ((int)(((byte)(103)))));
            this.btnSika_IlacKadyt.Location = new System.Drawing.Point(6, 166);
            this.btnSika_IlacKadyt.Name = "btnSika_IlacKadyt";
            this.btnSika_IlacKadyt.Size = new System.Drawing.Size(118, 43);
            this.btnSika_IlacKadyt.TabIndex = 8;
            this.btnSika_IlacKadyt.Text = "Kaydet";
            this.btnSika_IlacKadyt.UseVisualStyleBackColor = false;
            this.btnSika_IlacKadyt.Click += new System.EventHandler(this.btnSika_IlacKadyt_Click);
            // 
            // txtDoktorId
            // 
            this.txtDoktorId.Location = new System.Drawing.Point(486, 142);
            this.txtDoktorId.Name = "txtDoktorId";
            this.txtDoktorId.Size = new System.Drawing.Size(10, 27);
            this.txtDoktorId.TabIndex = 9;
            this.txtDoktorId.Visible = false;
            // 
            // txtYoneticiId
            // 
            this.txtYoneticiId.Location = new System.Drawing.Point(486, 172);
            this.txtYoneticiId.Name = "txtYoneticiId";
            this.txtYoneticiId.Size = new System.Drawing.Size(10, 27);
            this.txtYoneticiId.TabIndex = 9;
            this.txtYoneticiId.Visible = false;
            // 
            // txtHastaId
            // 
            this.txtHastaId.Location = new System.Drawing.Point(486, 202);
            this.txtHastaId.Name = "txtHastaId";
            this.txtHastaId.Size = new System.Drawing.Size(10, 27);
            this.txtHastaId.TabIndex = 9;
            this.txtHastaId.Visible = false;
            // 
            // cmbBxIlacAd
            // 
            this.cmbBxIlacAd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(231)))), ((int)(((byte)(146)))));
            this.cmbBxIlacAd.Font = new System.Drawing.Font("Segoe UI Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbBxIlacAd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(77)))), ((int)(((byte)(103)))));
            this.cmbBxIlacAd.FormattingEnabled = true;
            this.cmbBxIlacAd.Location = new System.Drawing.Point(129, 259);
            this.cmbBxIlacAd.Name = "cmbBxIlacAd";
            this.cmbBxIlacAd.Size = new System.Drawing.Size(125, 28);
            this.cmbBxIlacAd.TabIndex = 9;
            // 
            // btnIlacYaz
            // 
            this.btnIlacYaz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(231)))), ((int)(((byte)(146)))));
            this.btnIlacYaz.Font = new System.Drawing.Font("Segoe UI Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIlacYaz.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(77)))), ((int)(((byte)(103)))));
            this.btnIlacYaz.Location = new System.Drawing.Point(12, 240);
            this.btnIlacYaz.Name = "btnIlacYaz";
            this.btnIlacYaz.Size = new System.Drawing.Size(108, 47);
            this.btnIlacYaz.TabIndex = 25;
            this.btnIlacYaz.Text = "İlaç Yaz";
            this.btnIlacYaz.UseVisualStyleBackColor = false;
            this.btnIlacYaz.Click += new System.EventHandler(this.btnIlacYaz_Click);
            // 
            // txtMuayeneId
            // 
            this.txtMuayeneId.Location = new System.Drawing.Point(486, 232);
            this.txtMuayeneId.Name = "txtMuayeneId";
            this.txtMuayeneId.Size = new System.Drawing.Size(10, 27);
            this.txtMuayeneId.TabIndex = 9;
            this.txtMuayeneId.Visible = false;
            // 
            // btnTahlil
            // 
            this.btnTahlil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(231)))), ((int)(((byte)(146)))));
            this.btnTahlil.Font = new System.Drawing.Font("Segoe UI Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTahlil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(77)))), ((int)(((byte)(103)))));
            this.btnTahlil.Location = new System.Drawing.Point(129, 48);
            this.btnTahlil.Name = "btnTahlil";
            this.btnTahlil.Size = new System.Drawing.Size(125, 47);
            this.btnTahlil.TabIndex = 26;
            this.btnTahlil.Text = "Tahliller";
            this.btnTahlil.UseVisualStyleBackColor = false;
            this.btnTahlil.Click += new System.EventHandler(this.btnTahlil_Click);
            // 
            // picBxReturn
            // 
            this.picBxReturn.Image = global::_200707048_VeyselÜstüntaş_HastaneOtomasyonu.Properties.Resources._return;
            this.picBxReturn.Location = new System.Drawing.Point(695, 12);
            this.picBxReturn.Name = "picBxReturn";
            this.picBxReturn.Size = new System.Drawing.Size(38, 25);
            this.picBxReturn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBxReturn.TabIndex = 24;
            this.picBxReturn.TabStop = false;
            this.picBxReturn.Click += new System.EventHandler(this.picBxReturn_Click);
            // 
            // picBxHome
            // 
            this.picBxHome.Image = global::_200707048_VeyselÜstüntaş_HastaneOtomasyonu.Properties.Resources.home;
            this.picBxHome.Location = new System.Drawing.Point(739, 12);
            this.picBxHome.Name = "picBxHome";
            this.picBxHome.Size = new System.Drawing.Size(38, 25);
            this.picBxHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBxHome.TabIndex = 23;
            this.picBxHome.TabStop = false;
            this.picBxHome.Click += new System.EventHandler(this.picBxHome_Click);
            // 
            // txtKlinikId
            // 
            this.txtKlinikId.Location = new System.Drawing.Point(486, 112);
            this.txtKlinikId.Name = "txtKlinikId";
            this.txtKlinikId.Size = new System.Drawing.Size(10, 27);
            this.txtKlinikId.TabIndex = 27;
            this.txtKlinikId.Visible = false;
            // 
            // txtHastaneId
            // 
            this.txtHastaneId.Location = new System.Drawing.Point(486, 82);
            this.txtHastaneId.Name = "txtHastaneId";
            this.txtHastaneId.Size = new System.Drawing.Size(10, 27);
            this.txtHastaneId.TabIndex = 27;
            this.txtHastaneId.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(260, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 30);
            this.label1.TabIndex = 28;
            this.label1.Text = "Tahlil Eklemek İçin Öncelikle \r\nVeri Kısmından Hasta Seçmelisiniz.";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(231)))), ((int)(((byte)(146)))));
            this.button1.Font = new System.Drawing.Font("Segoe UI Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(77)))), ((int)(((byte)(103)))));
            this.button1.Location = new System.Drawing.Point(324, 237);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 52);
            this.button1.TabIndex = 29;
            this.button1.Text = "Hasta Sayım";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmDoktorErişebilirlikleri_DoktorHastaları
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(236)))), ((int)(((byte)(176)))));
            this.ClientSize = new System.Drawing.Size(794, 526);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtHastaneId);
            this.Controls.Add(this.txtKlinikId);
            this.Controls.Add(this.btnTahlil);
            this.Controls.Add(this.btnIlacYaz);
            this.Controls.Add(this.cmbBxIlacAd);
            this.Controls.Add(this.picBxReturn);
            this.Controls.Add(this.txtMuayeneId);
            this.Controls.Add(this.txtHastaId);
            this.Controls.Add(this.txtYoneticiId);
            this.Controls.Add(this.picBxHome);
            this.Controls.Add(this.txtDoktorId);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtSilinecek);
            this.Controls.Add(this.txtArancak);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblDoktorAdSoyad);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDoktorErişebilirlikleri_DoktorHastaları";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hastalarım | Doktor Erişebilirlikleri";
            this.Load += new System.EventHandler(this.FrmDoktorErişebilirlikleri_DoktorHastaları_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBxReturn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBxHome)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblDoktorAdSoyad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.TextBox txtArancak;
        private System.Windows.Forms.TextBox txtSilinecek;
        private System.Windows.Forms.RichTextBox richTxtSikayet;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSika_IlacKadyt;
        public System.Windows.Forms.TextBox txtDoktorId;
        public System.Windows.Forms.TextBox txtYoneticiId;
        private System.Windows.Forms.PictureBox picBxReturn;
        private System.Windows.Forms.PictureBox picBxHome;
        public System.Windows.Forms.TextBox txtHastaId;
        private System.Windows.Forms.ComboBox cmbBxIlacAd;
        private System.Windows.Forms.Button btnIlacYaz;
        public System.Windows.Forms.TextBox txtMuayeneId;
        private System.Windows.Forms.Button btnTahlil;
        public System.Windows.Forms.TextBox txtKlinikId;
        public System.Windows.Forms.TextBox txtHastaneId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}