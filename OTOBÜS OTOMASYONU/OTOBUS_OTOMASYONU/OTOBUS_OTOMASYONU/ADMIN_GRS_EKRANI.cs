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
using System.Data.OleDb; // Projemizin Access bağlantısı yapmak için kütüphanemize System.Data.OleDb ekledik.

namespace OTOBUS_OTOMASYONU
{
    public partial class ADMIN_GRS_EKRANI : MetroForm // Form yazan yeri MetroForm olarak değiştirdim.
    {
        public ADMIN_GRS_EKRANI()
        {
            InitializeComponent();
        }
        void PROGRAMIKAPAT() 
        {
            Application.Exit(); // Application.Exit(); Kodu Programı Kapatmamızı sağlar.
        }

        private void BTN_CKS_Click(object sender, EventArgs e)
        {
            PROGRAMIKAPAT(); // Bu kod butona tıkladığımızda programı kapatmayı sağlar.
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.oledb.4.0;Data Source=metroturizm.mdb");
        // Metroturizm access veritabanı bağlantısını sağlar.
        private void BTN_GRS_Click(object sender, EventArgs e)
        {
            // Butona tıklanıldığında tbl_login veritabanı içindeki değerleri okuyup aynı değerler textbox içine varsa Admin
            // Giriş Panelini görünmez yapıp admin panelini formunu göstermeye yarar. Eğer yanlış bir değer girilirse "hatalı
            // giriş" mesajını verdir. Eğer textbox değerlerinden biri boş girilirse bize "lütfen alanları doldurunuz"
            // mesajını verir.
              try
            {
                baglanti.Open();
                OleDbCommand komut = new OleDbCommand("SELECT admin,password FROM tbl_login WHERE admin='"+ TEXTBOX_KULLANICIAD.Text + "'and password='" + TEXTBOX_KULLANICISİFRE.Text + "'", baglanti);
                OleDbDataReader dr;
                dr = komut.ExecuteReader();
                if (dr.Read())
                {
                    ADMINPANEL adminpanel = new ADMINPANEL();
                    adminpanel.Show();
                    this.Visible = false;
                }
                else
                {
                    MessageBox.Show("hatalı giriş");
                    baglanti.Close();
                }
            }
            catch
            {
                MessageBox.Show("lütfen alanları doldurunuz");
            } 
        }
    }
}
