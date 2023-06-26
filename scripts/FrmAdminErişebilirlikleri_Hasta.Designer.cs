
namespace _200707048_VeyselÜstüntaş_HastaneOtomasyonu
{
    partial class FrmAdminErişebilirlikleri_Hasta
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
            this.picBxHome = new System.Windows.Forms.PictureBox();
            this.picBxUstDizin = new System.Windows.Forms.PictureBox();
            this.btnListele = new System.Windows.Forms.Button();
            this.btnAra = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnEkleGuncelle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAranacakHasta = new System.Windows.Forms.TextBox();
            this.txtSilinecekHasta = new System.Windows.Forms.TextBox();
            this.lblHastaId = new System.Windows.Forms.Label();
            this.lblAdminID = new System.Windows.Forms.Label();
            this.lblAdminAd = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBxHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBxUstDizin)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 299);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(774, 215);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // picBxHome
            // 
            this.picBxHome.Image = global::_200707048_VeyselÜstüntaş_HastaneOtomasyonu.Properties.Resources.home;
            this.picBxHome.Location = new System.Drawing.Point(753, 12);
            this.picBxHome.Name = "picBxHome";
            this.picBxHome.Size = new System.Drawing.Size(38, 27);
            this.picBxHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBxHome.TabIndex = 8;
            this.picBxHome.TabStop = false;
            this.picBxHome.Click += new System.EventHandler(this.picBxHome_Click);
            // 
            // picBxUstDizin
            // 
            this.picBxUstDizin.Image = global::_200707048_VeyselÜstüntaş_HastaneOtomasyonu.Properties.Resources._return;
            this.picBxUstDizin.Location = new System.Drawing.Point(709, 12);
            this.picBxUstDizin.Name = "picBxUstDizin";
            this.picBxUstDizin.Size = new System.Drawing.Size(38, 27);
            this.picBxUstDizin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBxUstDizin.TabIndex = 7;
            this.picBxUstDizin.TabStop = false;
            this.picBxUstDizin.Click += new System.EventHandler(this.picBxUstDizin_Click);
            // 
            // btnListele
            // 
            this.btnListele.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(204)))), ((int)(((byte)(175)))));
            this.btnListele.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnListele.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(35)))), ((int)(((byte)(23)))));
            this.btnListele.Image = global::_200707048_VeyselÜstüntaş_HastaneOtomasyonu.Properties.Resources.list__1_;
            this.btnListele.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnListele.Location = new System.Drawing.Point(12, 56);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(151, 58);
            this.btnListele.TabIndex = 9;
            this.btnListele.Text = "Hastaları\r\nListele";
            this.btnListele.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListele.UseVisualStyleBackColor = false;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // btnAra
            // 
            this.btnAra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(204)))), ((int)(((byte)(175)))));
            this.btnAra.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(35)))), ((int)(((byte)(23)))));
            this.btnAra.Image = global::_200707048_VeyselÜstüntaş_HastaneOtomasyonu.Properties.Resources.search__1_;
            this.btnAra.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAra.Location = new System.Drawing.Point(12, 137);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(151, 58);
            this.btnAra.TabIndex = 12;
            this.btnAra.Text = "Hasta Ara";
            this.btnAra.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAra.UseVisualStyleBackColor = false;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(204)))), ((int)(((byte)(175)))));
            this.btnSil.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(35)))), ((int)(((byte)(23)))));
            this.btnSil.Image = global::_200707048_VeyselÜstüntaş_HastaneOtomasyonu.Properties.Resources.delete__1_;
            this.btnSil.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSil.Location = new System.Drawing.Point(12, 218);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(151, 58);
            this.btnSil.TabIndex = 11;
            this.btnSil.Text = "Hasta Sil";
            this.btnSil.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnEkleGuncelle
            // 
            this.btnEkleGuncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(204)))), ((int)(((byte)(175)))));
            this.btnEkleGuncelle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkleGuncelle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(35)))), ((int)(((byte)(23)))));
            this.btnEkleGuncelle.Image = global::_200707048_VeyselÜstüntaş_HastaneOtomasyonu.Properties.Resources.plus__1_;
            this.btnEkleGuncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEkleGuncelle.Location = new System.Drawing.Point(607, 199);
            this.btnEkleGuncelle.Name = "btnEkleGuncelle";
            this.btnEkleGuncelle.Size = new System.Drawing.Size(179, 58);
            this.btnEkleGuncelle.TabIndex = 10;
            this.btnEkleGuncelle.Text = "Ekle veya \r\nGüncelle";
            this.btnEkleGuncelle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEkleGuncelle.UseVisualStyleBackColor = false;
            this.btnEkleGuncelle.Click += new System.EventHandler(this.btnEkleGuncelle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(77)))), ((int)(((byte)(103)))));
            this.label1.Location = new System.Drawing.Point(185, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 21);
            this.label1.TabIndex = 15;
            this.label1.Text = "Aranacak Hastanın ID\'si";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(77)))), ((int)(((byte)(103)))));
            this.label2.Location = new System.Drawing.Point(187, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 21);
            this.label2.TabIndex = 14;
            this.label2.Text = "Silinecek Hastanın ID\'si";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(77)))), ((int)(((byte)(103)))));
            this.label3.Location = new System.Drawing.Point(607, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 42);
            this.label3.TabIndex = 13;
            this.label3.Text = "Yeni Hasta Kaydı Ekle\r\nveya Kayıt Güncelle";
            // 
            // txtAranacakHasta
            // 
            this.txtAranacakHasta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(231)))), ((int)(((byte)(146)))));
            this.txtAranacakHasta.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAranacakHasta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(77)))), ((int)(((byte)(103)))));
            this.txtAranacakHasta.Location = new System.Drawing.Point(189, 166);
            this.txtAranacakHasta.Name = "txtAranacakHasta";
            this.txtAranacakHasta.Size = new System.Drawing.Size(164, 29);
            this.txtAranacakHasta.TabIndex = 17;
            // 
            // txtSilinecekHasta
            // 
            this.txtSilinecekHasta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(231)))), ((int)(((byte)(146)))));
            this.txtSilinecekHasta.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSilinecekHasta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(77)))), ((int)(((byte)(103)))));
            this.txtSilinecekHasta.Location = new System.Drawing.Point(191, 247);
            this.txtSilinecekHasta.Name = "txtSilinecekHasta";
            this.txtSilinecekHasta.Size = new System.Drawing.Size(164, 29);
            this.txtSilinecekHasta.TabIndex = 16;
            // 
            // lblHastaId
            // 
            this.lblHastaId.AutoSize = true;
            this.lblHastaId.Location = new System.Drawing.Point(309, 12);
            this.lblHastaId.Name = "lblHastaId";
            this.lblHastaId.Size = new System.Drawing.Size(0, 13);
            this.lblHastaId.TabIndex = 19;
            this.lblHastaId.Visible = false;
            // 
            // lblAdminID
            // 
            this.lblAdminID.AutoSize = true;
            this.lblAdminID.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminID.Location = new System.Drawing.Point(366, 67);
            this.lblAdminID.Name = "lblAdminID";
            this.lblAdminID.Size = new System.Drawing.Size(0, 15);
            this.lblAdminID.TabIndex = 20;
            this.lblAdminID.Visible = false;
            // 
            // lblAdminAd
            // 
            this.lblAdminAd.AutoSize = true;
            this.lblAdminAd.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminAd.Location = new System.Drawing.Point(12, 9);
            this.lblAdminAd.Name = "lblAdminAd";
            this.lblAdminAd.Size = new System.Drawing.Size(44, 15);
            this.lblAdminAd.TabIndex = 20;
            this.lblAdminAd.Text = "label6";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(204)))), ((int)(((byte)(175)))));
            this.button1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(35)))), ((int)(((byte)(23)))));
            this.button1.Location = new System.Drawing.Point(189, 56);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 58);
            this.button1.TabIndex = 21;
            this.button1.Text = "Hasta Sayısı Log Kayıtları";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(361, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(347, 30);
            this.label4.TabIndex = 22;
            this.label4.Text = "Sisteme Yeni Bir Hasta Kayıt Olduğunda, Kayıt Olduğu Tarihte \r\nHastanede Tedavi G" +
    "ören Hastaların Toplam Sayısını Gösterir.";
            // 
            // FrmAdminErişebilirlikleri_Hasta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(236)))), ((int)(((byte)(176)))));
            this.ClientSize = new System.Drawing.Size(803, 524);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblAdminAd);
            this.Controls.Add(this.lblAdminID);
            this.Controls.Add(this.lblHastaId);
            this.Controls.Add(this.txtSilinecekHasta);
            this.Controls.Add(this.txtAranacakHasta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEkleGuncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.picBxUstDizin);
            this.Controls.Add(this.picBxHome);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAdminErişebilirlikleri_Hasta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hasta Bilgi Ekranı | Hastane Otomasyonu";
            this.Load += new System.EventHandler(this.FrmAdminErişebilirlikleri_Hasta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBxHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBxUstDizin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox picBxHome;
        private System.Windows.Forms.PictureBox picBxUstDizin;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnEkleGuncelle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAranacakHasta;
        private System.Windows.Forms.TextBox txtSilinecekHasta;
        public System.Windows.Forms.Label lblHastaId;
        public System.Windows.Forms.Label lblAdminID;
        public System.Windows.Forms.Label lblAdminAd;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
    }
}