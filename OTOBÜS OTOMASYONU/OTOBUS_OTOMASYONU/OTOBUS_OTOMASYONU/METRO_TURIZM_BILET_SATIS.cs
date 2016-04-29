using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework; // Kütüphanemize MetroFramework'ü ekledim.
using System.Data.OleDb; // Projemizin Access bağlantısı yapmak için kütüphanemize System.Data.OleDb ekledik.
using MetroFramework.Forms; // Kütüphanemize MetroFramework.Form'u ekledim.

namespace OTOBUS_OTOMASYONU
{
    public partial class METROTURIZMBILETSATIS : MetroForm // Form yazan yeri MetroForm olarak değiştirdim.
    {
        OleDbConnection cnn; // Bağlantı oluşturmak için kullandık.
        OleDbCommand cmd_ekle; // Komut Oluşturmak için kullandık.
        public METROTURIZMBILETSATIS()
        {
            InitializeComponent();
        }
        void PROGRAMIKAPAT() // Form'a PROGRAMIKAPAT fonksiyonu ekledik. Bu fonkisyon sayesinde programı kapatmamızı sağlar.
        {
            Application.Exit();
        }
        void baglantı() // Form'a baglantı fonksiyonu ekledik. Bu fonksiyon bağlantı sağlamayı sağlar. 
        {
            string baglan = "Provider=Microsoft.Jet.Oledb.4.0;Data Source=metroturizm.mdb";
            cnn = new OleDbConnection(baglan);
            try
            {
                cnn.Open();
            }
            catch (Exception hatasızcool)
            {
                this.Text = hatasızcool.Message;
            }
        }
        void biletkayıtekleme() // Form'a biletkayıtekleme fonksiyonu ekledik. Bu fonksiyon bilet kaydını yapmayı sağlar.
        {
            string ekle = "INSERT INTO tbl_database(Müsteri_Ad_Ve_Soyad,Tc_No,Müsteri_Tel_No,Kan_Grubu,Koltuk_No,Biletin_Alındığı_Tarih,Otobüs_Varış_Yeri,Otobüs_Kalkış_Zamani_Ve_Tarihi,Otobüs_Bilet_Fiyati,Cinsiyet) VALUES ('" +TEXBOX_MUSTERIADSOYAD.Text+ "','" +TEXTBOX_TCNO.Text+ "','"+TEXTBOX_MUSTERITELNO.Text+"','" +COMBOBOX_KANGRUBU.Text+ "','" +COMBOBOX_KOLTUKNO.Text+ "','" +DATETIME_1.Text+ "','" +TEXTBOX_OTOBUSVARISYERI.Text+ "','"+DATETIME_2.Text+"','"+TEXTBOX_OTOBUSBILETFIYATI.Text+ "','" +COMBOBOX_CINSIYET.Text+ "')";
            cmd_ekle = new OleDbCommand(ekle, cnn);
            try
            {
                cmd_ekle.ExecuteNonQuery();
                MessageBox.Show("BİLET KAYITINIZ GERÇEKLEŞTİRİLMİŞDİR.");
            }
            catch (Exception hatasızkulolmaz)
            {
                this.Text = hatasızkulolmaz.Message;
            }
        }
        void biletkayıtsilme() // Form'a biletkayıtsilme fonksiyonu ekledik. Bu fonksiyon bilet kaydını silmeyi sağlar.
        {
            OleDbCommand Cmd_Sil = new OleDbCommand("delete from tbl_database WHERE Tc_No='" + TEXTBOX_SIL_TCNO.Text + "'", cnn);
            Cmd_Sil.ExecuteNonQuery();
            MessageBox.Show("BİLETİNİZ SİLİNDİ.");
        }
        void otobusbiletveritabani() // Form'a otobusbiletveritabani fonksiyonu ekledik. Bu fonksiyon veritabanındaki verileri
                                     // göstermeye sağlar.
        {
            string sorgu = ("Select * From tbl_database ");
            OleDbDataAdapter adp = new OleDbDataAdapter(sorgu, cnn);
            DataSet ds = new DataSet();
            adp.Fill(ds, "tbl_database");
            metroGrid1.DataSource = ds.Tables[0];
        }
        private void BTN_KAPAT_Click(object sender, EventArgs e)
        {
            PROGRAMIKAPAT(); // Bu kod butona tıkladığımızda programı kapatmayı sağlar.
        }

        private void BTN_BILETIKAYITET_Click(object sender, EventArgs e)
        {
            biletkayıtekleme(); // Bu butona tıklandığında bilet kaydını yapmayı sağlar. 
        }

        private void METROTURIZMBILETSATIS_Load(object sender, EventArgs e)
        {
            baglantı(); // Form yüklendiğinde access veritabanı ile bağlantı kurar. 
        }

        private void BTN_BILETIPTALET_Click(object sender, EventArgs e)
        {
            biletkayıtsilme(); // Bu butona tıklandığında bilet kaydını silmeyi sağlar.
        }

        private void BTN_VERITABANINIGOSTER_Click(object sender, EventArgs e)
        {
            otobusbiletveritabani(); //Bu butona tıklandığında otobüs bilet veritabanını göstermeyi sağlar. 
        }
    }
}
