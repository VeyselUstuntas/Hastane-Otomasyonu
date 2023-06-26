
namespace _200707048_VeyselÜstüntaş_HastaneOtomasyonu
{
    partial class FrmHastaErişebilirlikleri_Randevu
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
            this.picBxUstDizin = new System.Windows.Forms.PictureBox();
            this.picBxHome = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnUpdt = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnList = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbDoktor = new System.Windows.Forms.ComboBox();
            this.cmbKlinik = new System.Windows.Forms.ComboBox();
            this.cmbSaat = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbHastane = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtHastaneId = new System.Windows.Forms.TextBox();
            this.txtKlinikId = new System.Windows.Forms.TextBox();
            this.txtDoktorId = new System.Windows.Forms.TextBox();
            this.lblSilinecekId = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBxUstDizin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBxHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // picBxUstDizin
            // 
            this.picBxUstDizin.Image = global::_200707048_VeyselÜstüntaş_HastaneOtomasyonu.Properties.Resources._return;
            this.picBxUstDizin.Location = new System.Drawing.Point(788, 11);
            this.picBxUstDizin.Name = "picBxUstDizin";
            this.picBxUstDizin.Size = new System.Drawing.Size(42, 25);
            this.picBxUstDizin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBxUstDizin.TabIndex = 33;
            this.picBxUstDizin.TabStop = false;
            this.picBxUstDizin.Click += new System.EventHandler(this.picBxUstDizin_Click);
            // 
            // picBxHome
            // 
            this.picBxHome.Image = global::_200707048_VeyselÜstüntaş_HastaneOtomasyonu.Properties.Resources.home;
            this.picBxHome.Location = new System.Drawing.Point(836, 11);
            this.picBxHome.Name = "picBxHome";
            this.picBxHome.Size = new System.Drawing.Size(42, 25);
            this.picBxHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBxHome.TabIndex = 32;
            this.picBxHome.TabStop = false;
            this.picBxHome.Click += new System.EventHandler(this.picBxHome_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(77)))), ((int)(((byte)(103)))));
            this.label8.Location = new System.Drawing.Point(626, 253);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(243, 42);
            this.label8.TabIndex = 31;
            this.label8.Text = "Güncelleme ve Silme İçin\r\nRandevunun Üstüne Tıklayınız";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(77)))), ((int)(((byte)(103)))));
            this.label7.Location = new System.Drawing.Point(645, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 17);
            this.label7.TabIndex = 30;
            this.label7.Text = "Kullanıcı Hoşgeldin";
            // 
            // btnUpdt
            // 
            this.btnUpdt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(231)))), ((int)(((byte)(146)))));
            this.btnUpdt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(77)))), ((int)(((byte)(103)))));
            this.btnUpdt.Image = global::_200707048_VeyselÜstüntaş_HastaneOtomasyonu.Properties.Resources.updating__1_;
            this.btnUpdt.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdt.Location = new System.Drawing.Point(468, 235);
            this.btnUpdt.Name = "btnUpdt";
            this.btnUpdt.Size = new System.Drawing.Size(152, 60);
            this.btnUpdt.TabIndex = 29;
            this.btnUpdt.Text = "Randevu\r\nGüncelle\r\n";
            this.btnUpdt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdt.UseVisualStyleBackColor = false;
            this.btnUpdt.Click += new System.EventHandler(this.btnUpdt_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(231)))), ((int)(((byte)(146)))));
            this.btnSil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(77)))), ((int)(((byte)(103)))));
            this.btnSil.Image = global::_200707048_VeyselÜstüntaş_HastaneOtomasyonu.Properties.Resources.delete__1_;
            this.btnSil.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSil.Location = new System.Drawing.Point(316, 235);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(152, 60);
            this.btnSil.TabIndex = 28;
            this.btnSil.Text = "Randevu\r\nSil";
            this.btnSil.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(231)))), ((int)(((byte)(146)))));
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(77)))), ((int)(((byte)(103)))));
            this.btnAdd.Image = global::_200707048_VeyselÜstüntaş_HastaneOtomasyonu.Properties.Resources.plus__1_;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.Location = new System.Drawing.Point(164, 235);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(152, 60);
            this.btnAdd.TabIndex = 27;
            this.btnAdd.Text = "Randevu\r\nEkle";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnList
            // 
            this.btnList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(231)))), ((int)(((byte)(146)))));
            this.btnList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(77)))), ((int)(((byte)(103)))));
            this.btnList.Image = global::_200707048_VeyselÜstüntaş_HastaneOtomasyonu.Properties.Resources.list__1_;
            this.btnList.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnList.Location = new System.Drawing.Point(12, 235);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(152, 60);
            this.btnList.TabIndex = 26;
            this.btnList.Text = "Randevularımı\r\nListele";
            this.btnList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnList.UseVisualStyleBackColor = false;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 20);
            this.label6.TabIndex = 25;
            this.label6.Text = "Doktor Seçiniz";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 20);
            this.label5.TabIndex = 24;
            this.label5.Text = "Poliklinik Seçiniz";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 20);
            this.label4.TabIndex = 23;
            this.label4.Text = "Saat";
            // 
            // cmbDoktor
            // 
            this.cmbDoktor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(204)))), ((int)(((byte)(175)))));
            this.cmbDoktor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(35)))), ((int)(((byte)(23)))));
            this.cmbDoktor.FormattingEnabled = true;
            this.cmbDoktor.Location = new System.Drawing.Point(141, 194);
            this.cmbDoktor.Name = "cmbDoktor";
            this.cmbDoktor.Size = new System.Drawing.Size(284, 28);
            this.cmbDoktor.TabIndex = 21;
            this.cmbDoktor.SelectedIndexChanged += new System.EventHandler(this.cmbDoktor_SelectedIndexChanged);
            // 
            // cmbKlinik
            // 
            this.cmbKlinik.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(204)))), ((int)(((byte)(175)))));
            this.cmbKlinik.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(35)))), ((int)(((byte)(23)))));
            this.cmbKlinik.FormattingEnabled = true;
            this.cmbKlinik.Location = new System.Drawing.Point(141, 152);
            this.cmbKlinik.Name = "cmbKlinik";
            this.cmbKlinik.Size = new System.Drawing.Size(284, 28);
            this.cmbKlinik.TabIndex = 20;
            this.cmbKlinik.SelectedIndexChanged += new System.EventHandler(this.cmbKlinik_SelectedIndexChanged);
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
            this.cmbSaat.Location = new System.Drawing.Point(141, 69);
            this.cmbSaat.Name = "cmbSaat";
            this.cmbSaat.Size = new System.Drawing.Size(284, 28);
            this.cmbSaat.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(77)))), ((int)(((byte)(103)))));
            this.label2.Location = new System.Drawing.Point(673, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 21);
            this.label2.TabIndex = 18;
            this.label2.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(77)))), ((int)(((byte)(103)))));
            this.label1.Location = new System.Drawing.Point(623, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 21);
            this.label1.TabIndex = 17;
            this.label1.Text = "label1";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "Randevu Tarihi";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(204)))), ((int)(((byte)(175)))));
            this.dateTimePicker1.Location = new System.Drawing.Point(141, 22);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(284, 27);
            this.dateTimePicker1.TabIndex = 16;
            this.dateTimePicker1.Value = new System.DateTime(2022, 11, 28, 0, 0, 0, 0);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 303);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(866, 197);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 113);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 20);
            this.label9.TabIndex = 35;
            this.label9.Text = "Hastane Seçiniz";
            // 
            // cmbHastane
            // 
            this.cmbHastane.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(204)))), ((int)(((byte)(175)))));
            this.cmbHastane.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(35)))), ((int)(((byte)(23)))));
            this.cmbHastane.FormattingEnabled = true;
            this.cmbHastane.Location = new System.Drawing.Point(141, 110);
            this.cmbHastane.Name = "cmbHastane";
            this.cmbHastane.Size = new System.Drawing.Size(284, 28);
            this.cmbHastane.TabIndex = 34;
            this.cmbHastane.SelectedIndexChanged += new System.EventHandler(this.cmbHastane_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(477, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 27);
            this.textBox1.TabIndex = 37;
            this.textBox1.Visible = false;
            // 
            // txtHastaneId
            // 
            this.txtHastaneId.Location = new System.Drawing.Point(477, 124);
            this.txtHastaneId.Name = "txtHastaneId";
            this.txtHastaneId.Size = new System.Drawing.Size(100, 27);
            this.txtHastaneId.TabIndex = 37;
            this.txtHastaneId.Visible = false;
            // 
            // txtKlinikId
            // 
            this.txtKlinikId.Location = new System.Drawing.Point(477, 157);
            this.txtKlinikId.Name = "txtKlinikId";
            this.txtKlinikId.Size = new System.Drawing.Size(100, 27);
            this.txtKlinikId.TabIndex = 37;
            this.txtKlinikId.Visible = false;
            // 
            // txtDoktorId
            // 
            this.txtDoktorId.Location = new System.Drawing.Point(477, 190);
            this.txtDoktorId.Name = "txtDoktorId";
            this.txtDoktorId.Size = new System.Drawing.Size(100, 27);
            this.txtDoktorId.TabIndex = 37;
            this.txtDoktorId.Visible = false;
            // 
            // lblSilinecekId
            // 
            this.lblSilinecekId.AutoSize = true;
            this.lblSilinecekId.Location = new System.Drawing.Point(696, 214);
            this.lblSilinecekId.Name = "lblSilinecekId";
            this.lblSilinecekId.Size = new System.Drawing.Size(0, 20);
            this.lblSilinecekId.TabIndex = 38;
            this.lblSilinecekId.Visible = false;
            // 
            // FrmHastaErişebilirlikleri_Randevu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(236)))), ((int)(((byte)(176)))));
            this.ClientSize = new System.Drawing.Size(889, 512);
            this.Controls.Add(this.lblSilinecekId);
            this.Controls.Add(this.txtDoktorId);
            this.Controls.Add(this.txtKlinikId);
            this.Controls.Add(this.txtHastaneId);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cmbHastane);
            this.Controls.Add(this.picBxUstDizin);
            this.Controls.Add(this.picBxHome);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnUpdt);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbDoktor);
            this.Controls.Add(this.cmbKlinik);
            this.Controls.Add(this.cmbSaat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmHastaErişebilirlikleri_Randevu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hasta Randevu Ekranı | Hastane Otomasyonu";
            this.Load += new System.EventHandler(this.FrmHastaErişebilirlikleri_Randevu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBxUstDizin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBxHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.PictureBox picBxUstDizin;
        public System.Windows.Forms.PictureBox picBxHome;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.Button btnUpdt;
        public System.Windows.Forms.Button btnSil;
        public System.Windows.Forms.Button btnAdd;
        public System.Windows.Forms.Button btnList;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.ComboBox cmbDoktor;
        public System.Windows.Forms.ComboBox cmbKlinik;
        public System.Windows.Forms.ComboBox cmbSaat;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.DateTimePicker dateTimePicker1;
        public System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.ComboBox cmbHastane;
        public System.Windows.Forms.TextBox txtHastaneId;
        public System.Windows.Forms.TextBox txtKlinikId;
        public System.Windows.Forms.TextBox txtDoktorId;
        private System.Windows.Forms.Label lblSilinecekId;
    }
}