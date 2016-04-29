namespace OTOBUS_OTOMASYONU
{
    partial class ADMIN_GRS_EKRANI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ADMIN_GRS_EKRANI));
            this.LABEL_KULANICIAD = new MetroFramework.Controls.MetroLabel();
            this.LABEL_KULLANICISIFRE = new MetroFramework.Controls.MetroLabel();
            this.TEXTBOX_KULLANICIAD = new MetroFramework.Controls.MetroTextBox();
            this.TEXTBOX_KULLANICISİFRE = new MetroFramework.Controls.MetroTextBox();
            this.BTN_GRS = new MetroFramework.Controls.MetroButton();
            this.BTN_CKS = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // LABEL_KULANICIAD
            // 
            this.LABEL_KULANICIAD.AutoSize = true;
            this.LABEL_KULANICIAD.Location = new System.Drawing.Point(29, 60);
            this.LABEL_KULANICIAD.Name = "LABEL_KULANICIAD";
            this.LABEL_KULANICIAD.Size = new System.Drawing.Size(86, 19);
            this.LABEL_KULANICIAD.Style = MetroFramework.MetroColorStyle.Orange;
            this.LABEL_KULANICIAD.TabIndex = 0;
            this.LABEL_KULANICIAD.Text = "Kullanıcı Adı :";
            this.LABEL_KULANICIAD.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // LABEL_KULLANICISIFRE
            // 
            this.LABEL_KULLANICISIFRE.AutoSize = true;
            this.LABEL_KULLANICISIFRE.Location = new System.Drawing.Point(23, 92);
            this.LABEL_KULLANICISIFRE.Name = "LABEL_KULLANICISIFRE";
            this.LABEL_KULLANICISIFRE.Size = new System.Drawing.Size(92, 19);
            this.LABEL_KULLANICISIFRE.Style = MetroFramework.MetroColorStyle.Orange;
            this.LABEL_KULLANICISIFRE.TabIndex = 1;
            this.LABEL_KULLANICISIFRE.Text = "Kullanıcı Şifre :";
            this.LABEL_KULLANICISIFRE.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // TEXTBOX_KULLANICIAD
            // 
            this.TEXTBOX_KULLANICIAD.Lines = new string[0];
            this.TEXTBOX_KULLANICIAD.Location = new System.Drawing.Point(127, 63);
            this.TEXTBOX_KULLANICIAD.MaxLength = 32767;
            this.TEXTBOX_KULLANICIAD.Name = "TEXTBOX_KULLANICIAD";
            this.TEXTBOX_KULLANICIAD.PasswordChar = '\0';
            this.TEXTBOX_KULLANICIAD.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TEXTBOX_KULLANICIAD.SelectedText = "";
            this.TEXTBOX_KULLANICIAD.Size = new System.Drawing.Size(352, 23);
            this.TEXTBOX_KULLANICIAD.Style = MetroFramework.MetroColorStyle.Orange;
            this.TEXTBOX_KULLANICIAD.TabIndex = 2;
            this.TEXTBOX_KULLANICIAD.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TEXTBOX_KULLANICIAD.UseSelectable = true;
            // 
            // TEXTBOX_KULLANICISİFRE
            // 
            this.TEXTBOX_KULLANICISİFRE.Lines = new string[0];
            this.TEXTBOX_KULLANICISİFRE.Location = new System.Drawing.Point(127, 92);
            this.TEXTBOX_KULLANICISİFRE.MaxLength = 32767;
            this.TEXTBOX_KULLANICISİFRE.Name = "TEXTBOX_KULLANICISİFRE";
            this.TEXTBOX_KULLANICISİFRE.PasswordChar = '●';
            this.TEXTBOX_KULLANICISİFRE.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TEXTBOX_KULLANICISİFRE.SelectedText = "";
            this.TEXTBOX_KULLANICISİFRE.Size = new System.Drawing.Size(352, 23);
            this.TEXTBOX_KULLANICISİFRE.Style = MetroFramework.MetroColorStyle.Orange;
            this.TEXTBOX_KULLANICISİFRE.TabIndex = 3;
            this.TEXTBOX_KULLANICISİFRE.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TEXTBOX_KULLANICISİFRE.UseSelectable = true;
            // 
            // BTN_GRS
            // 
            this.BTN_GRS.Location = new System.Drawing.Point(358, 138);
            this.BTN_GRS.Name = "BTN_GRS";
            this.BTN_GRS.Size = new System.Drawing.Size(121, 59);
            this.BTN_GRS.Style = MetroFramework.MetroColorStyle.Orange;
            this.BTN_GRS.TabIndex = 5;
            this.BTN_GRS.Text = "GİRİŞ";
            this.BTN_GRS.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.BTN_GRS.UseSelectable = true;
            this.BTN_GRS.Click += new System.EventHandler(this.BTN_GRS_Click);
            // 
            // BTN_CKS
            // 
            this.BTN_CKS.Location = new System.Drawing.Point(23, 138);
            this.BTN_CKS.Name = "BTN_CKS";
            this.BTN_CKS.Size = new System.Drawing.Size(121, 59);
            this.BTN_CKS.Style = MetroFramework.MetroColorStyle.Orange;
            this.BTN_CKS.TabIndex = 6;
            this.BTN_CKS.Text = "PROGRAMI KAPAT";
            this.BTN_CKS.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.BTN_CKS.UseSelectable = true;
            this.BTN_CKS.Click += new System.EventHandler(this.BTN_CKS_Click);
            // 
            // ADMIN_GRS_EKRANI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 207);
            this.Controls.Add(this.BTN_CKS);
            this.Controls.Add(this.BTN_GRS);
            this.Controls.Add(this.TEXTBOX_KULLANICISİFRE);
            this.Controls.Add(this.TEXTBOX_KULLANICIAD);
            this.Controls.Add(this.LABEL_KULLANICISIFRE);
            this.Controls.Add(this.LABEL_KULANICIAD);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ADMIN_GRS_EKRANI";
            this.Text = "ADMİN GİRİŞ EKRANI";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel LABEL_KULANICIAD;
        private MetroFramework.Controls.MetroLabel LABEL_KULLANICISIFRE;
        private MetroFramework.Controls.MetroTextBox TEXTBOX_KULLANICIAD;
        private MetroFramework.Controls.MetroTextBox TEXTBOX_KULLANICISİFRE;
        private MetroFramework.Controls.MetroButton BTN_GRS;
        private MetroFramework.Controls.MetroButton BTN_CKS;
    }
}