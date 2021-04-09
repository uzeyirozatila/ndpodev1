namespace KayısıAdamOyunu
{
    partial class AnaEkran
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaEkran));
            this.BilgiPl = new System.Windows.Forms.Panel();
            this.SkorShowLb = new System.Windows.Forms.Label();
            this.SkorBtn = new System.Windows.Forms.Button();
            this.SkorLb = new System.Windows.Forms.Label();
            this.BilgiLb = new System.Windows.Forms.Label();
            this.KahramanPl = new System.Windows.Forms.Panel();
            this.SavasPl = new System.Windows.Forms.Panel();
            this.BilgiPl.SuspendLayout();
            this.SuspendLayout();
            // 
            // BilgiPl
            // 
            this.BilgiPl.BackColor = System.Drawing.SystemColors.Info;
            this.BilgiPl.Controls.Add(this.SkorShowLb);
            this.BilgiPl.Controls.Add(this.SkorBtn);
            this.BilgiPl.Controls.Add(this.SkorLb);
            this.BilgiPl.Controls.Add(this.BilgiLb);
            this.BilgiPl.Dock = System.Windows.Forms.DockStyle.Top;
            this.BilgiPl.Location = new System.Drawing.Point(0, 0);
            this.BilgiPl.Name = "BilgiPl";
            this.BilgiPl.Size = new System.Drawing.Size(1222, 109);
            this.BilgiPl.TabIndex = 0;
            // 
            // SkorShowLb
            // 
            this.SkorShowLb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SkorShowLb.AutoSize = true;
            this.SkorShowLb.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SkorShowLb.Location = new System.Drawing.Point(1160, 79);
            this.SkorShowLb.Name = "SkorShowLb";
            this.SkorShowLb.Size = new System.Drawing.Size(52, 17);
            this.SkorShowLb.TabIndex = 4;
            this.SkorShowLb.Text = "label3";
            // 
            // SkorBtn
            // 
            this.SkorBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SkorBtn.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SkorBtn.Location = new System.Drawing.Point(1045, 3);
            this.SkorBtn.Name = "SkorBtn";
            this.SkorBtn.Size = new System.Drawing.Size(167, 48);
            this.SkorBtn.TabIndex = 3;
            this.SkorBtn.Text = "En İyi Skorlar";
            this.SkorBtn.UseVisualStyleBackColor = true;
            // 
            // SkorLb
            // 
            this.SkorLb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SkorLb.AutoSize = true;
            this.SkorLb.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SkorLb.Location = new System.Drawing.Point(1088, 79);
            this.SkorLb.Name = "SkorLb";
            this.SkorLb.Size = new System.Drawing.Size(42, 17);
            this.SkorLb.TabIndex = 2;
            this.SkorLb.Text = "Skor";
            // 
            // BilgiLb
            // 
            this.BilgiLb.AutoSize = true;
            this.BilgiLb.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BilgiLb.Location = new System.Drawing.Point(3, 9);
            this.BilgiLb.Name = "BilgiLb";
            this.BilgiLb.Size = new System.Drawing.Size(614, 120);
            this.BilgiLb.TabIndex = 0;
            this.BilgiLb.Text = "Oyunu başlatmak için ENTER tuşuna basınız.\r\nDurdurmak için CAPSLOCK tuşunu kullan" +
    "ınız.\r\nKahramanı haraket ettirmek için YÖN tuşlarını kullanınız.\r\nAteş etmek içi" +
    "n BOŞLUK tuşuna basınız\r\n\r\n";
            // 
            // KahramanPl
            // 
            this.KahramanPl.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.KahramanPl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.KahramanPl.Location = new System.Drawing.Point(0, 745);
            this.KahramanPl.Name = "KahramanPl";
            this.KahramanPl.Size = new System.Drawing.Size(1222, 65);
            this.KahramanPl.TabIndex = 1;
            // 
            // SavasPl
            // 
            this.SavasPl.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.SavasPl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SavasPl.Location = new System.Drawing.Point(0, 109);
            this.SavasPl.Name = "SavasPl";
            this.SavasPl.Size = new System.Drawing.Size(1222, 636);
            this.SavasPl.TabIndex = 2;
            // 
            // AnaEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1222, 810);
            this.Controls.Add(this.SavasPl);
            this.Controls.Add(this.KahramanPl);
            this.Controls.Add(this.BilgiPl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AnaEkran";
            this.Text = "Kayısı Adam Oyunu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AnaEkran_KeyDown);
            this.BilgiPl.ResumeLayout(false);
            this.BilgiPl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BilgiPl;
        private System.Windows.Forms.Button SkorBtn;
        private System.Windows.Forms.Label SkorLb;
        private System.Windows.Forms.Label BilgiLb;
        private System.Windows.Forms.Panel KahramanPl;
        private System.Windows.Forms.Panel SavasPl;
        private System.Windows.Forms.Label SkorShowLb;
    }
}

