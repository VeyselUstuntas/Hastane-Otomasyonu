
namespace _200707048_VeyselÜstüntaş_HastaneOtomasyonu
{
    partial class FrmAdminErişebilirlikleri_Randevu
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbSaat = new System.Windows.Forms.ComboBox();
            this.cmbKlinik = new System.Windows.Forms.ComboBox();
            this.cmbDoktor = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnList = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnUpdt = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.picBxHome = new System.Windows.Forms.PictureBox();
            this.picBxUstDizin = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbHastane = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblAdminId = new System.Windows.Forms.Label();
            this.lblRandevuId = new System.Windows.Forms.Label();
            this.lblHastaneId = new System.Windows.Forms.Label();
            this.lblKlinikId = new System.Windows.Forms.Label();
            this.lblDokId = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtHastaId = new System.Windows.Forms.TextBox();
            this.lblHastaId = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBxHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBxUstDizin)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 329);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(866, 197);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(204)))), ((int)(((byte)(175)))));
            this.dateTimePicker1.Location = new System.Drawing.Point(141, 50);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(239, 27);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(77)))), ((int)(((byte)(103)))));
            this.label1.Location = new System.Drawing.Point(623, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(77)))), ((int)(((byte)(103)))));
            this.label2.Location = new System.Drawing.Point(673, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            // 
            // cmbSaat
            // 
            this.cmbSaat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(204)))), ((int)(((byte)(175)))));
            this.cmbSaat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(35)))), ((int)(((byte)(23)))));
            this.cmbSaat.FormattingEnabled = true;
            this.cmbSaat.Items.AddRange(new object[] {
            "09:00",
            "09:30",
            "10:00",
            "10:30",
            "11:00",
            "11:30",
            "13:00",
            "13:30",
            "14:00",
            "14:30",
            "15:00",
            "15:30",
            "16:00",
            "16:30"});
            this.cmbSaat.Location = new System.Drawing.Point(141, 95);
            this.cmbSaat.Name = "cmbSaat";
            this.cmbSaat.Size = new System.Drawing.Size(239, 28);
            this.cmbSaat.TabIndex = 4;
            // 
            // cmbKlinik
            // 
            this.cmbKlinik.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(204)))), ((int)(((byte)(175)))));
            this.cmbKlinik.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(35)))), ((int)(((byte)(23)))));
            this.cmbKlinik.FormattingEnabled = true;
            this.cmbKlinik.Location = new System.Drawing.Point(141, 174);
            this.cmbKlinik.Name = "cmbKlinik";
            this.cmbKlinik.Size = new System.Drawing.Size(239, 28);
            this.cmbKlinik.TabIndex = 5;
            this.cmbKlinik.SelectedIndexChanged += new System.EventHandler(this.cmbKlinik_SelectedIndexChanged);
            // 
            // cmbDoktor
            // 
            this.cmbDoktor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(204)))), ((int)(((byte)(175)))));
            this.cmbDoktor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(35)))), ((int)(((byte)(23)))));
            this.cmbDoktor.FormattingEnabled = true;
            this.cmbDoktor.Location = new System.Drawing.Point(141, 215);
            this.cmbDoktor.Name = "cmbDoktor";
            this.cmbDoktor.Size = new System.Drawing.Size(239, 28);
            this.cmbDoktor.TabIndex = 6;
            this.cmbDoktor.SelectedIndexChanged += new System.EventHandler(this.cmbDoktor_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Randevu Tarihi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Saat";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Poliklinik Seçiniz";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Doktor Seçiniz";
            // 
            // btnList
            // 
            this.btnList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(236)))), ((int)(((byte)(176)))));
            this.btnList.Image = global::_200707048_VeyselÜstüntaş_HastaneOtomasyonu.Properties.Resources.list__1_;
            this.btnList.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnList.Location = new System.Drawing.Point(12, 263);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(136, 60);
            this.btnList.TabIndex = 8;
            this.btnList.Text = "Randevuları\r\nListele";
            this.btnList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnList.UseVisualStyleBackColor = false;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(236)))), ((int)(((byte)(176)))));
            this.btnAdd.Image = global::_200707048_VeyselÜstüntaş_HastaneOtomasyonu.Properties.Resources.plus__1_;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.Location = new System.Drawing.Point(742, 262);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(136, 60);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Randevu\r\nEkle";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(236)))), ((int)(((byte)(176)))));
            this.btnSil.Image = global::_200707048_VeyselÜstüntaş_HastaneOtomasyonu.Properties.Resources.delete__1_;
            this.btnSil.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSil.Location = new System.Drawing.Point(154, 263);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(136, 60);
            this.btnSil.TabIndex = 10;
            this.btnSil.Text = "Randevu\r\nSil";
            this.btnSil.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnUpdt
            // 
            this.btnUpdt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(236)))), ((int)(((byte)(176)))));
            this.btnUpdt.Image = global::_200707048_VeyselÜstüntaş_HastaneOtomasyonu.Properties.Resources.updating__1_;
            this.btnUpdt.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdt.Location = new System.Drawing.Point(296, 263);
            this.btnUpdt.Name = "btnUpdt";
            this.btnUpdt.Size = new System.Drawing.Size(136, 60);
            this.btnUpdt.TabIndex = 11;
            this.btnUpdt.Text = "Randevu\r\nGüncelle\r\n";
            this.btnUpdt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdt.UseVisualStyleBackColor = false;
            this.btnUpdt.Click += new System.EventHandler(this.btnUpdt_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(77)))), ((int)(((byte)(103)))));
            this.label8.Location = new System.Drawing.Point(438, 281);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(243, 42);
            this.label8.TabIndex = 13;
            this.label8.Text = "Güncelleme ve Silme İçin\r\nRandevunun Üstüne Tıklayınız";
            // 
            // picBxHome
            // 
            this.picBxHome.Image = global::_200707048_VeyselÜstüntaş_HastaneOtomasyonu.Properties.Resources.home;
            this.picBxHome.Location = new System.Drawing.Point(836, 12);
            this.picBxHome.Name = "picBxHome";
            this.picBxHome.Size = new System.Drawing.Size(42, 25);
            this.picBxHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBxHome.TabIndex = 14;
            this.picBxHome.TabStop = false;
            this.picBxHome.Click += new System.EventHandler(this.picBxHome_Click);
            // 
            // picBxUstDizin
            // 
            this.picBxUstDizin.Image = global::_200707048_VeyselÜstüntaş_HastaneOtomasyonu.Properties.Resources._return;
            this.picBxUstDizin.Location = new System.Drawing.Point(788, 12);
            this.picBxUstDizin.Name = "picBxUstDizin";
            this.picBxUstDizin.Size = new System.Drawing.Size(42, 25);
            this.picBxUstDizin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBxUstDizin.TabIndex = 14;
            this.picBxUstDizin.TabStop = false;
            this.picBxUstDizin.Click += new System.EventHandler(this.picBxUstDizin_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(12, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(116, 17);
            this.label9.TabIndex = 15;
            this.label9.Text = "Admin Hoşgeldin";
            // 
            // cmbHastane
            // 
            this.cmbHastane.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(204)))), ((int)(((byte)(175)))));
            this.cmbHastane.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(35)))), ((int)(((byte)(23)))));
            this.cmbHastane.FormattingEnabled = true;
            this.cmbHastane.Location = new System.Drawing.Point(141, 133);
            this.cmbHastane.Name = "cmbHastane";
            this.cmbHastane.Size = new System.Drawing.Size(239, 28);
            this.cmbHastane.TabIndex = 5;
            this.cmbHastane.SelectedIndexChanged += new System.EventHandler(this.cmbHastane_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 136);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "Hastane Seçiniz";
            // 
            // lblAdminId
            // 
            this.lblAdminId.AutoSize = true;
            this.lblAdminId.Location = new System.Drawing.Point(434, 36);
            this.lblAdminId.Name = "lblAdminId";
            this.lblAdminId.Size = new System.Drawing.Size(0, 20);
            this.lblAdminId.TabIndex = 16;
            this.lblAdminId.Visible = false;
            // 
            // lblRandevuId
            // 
            this.lblRandevuId.AutoSize = true;
            this.lblRandevuId.Location = new System.Drawing.Point(434, 61);
            this.lblRandevuId.Name = "lblRandevuId";
            this.lblRandevuId.Size = new System.Drawing.Size(0, 20);
            this.lblRandevuId.TabIndex = 16;
            this.lblRandevuId.Visible = false;
            // 
            // lblHastaneId
            // 
            this.lblHastaneId.AutoSize = true;
            this.lblHastaneId.Location = new System.Drawing.Point(416, 133);
            this.lblHastaneId.Name = "lblHastaneId";
            this.lblHastaneId.Size = new System.Drawing.Size(0, 20);
            this.lblHastaneId.TabIndex = 16;
            this.lblHastaneId.Visible = false;
            // 
            // lblKlinikId
            // 
            this.lblKlinikId.AutoSize = true;
            this.lblKlinikId.Location = new System.Drawing.Point(416, 174);
            this.lblKlinikId.Name = "lblKlinikId";
            this.lblKlinikId.Size = new System.Drawing.Size(0, 20);
            this.lblKlinikId.TabIndex = 16;
            this.lblKlinikId.Visible = false;
            // 
            // lblDokId
            // 
            this.lblDokId.AutoSize = true;
            this.lblDokId.Location = new System.Drawing.Point(416, 223);
            this.lblDokId.Name = "lblDokId";
            this.lblDokId.Size = new System.Drawing.Size(0, 20);
            this.lblDokId.TabIndex = 16;
            this.lblDokId.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(77)))), ((int)(((byte)(103)))));
            this.label10.Location = new System.Drawing.Point(588, 213);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(142, 40);
            this.label10.TabIndex = 17;
            this.label10.Text = "Randevu Eklenecek\r\nHasta ID\'si";
            // 
            // txtHastaId
            // 
            this.txtHastaId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(236)))), ((int)(((byte)(176)))));
            this.txtHastaId.Font = new System.Drawing.Font("Segoe UI Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHastaId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(77)))), ((int)(((byte)(103)))));
            this.txtHastaId.Location = new System.Drawing.Point(742, 220);
            this.txtHastaId.Name = "txtHastaId";
            this.txtHastaId.Size = new System.Drawing.Size(136, 28);
            this.txtHastaId.TabIndex = 18;
            // 
            // lblHastaId
            // 
            this.lblHastaId.AutoSize = true;
            this.lblHastaId.Location = new System.Drawing.Point(523, 141);
            this.lblHastaId.Name = "lblHastaId";
            this.lblHastaId.Size = new System.Drawing.Size(0, 20);
            this.lblHastaId.TabIndex = 19;
            this.lblHastaId.Visible = false;
            // 
            // FrmAdminErişebilirlikleri_Randevu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(231)))), ((int)(((byte)(146)))));
            this.ClientSize = new System.Drawing.Size(890, 538);
            this.Controls.Add(this.lblHastaId);
            this.Controls.Add(this.txtHastaId);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblDokId);
            this.Controls.Add(this.lblKlinikId);
            this.Controls.Add(this.lblHastaneId);
            this.Controls.Add(this.lblRandevuId);
            this.Controls.Add(this.lblAdminId);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.picBxUstDizin);
            this.Controls.Add(this.picBxHome);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnUpdt);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbDoktor);
            this.Controls.Add(this.cmbHastane);
            this.Controls.Add(this.cmbKlinik);
            this.Controls.Add(this.cmbSaat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAdminErişebilirlikleri_Randevu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Randevu Ekranı | Hastane  Otomasyonu";
            this.Load += new System.EventHandler(this.FrmAdminErişebilirlikleri_Randevu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBxHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBxUstDizin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbSaat;
        private System.Windows.Forms.ComboBox cmbKlinik;
        private System.Windows.Forms.ComboBox cmbDoktor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnUpdt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox picBxHome;
        private System.Windows.Forms.PictureBox picBxUstDizin;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbHastane;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label lblAdminId;
        public System.Windows.Forms.Label lblRandevuId;
        public System.Windows.Forms.Label lblHastaneId;
        public System.Windows.Forms.Label lblKlinikId;
        public System.Windows.Forms.Label lblDokId;
        public System.Windows.Forms.Label label10;
        public System.Windows.Forms.TextBox txtHastaId;
        private System.Windows.Forms.Label lblHastaId;
    }
}