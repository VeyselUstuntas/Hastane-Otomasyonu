
namespace _200707048_VeyselÜstüntaş_HastaneOtomasyonu
{
    partial class FrmGirisEkrani
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGirisEkrani));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.HastaGirisEkrani = new System.Windows.Forms.PictureBox();
            this.AdminGirişEkrani = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HastaGirisEkrani)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AdminGirişEkrani)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(204)))), ((int)(((byte)(175)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(592, 106);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(77)))), ((int)(((byte)(103)))));
            this.label1.Location = new System.Drawing.Point(13, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(483, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hastane Otomasyonuna Hoşgeldiniz";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::_200707048_VeyselÜstüntaş_HastaneOtomasyonu.Properties.Resources.caduceus__1_;
            this.pictureBox1.Location = new System.Drawing.Point(503, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(86, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::_200707048_VeyselÜstüntaş_HastaneOtomasyonu.Properties.Resources.doctor;
            this.pictureBox3.Location = new System.Drawing.Point(407, 225);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(136, 86);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox3, "Yönetici Girişi");
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // HastaGirisEkrani
            // 
            this.HastaGirisEkrani.Image = global::_200707048_VeyselÜstüntaş_HastaneOtomasyonu.Properties.Resources.user;
            this.HastaGirisEkrani.Location = new System.Drawing.Point(230, 225);
            this.HastaGirisEkrani.Name = "HastaGirisEkrani";
            this.HastaGirisEkrani.Size = new System.Drawing.Size(136, 86);
            this.HastaGirisEkrani.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.HastaGirisEkrani.TabIndex = 5;
            this.HastaGirisEkrani.TabStop = false;
            this.toolTip1.SetToolTip(this.HastaGirisEkrani, "Hasta Girişi");
            this.HastaGirisEkrani.Click += new System.EventHandler(this.HastaGirisEkrani_Click);
            // 
            // AdminGirişEkrani
            // 
            this.AdminGirişEkrani.Image = global::_200707048_VeyselÜstüntaş_HastaneOtomasyonu.Properties.Resources.admin;
            this.AdminGirişEkrani.Location = new System.Drawing.Point(49, 225);
            this.AdminGirişEkrani.Name = "AdminGirişEkrani";
            this.AdminGirişEkrani.Size = new System.Drawing.Size(136, 86);
            this.AdminGirişEkrani.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AdminGirişEkrani.TabIndex = 4;
            this.AdminGirişEkrani.TabStop = false;
            this.toolTip1.SetToolTip(this.AdminGirişEkrani, "Admin Giriş");
            this.AdminGirişEkrani.Click += new System.EventHandler(this.AdminGirişEkrani_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(72, 314);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Admin Girişi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(257, 314);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Hasta Girişi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(430, 314);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Doktor Girişi";
            // 
            // FrmGirisEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(236)))), ((int)(((byte)(176)))));
            this.ClientSize = new System.Drawing.Size(592, 458);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.HastaGirisEkrani);
            this.Controls.Add(this.AdminGirişEkrani);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmGirisEkrani";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş Ekranı | Hastane Otomasyonu";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HastaGirisEkrani)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AdminGirişEkrani)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox AdminGirişEkrani;
        private System.Windows.Forms.PictureBox HastaGirisEkrani;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

