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
    public partial class ADMINPANEL : MetroForm // Form yazan yeri MetroForm olarak değiştirdim.
    {
        public ADMINPANEL()
        {
            InitializeComponent();
        }

        private void BTN_4_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Bu kod butona tıkladığımızda programı kapatmayı sağlar.
        }

        private void BTN_3_Click(object sender, EventArgs e)
        {
            HAKIMIZDA hakimizda = new HAKIMIZDA();
            hakimizda.Show();
            // Butona tıklanıldığında "HAKKIMIZDA" Formunu açmayı sağlar.
        }

        private void BTN_2_Click(object sender, EventArgs e)
        {
            YARDIM yardim = new YARDIM();
            yardim.Show();
            // Butona tıklanıldığında "YARDIM" Formunu açmayı sağlar.
        }

        private void BTN_1_Click(object sender, EventArgs e)
        {
            METROTURIZMBILETSATIS metroturizmbiletsatis = new METROTURIZMBILETSATIS();
            metroturizmbiletsatis.Show();
            // Butona tıklanıldığında "METROTURIZMBILETSATIS" Formunu açmayı sağlar.
        }
    }
}
