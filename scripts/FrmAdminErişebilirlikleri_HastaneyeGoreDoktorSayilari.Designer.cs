
namespace _200707048_VeyselÜstüntaş_HastaneOtomasyonu
{
    partial class FrmAdminErişebilirlikleri_HastaneyeGoreDoktorSayilari
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
            this.rdAnkara = new System.Windows.Forms.RadioButton();
            this.rdErzurum = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblAdminId = new System.Windows.Forms.Label();
            this.lblAdminAd = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // rdAnkara
            // 
            this.rdAnkara.AutoSize = true;
            this.rdAnkara.Location = new System.Drawing.Point(12, 31);
            this.rdAnkara.Name = "rdAnkara";
            this.rdAnkara.Size = new System.Drawing.Size(184, 24);
            this.rdAnkara.TabIndex = 0;
            this.rdAnkara.TabStop = true;
            this.rdAnkara.Text = "Ankara Şehir Hastanesi";
            this.rdAnkara.UseVisualStyleBackColor = true;
            this.rdAnkara.CheckedChanged += new System.EventHandler(this.rdAnkara_CheckedChanged);
            // 
            // rdErzurum
            // 
            this.rdErzurum.AutoSize = true;
            this.rdErzurum.Location = new System.Drawing.Point(12, 74);
            this.rdErzurum.Name = "rdErzurum";
            this.rdErzurum.Size = new System.Drawing.Size(347, 24);
            this.rdErzurum.TabIndex = 1;
            this.rdErzurum.TabStop = true;
            this.rdErzurum.Text = "Atatürk Üniversitesi Eğitim Araştıram Hastanesi";
            this.rdErzurum.UseVisualStyleBackColor = true;
            this.rdErzurum.CheckedChanged += new System.EventHandler(this.rdErzurum_CheckedChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 151);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(516, 226);
            this.dataGridView1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(446, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Hastaneye Göre Doktor Sayısını Görüntülemek İçin Herhangi Bir Hastaneyi Seçiniz";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::_200707048_VeyselÜstüntaş_HastaneOtomasyonu.Properties.Resources._return;
            this.pictureBox1.Location = new System.Drawing.Point(440, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::_200707048_VeyselÜstüntaş_HastaneOtomasyonu.Properties.Resources.home;
            this.pictureBox2.Location = new System.Drawing.Point(487, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(41, 24);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // lblAdminId
            // 
            this.lblAdminId.AutoSize = true;
            this.lblAdminId.Location = new System.Drawing.Point(452, 54);
            this.lblAdminId.Name = "lblAdminId";
            this.lblAdminId.Size = new System.Drawing.Size(0, 20);
            this.lblAdminId.TabIndex = 5;
            this.lblAdminId.Visible = false;
            // 
            // lblAdminAd
            // 
            this.lblAdminAd.AutoSize = true;
            this.lblAdminAd.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdminAd.Location = new System.Drawing.Point(12, 9);
            this.lblAdminAd.Name = "lblAdminAd";
            this.lblAdminAd.Size = new System.Drawing.Size(43, 17);
            this.lblAdminAd.TabIndex = 6;
            this.lblAdminAd.Text = "label2";
            // 
            // FrmAdminErişebilirlikleri_HastaneyeGoreDoktorSayilari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(236)))), ((int)(((byte)(176)))));
            this.ClientSize = new System.Drawing.Size(540, 389);
            this.Controls.Add(this.lblAdminAd);
            this.Controls.Add(this.lblAdminId);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.rdErzurum);
            this.Controls.Add(this.rdAnkara);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAdminErişebilirlikleri_HastaneyeGoreDoktorSayilari";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hastaneye Göre Doktor Sayıları | Admin";
            this.Load += new System.EventHandler(this.FrmAdminErişebilirlikleri_HastaneyeGoreDoktorSayilari_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdAnkara;
        private System.Windows.Forms.RadioButton rdErzurum;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.Label lblAdminId;
        private System.Windows.Forms.Label lblAdminAd;
    }
}