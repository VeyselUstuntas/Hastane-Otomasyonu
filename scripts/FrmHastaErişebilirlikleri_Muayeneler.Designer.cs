
namespace _200707048_VeyselÜstüntaş_HastaneOtomasyonu
{
    partial class FrmHastaErişebilirlikleri_Muayeneler
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
            this.label8 = new System.Windows.Forms.Label();
            this.btnSil = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.pcBxUstDizin = new System.Windows.Forms.PictureBox();
            this.pcBxAnaEkran = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtTcNo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.richMuayeneNedeni = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDoktorAd = new System.Windows.Forms.TextBox();
            this.lblHastaId = new System.Windows.Forms.Label();
            this.lblDoktorId = new System.Windows.Forms.Label();
            this.txtMuayeneTarih = new System.Windows.Forms.TextBox();
            this.lblMuayId = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcBxUstDizin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcBxAnaEkran)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 292);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(408, 20);
            this.label8.TabIndex = 28;
            this.label8.Text = "Silmek İstediğiniz Sonuca Tıkladıktan Sonra Butona Basınız";
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(231)))), ((int)(((byte)(146)))));
            this.btnSil.Font = new System.Drawing.Font("Segoe UI Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(77)))), ((int)(((byte)(103)))));
            this.btnSil.Image = global::_200707048_VeyselÜstüntaş_HastaneOtomasyonu.Properties.Resources.delete__1_;
            this.btnSil.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSil.Location = new System.Drawing.Point(141, 48);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(188, 46);
            this.btnSil.TabIndex = 27;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(13, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 15);
            this.label6.TabIndex = 26;
            this.label6.Text = "Kullanıcı Hoşgeldin";
            // 
            // pcBxUstDizin
            // 
            this.pcBxUstDizin.Image = global::_200707048_VeyselÜstüntaş_HastaneOtomasyonu.Properties.Resources._return;
            this.pcBxUstDizin.Location = new System.Drawing.Point(702, 12);
            this.pcBxUstDizin.Name = "pcBxUstDizin";
            this.pcBxUstDizin.Size = new System.Drawing.Size(34, 24);
            this.pcBxUstDizin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcBxUstDizin.TabIndex = 25;
            this.pcBxUstDizin.TabStop = false;
            this.pcBxUstDizin.Click += new System.EventHandler(this.pcBxUstDizin_Click);
            // 
            // pcBxAnaEkran
            // 
            this.pcBxAnaEkran.Image = global::_200707048_VeyselÜstüntaş_HastaneOtomasyonu.Properties.Resources.home;
            this.pcBxAnaEkran.Location = new System.Drawing.Point(742, 12);
            this.pcBxAnaEkran.Name = "pcBxAnaEkran";
            this.pcBxAnaEkran.Size = new System.Drawing.Size(34, 24);
            this.pcBxAnaEkran.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcBxAnaEkran.TabIndex = 24;
            this.pcBxAnaEkran.TabStop = false;
            this.pcBxAnaEkran.Click += new System.EventHandler(this.pcBxAnaEkran_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 315);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(764, 230);
            this.dataGridView1.TabIndex = 23;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // txtTcNo
            // 
            this.txtTcNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(231)))), ((int)(((byte)(146)))));
            this.txtTcNo.Enabled = false;
            this.txtTcNo.Location = new System.Drawing.Point(141, 118);
            this.txtTcNo.Name = "txtTcNo";
            this.txtTcNo.Size = new System.Drawing.Size(188, 27);
            this.txtTcNo.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(77)))), ((int)(((byte)(103)))));
            this.label7.Location = new System.Drawing.Point(12, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Muayene Sil";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(77)))), ((int)(((byte)(103)))));
            this.label5.Location = new System.Drawing.Point(12, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Hasta TcNo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(77)))), ((int)(((byte)(103)))));
            this.label1.Location = new System.Drawing.Point(12, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Muayene Tarihi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(77)))), ((int)(((byte)(103)))));
            this.label2.Location = new System.Drawing.Point(356, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Muayene Nedeni";
            // 
            // richMuayeneNedeni
            // 
            this.richMuayeneNedeni.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(231)))), ((int)(((byte)(146)))));
            this.richMuayeneNedeni.Enabled = false;
            this.richMuayeneNedeni.Location = new System.Drawing.Point(360, 81);
            this.richMuayeneNedeni.Name = "richMuayeneNedeni";
            this.richMuayeneNedeni.Size = new System.Drawing.Size(310, 193);
            this.richMuayeneNedeni.TabIndex = 30;
            this.richMuayeneNedeni.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(77)))), ((int)(((byte)(103)))));
            this.label3.Location = new System.Drawing.Point(12, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Doktor Adı";
            // 
            // txtDoktorAd
            // 
            this.txtDoktorAd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(231)))), ((int)(((byte)(146)))));
            this.txtDoktorAd.Enabled = false;
            this.txtDoktorAd.Location = new System.Drawing.Point(141, 247);
            this.txtDoktorAd.Name = "txtDoktorAd";
            this.txtDoktorAd.Size = new System.Drawing.Size(188, 27);
            this.txtDoktorAd.TabIndex = 18;
            // 
            // lblHastaId
            // 
            this.lblHastaId.AutoSize = true;
            this.lblHastaId.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHastaId.Location = new System.Drawing.Point(627, 9);
            this.lblHastaId.Name = "lblHastaId";
            this.lblHastaId.Size = new System.Drawing.Size(0, 15);
            this.lblHastaId.TabIndex = 26;
            this.lblHastaId.Visible = false;
            // 
            // lblDoktorId
            // 
            this.lblDoktorId.AutoSize = true;
            this.lblDoktorId.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDoktorId.Location = new System.Drawing.Point(541, 9);
            this.lblDoktorId.Name = "lblDoktorId";
            this.lblDoktorId.Size = new System.Drawing.Size(0, 15);
            this.lblDoktorId.TabIndex = 26;
            this.lblDoktorId.Visible = false;
            // 
            // txtMuayeneTarih
            // 
            this.txtMuayeneTarih.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(231)))), ((int)(((byte)(146)))));
            this.txtMuayeneTarih.Enabled = false;
            this.txtMuayeneTarih.Location = new System.Drawing.Point(141, 184);
            this.txtMuayeneTarih.Name = "txtMuayeneTarih";
            this.txtMuayeneTarih.Size = new System.Drawing.Size(188, 27);
            this.txtMuayeneTarih.TabIndex = 18;
            // 
            // lblMuayId
            // 
            this.lblMuayId.AutoSize = true;
            this.lblMuayId.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMuayId.Location = new System.Drawing.Point(590, 9);
            this.lblMuayId.Name = "lblMuayId";
            this.lblMuayId.Size = new System.Drawing.Size(0, 15);
            this.lblMuayId.TabIndex = 26;
            this.lblMuayId.Visible = false;
            // 
            // FrmHastaErişebilirlikleri_Muayeneler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(236)))), ((int)(((byte)(176)))));
            this.ClientSize = new System.Drawing.Size(788, 557);
            this.Controls.Add(this.richMuayeneNedeni);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.lblDoktorId);
            this.Controls.Add(this.lblMuayId);
            this.Controls.Add(this.lblHastaId);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pcBxUstDizin);
            this.Controls.Add(this.pcBxAnaEkran);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtDoktorAd);
            this.Controls.Add(this.txtMuayeneTarih);
            this.Controls.Add(this.txtTcNo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmHastaErişebilirlikleri_Muayeneler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hasta Muayene Ekranı | Hastane Otomasyonu";
            this.Load += new System.EventHandler(this.FrmHastaErişebilirlikleri_Muayeneler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcBxUstDizin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcBxAnaEkran)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pcBxUstDizin;
        private System.Windows.Forms.PictureBox pcBxAnaEkran;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtTcNo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richMuayeneNedeni;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDoktorAd;
        public System.Windows.Forms.Label lblHastaId;
        public System.Windows.Forms.Label lblDoktorId;
        private System.Windows.Forms.TextBox txtMuayeneTarih;
        public System.Windows.Forms.Label lblMuayId;
    }
}