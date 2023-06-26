
namespace _200707048_VeyselÜstüntaş_HastaneOtomasyonu
{
    partial class FrmAdminErişebilirlikleri_SilinenRandevular
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
            this.lblAdminAd = new System.Windows.Forms.Label();
            this.lblAdminId = new System.Windows.Forms.Label();
            this.pcBxUstDizin = new System.Windows.Forms.PictureBox();
            this.pcBxHome = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcBxUstDizin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcBxHome)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 93);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(828, 303);
            this.dataGridView1.TabIndex = 0;
            // 
            // lblAdminAd
            // 
            this.lblAdminAd.AutoSize = true;
            this.lblAdminAd.Location = new System.Drawing.Point(12, 9);
            this.lblAdminAd.Name = "lblAdminAd";
            this.lblAdminAd.Size = new System.Drawing.Size(48, 20);
            this.lblAdminAd.TabIndex = 1;
            this.lblAdminAd.Text = "label1";
            // 
            // lblAdminId
            // 
            this.lblAdminId.AutoSize = true;
            this.lblAdminId.Location = new System.Drawing.Point(76, 49);
            this.lblAdminId.Name = "lblAdminId";
            this.lblAdminId.Size = new System.Drawing.Size(0, 20);
            this.lblAdminId.TabIndex = 1;
            this.lblAdminId.Visible = false;
            // 
            // pcBxUstDizin
            // 
            this.pcBxUstDizin.Image = global::_200707048_VeyselÜstüntaş_HastaneOtomasyonu.Properties.Resources._return;
            this.pcBxUstDizin.Location = new System.Drawing.Point(752, 12);
            this.pcBxUstDizin.Name = "pcBxUstDizin";
            this.pcBxUstDizin.Size = new System.Drawing.Size(41, 20);
            this.pcBxUstDizin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcBxUstDizin.TabIndex = 2;
            this.pcBxUstDizin.TabStop = false;
            this.pcBxUstDizin.Click += new System.EventHandler(this.pcBxUstDizin_Click);
            // 
            // pcBxHome
            // 
            this.pcBxHome.Image = global::_200707048_VeyselÜstüntaş_HastaneOtomasyonu.Properties.Resources.home;
            this.pcBxHome.Location = new System.Drawing.Point(799, 12);
            this.pcBxHome.Name = "pcBxHome";
            this.pcBxHome.Size = new System.Drawing.Size(41, 20);
            this.pcBxHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcBxHome.TabIndex = 2;
            this.pcBxHome.TabStop = false;
            this.pcBxHome.Click += new System.EventHandler(this.pcBxHome_Click);
            // 
            // FrmAdminErişebilirlikleri_SilinenRandevular
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(231)))), ((int)(((byte)(146)))));
            this.ClientSize = new System.Drawing.Size(852, 405);
            this.Controls.Add(this.pcBxHome);
            this.Controls.Add(this.pcBxUstDizin);
            this.Controls.Add(this.lblAdminId);
            this.Controls.Add(this.lblAdminAd);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAdminErişebilirlikleri_SilinenRandevular";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Erişebilirlikleri | Hasta Tarafından Silinen Randevular";
            this.Load += new System.EventHandler(this.FrmAdminErişebilirlikleri_SilinenRandevular_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcBxUstDizin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcBxHome)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblAdminAd;
        private System.Windows.Forms.PictureBox pcBxUstDizin;
        private System.Windows.Forms.PictureBox pcBxHome;
        public System.Windows.Forms.Label lblAdminId;
    }
}