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
    public partial class FrmUrun : Form
    {
        public FrmUrun()
        {
            InitializeComponent();
        }
        EntityFrameworkEntities db = new EntityFrameworkEntities();
        private void btnlistele_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = (from x in db.TBLURUN select new { x.URUNID, x.URUNAD, x.MARKA, x.STOK, x.FIYAT, x.TBLKATEGORI.AD, x.DURUM }).ToList(); // sadece bu değerlerin gelmesini ıstedık 
        }

        private void Btnekle_Click(object sender, EventArgs e)
        {
            TBLURUN t = new TBLURUN();
            t.URUNAD = txturunadı.Text;
            t.MARKA = txtmarka.Text;
            t.STOK = short.Parse(txtstok.Text);
            t.KATEGORI = int.Parse(cbxkategorı.SelectedValue.ToString());
            t.FIYAT = decimal.Parse(txtfiyat.Text);
            t.DURUM = true;
            db.TBLURUN.Add(t);
            db.SaveChanges();
            MessageBox.Show("Kaydınız Eklenmiştir");
        }

        private void Btnsil_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(txtid.Text);
            var urun = db.TBLURUN.Find(x);
            db.TBLURUN.Remove(urun);
            db.SaveChanges();
            MessageBox.Show("Kayıt Silinmiştir");

        }


        private void Btnguncelle_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(txtid.Text);
            var urun = db.TBLURUN.Find(x);
            urun.URUNAD = txturunadı.Text;
            urun.STOK = short.Parse(txtstok.Text);
            urun.MARKA = txtmarka.Text;
            db.SaveChanges();
            MessageBox.Show("Kaydınız Güncellenmsıtır");

        }

        private void FrmUrun_Load(object sender, EventArgs e)
        {
            var kategoriler = (from x in db.TBLKATEGORI
                               select new
                               {
                                   x.ID,
                                   x.AD
                               }
                               ).ToList();
            cbxkategorı.ValueMember = "ID";
            cbxkategorı.DisplayMember = "AD";
            cbxkategorı.DataSource = kategoriler;
        }
    }
}
