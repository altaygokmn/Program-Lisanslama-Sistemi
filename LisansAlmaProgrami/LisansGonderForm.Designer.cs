namespace LisansAlmaProgramı
{
    partial class LisansGonderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LisansGonderForm));
            this.btnKeyGonder = new System.Windows.Forms.Button();
            this.labelRandomAnahtar = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnKeyGonder
            // 
            this.btnKeyGonder.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnKeyGonder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnKeyGonder.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKeyGonder.Location = new System.Drawing.Point(12, 287);
            this.btnKeyGonder.Name = "btnKeyGonder";
            this.btnKeyGonder.Size = new System.Drawing.Size(776, 59);
            this.btnKeyGonder.TabIndex = 0;
            this.btnKeyGonder.Text = "Kişisel Lisansınızı Oluşturmak için Tıklayınız";
            this.btnKeyGonder.UseVisualStyleBackColor = false;
            this.btnKeyGonder.Click += new System.EventHandler(this.btnKeyGonder_Click);
            // 
            // labelRandomAnahtar
            // 
            this.labelRandomAnahtar.AutoSize = true;
            this.labelRandomAnahtar.Location = new System.Drawing.Point(12, 349);
            this.labelRandomAnahtar.Name = "labelRandomAnahtar";
            this.labelRandomAnahtar.Size = new System.Drawing.Size(351, 16);
            this.labelRandomAnahtar.TabIndex = 1;
            this.labelRandomAnahtar.Text = "Kişisel lisans anahtarınız oluştuğunda burada gözükecek...";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.labelRandomAnahtar);
            this.panel1.Controls.Add(this.btnKeyGonder);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::LisansAlmaProgramı.Properties.Resources.licence;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(0, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 221);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // LisansGonderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LisansGonderForm";
            this.Text = "Lisans Programı";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnKeyGonder;
        private System.Windows.Forms.Label labelRandomAnahtar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

