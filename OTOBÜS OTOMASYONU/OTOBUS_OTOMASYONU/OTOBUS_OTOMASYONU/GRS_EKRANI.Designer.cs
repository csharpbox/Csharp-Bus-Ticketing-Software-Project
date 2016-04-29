namespace OTOBUS_OTOMASYONU
{
    partial class GRS_EKRANI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GRS_EKRANI));
            this.GRS_RESIM = new System.Windows.Forms.PictureBox();
            this.GRS_METROPROGRESSBAR = new MetroFramework.Controls.MetroProgressBar();
            this.GRS_ZAMAN = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.GRS_RESIM)).BeginInit();
            this.SuspendLayout();
            // 
            // GRS_RESIM
            // 
            this.GRS_RESIM.Image = global::OTOBUS_OTOMASYONU.Properties.Resources.metroturizmwallpaper;
            this.GRS_RESIM.Location = new System.Drawing.Point(23, 63);
            this.GRS_RESIM.Name = "GRS_RESIM";
            this.GRS_RESIM.Size = new System.Drawing.Size(554, 296);
            this.GRS_RESIM.TabIndex = 0;
            this.GRS_RESIM.TabStop = false;
            // 
            // GRS_METROPROGRESSBAR
            // 
            this.GRS_METROPROGRESSBAR.Location = new System.Drawing.Point(24, 366);
            this.GRS_METROPROGRESSBAR.Name = "GRS_METROPROGRESSBAR";
            this.GRS_METROPROGRESSBAR.Size = new System.Drawing.Size(553, 37);
            this.GRS_METROPROGRESSBAR.Style = MetroFramework.MetroColorStyle.Orange;
            this.GRS_METROPROGRESSBAR.TabIndex = 1;
            this.GRS_METROPROGRESSBAR.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // GRS_ZAMAN
            // 
            this.GRS_ZAMAN.Enabled = true;
            this.GRS_ZAMAN.Tick += new System.EventHandler(this.GRS_ZAMAN_Tick);
            // 
            // GRS_EKRANI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 417);
            this.Controls.Add(this.GRS_METROPROGRESSBAR);
            this.Controls.Add(this.GRS_RESIM);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GRS_EKRANI";
            this.Text = "          METRO TURİZM BİLET SATIŞ PROGRAMI";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            ((System.ComponentModel.ISupportInitialize)(this.GRS_RESIM)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox GRS_RESIM;
        private MetroFramework.Controls.MetroProgressBar GRS_METROPROGRESSBAR;
        private System.Windows.Forms.Timer GRS_ZAMAN;
    }
}

