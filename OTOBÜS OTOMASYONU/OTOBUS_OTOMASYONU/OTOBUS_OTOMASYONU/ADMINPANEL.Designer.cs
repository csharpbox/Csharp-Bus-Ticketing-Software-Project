namespace OTOBUS_OTOMASYONU
{
    partial class ADMINPANEL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ADMINPANEL));
            this.BTN_1 = new MetroFramework.Controls.MetroButton();
            this.BTN_2 = new MetroFramework.Controls.MetroButton();
            this.BTN_3 = new MetroFramework.Controls.MetroButton();
            this.BTN_4 = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // BTN_1
            // 
            this.BTN_1.Location = new System.Drawing.Point(23, 63);
            this.BTN_1.Name = "BTN_1";
            this.BTN_1.Size = new System.Drawing.Size(216, 109);
            this.BTN_1.Style = MetroFramework.MetroColorStyle.Green;
            this.BTN_1.TabIndex = 0;
            this.BTN_1.Text = "METRO TURİZM BİLET SATIŞ";
            this.BTN_1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.BTN_1.UseSelectable = true;
            this.BTN_1.Click += new System.EventHandler(this.BTN_1_Click);
            // 
            // BTN_2
            // 
            this.BTN_2.Location = new System.Drawing.Point(245, 63);
            this.BTN_2.Name = "BTN_2";
            this.BTN_2.Size = new System.Drawing.Size(216, 109);
            this.BTN_2.Style = MetroFramework.MetroColorStyle.Green;
            this.BTN_2.TabIndex = 1;
            this.BTN_2.Text = "YARDIM";
            this.BTN_2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.BTN_2.UseSelectable = true;
            this.BTN_2.Click += new System.EventHandler(this.BTN_2_Click);
            // 
            // BTN_3
            // 
            this.BTN_3.Location = new System.Drawing.Point(467, 63);
            this.BTN_3.Name = "BTN_3";
            this.BTN_3.Size = new System.Drawing.Size(216, 109);
            this.BTN_3.Style = MetroFramework.MetroColorStyle.Green;
            this.BTN_3.TabIndex = 2;
            this.BTN_3.Text = "HAKKIMIZDA";
            this.BTN_3.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.BTN_3.UseSelectable = true;
            this.BTN_3.Click += new System.EventHandler(this.BTN_3_Click);
            // 
            // BTN_4
            // 
            this.BTN_4.Location = new System.Drawing.Point(689, 63);
            this.BTN_4.Name = "BTN_4";
            this.BTN_4.Size = new System.Drawing.Size(216, 109);
            this.BTN_4.Style = MetroFramework.MetroColorStyle.Green;
            this.BTN_4.TabIndex = 3;
            this.BTN_4.Text = "ÇIKIŞ";
            this.BTN_4.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.BTN_4.UseSelectable = true;
            this.BTN_4.Click += new System.EventHandler(this.BTN_4_Click);
            // 
            // ADMINPANEL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 201);
            this.Controls.Add(this.BTN_4);
            this.Controls.Add(this.BTN_3);
            this.Controls.Add(this.BTN_2);
            this.Controls.Add(this.BTN_1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ADMINPANEL";
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "ADMIN PANELI";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton BTN_1;
        private MetroFramework.Controls.MetroButton BTN_2;
        private MetroFramework.Controls.MetroButton BTN_3;
        private MetroFramework.Controls.MetroButton BTN_4;
    }
}