
namespace _200707048_VeyselÜstüntaş_HastaneOtomasyonu
{
    partial class FrmHastaKayit_ve_Giris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHastaKayit_ve_Giris));
            this.btnGiris = new System.Windows.Forms.Button();
            this.btnKayıt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGiris
            // 
            this.btnGiris.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(204)))), ((int)(((byte)(175)))));
            this.btnGiris.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGiris.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(77)))), ((int)(((byte)(103)))));
            this.btnGiris.Image = global::_200707048_VeyselÜstüntaş_HastaneOtomasyonu.Properties.Resources.login__1_;
            this.btnGiris.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGiris.Location = new System.Drawing.Point(294, 113);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.btnGiris.Size = new System.Drawing.Size(159, 91);
            this.btnGiris.TabIndex = 2;
            this.btnGiris.Text = "Giriş";
            this.btnGiris.UseVisualStyleBackColor = false;
            this.btnGiris.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnKayıt
            // 
            this.btnKayıt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(204)))), ((int)(((byte)(175)))));
            this.btnKayıt.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKayıt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(77)))), ((int)(((byte)(103)))));
            this.btnKayıt.Image = ((System.Drawing.Image)(resources.GetObject("btnKayıt.Image")));
            this.btnKayıt.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnKayıt.Location = new System.Drawing.Point(70, 113);
            this.btnKayıt.Name = "btnKayıt";
            this.btnKayıt.Size = new System.Drawing.Size(159, 91);
            this.btnKayıt.TabIndex = 2;
            this.btnKayıt.Text = "    Kayıt Ol";
            this.btnKayıt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKayıt.UseVisualStyleBackColor = false;
            this.btnKayıt.Click += new System.EventHandler(this.btnKayıt_Click);
            // 
            // FrmHastaKayit_ve_Giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(236)))), ((int)(((byte)(176)))));
            this.ClientSize = new System.Drawing.Size(521, 329);
            this.Controls.Add(this.btnGiris);
            this.Controls.Add(this.btnKayıt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmHastaKayit_ve_Giris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hasta Kayıt Ve Giriş Ekranı | Hastane Otomasyonu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnKayıt;
        private System.Windows.Forms.Button btnGiris;
    }
}