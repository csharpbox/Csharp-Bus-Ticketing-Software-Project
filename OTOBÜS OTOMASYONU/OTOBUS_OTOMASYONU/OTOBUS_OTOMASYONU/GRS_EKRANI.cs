using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework; // Kütüphanemize MetroFramework'ü ekledim.
using MetroFramework.Forms; // Kütüphanemize MetroFramework.Form'u ekledim.

namespace OTOBUS_OTOMASYONU
{
    public partial class GRS_EKRANI : MetroForm // Form yazan yeri MetroForm olarak değiştirdim.
    {
        public GRS_EKRANI()
        {
            InitializeComponent();
        }
        void PROGRESSBARTIMER() // Form'a PROGRESSBARTIMER fonksiyonu ekledik. Bu fonksiyon sayesinde progressbar nesnesin
                                // Value değerini +2'şer artırmayı sağlar. Eğer 100 büyük bir değere ulaştığında Tımerı aktifken
                                // pasifleştirir. Sonra giriş ekranını görünmez yapar. Daha sonra admin giriş ekranı formunu
                                // açar.
        {
            if (GRS_METROPROGRESSBAR.Value < 100)
            {
                GRS_METROPROGRESSBAR.Value = GRS_METROPROGRESSBAR.Value + 2;
            }
            else
            {
                GRS_ZAMAN.Enabled = false;
                this.Visible = false;
                ADMIN_GRS_EKRANI admingrsekrani = new ADMIN_GRS_EKRANI();
                admingrsekrani.Show();
            }
        }
        private void GRS_ZAMAN_Tick(object sender, EventArgs e)
        {
            PROGRESSBARTIMER(); // Fonksiyonda oluşturduğumuz kodları çalıştırır.
        }
    }
 }
