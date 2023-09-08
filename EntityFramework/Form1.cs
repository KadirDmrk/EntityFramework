using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFramework
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        EntityFrameworkEntities db = new EntityFrameworkEntities();

        // Listeleme Metodu 
        private void BtnListele_Click(object sender, EventArgs e)
        {
            var kategoriler = db.TBLKATEGORI.ToList(); // var değişkeninden kategoriler adında bir şey tanımdalık kategorileri listeledik
            dataGridView1.DataSource = kategoriler;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TBLKATEGORI t = new TBLKATEGORI(); //  bu sınıftan bır nesne türetmedıgımız sürece kategorı içindekı ad,soyad bunlara erişemiyoruz.t.Bu şekilde hepsıne erişiyoruz.
            t.AD = textBox2.Text;
            db.TBLKATEGORI.Add(t); // kategori içine neyi eklicez t yi yollucaz t neyi tutuyor adı tutuyor.
            db.SaveChanges(); // Execute Non Query ıle aynı anlama gelıyor 
            MessageBox.Show("Kategori Eklendi");

        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            int x=Convert.ToInt16(textBox1.Text); // texboxtan gelen degıskeni donustur
            var ktgr = db.TBLKATEGORI.Find(x); // x değişkenını bul
            db.TBLKATEGORI.Remove(ktgr); // ktgr tablosundan kaldır
            db.SaveChanges(); // kaydet 
            MessageBox.Show("Kaydınız Silinmiştir");

        }

        private void BtnGüncelle_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt16(textBox1.Text);  // Silme İşlemiyle hemen hemen aynı 
            var ktgr = db.TBLKATEGORI.Find(x);
            ktgr.AD = textBox2.Text;
            db.SaveChanges();
            MessageBox.Show("Güncelleme Yapıldı");
        }
    }
}
