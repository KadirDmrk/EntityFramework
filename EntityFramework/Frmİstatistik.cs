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
    public partial class Frmİstatistik : Form
    {
        public Frmİstatistik()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        EntityFrameworkEntities db = new EntityFrameworkEntities();
        private void Frmİstatistik_Load(object sender, EventArgs e)
        {
            label2.Text = db.TBLKATEGORI.Count().ToString();
            label3.Text = db.TBLURUN.Count().ToString();
            label5.Text = db.TBLMUSTERI.Count(x => x.DURUM == true).ToString(); // Sqlde müsteri tablasuna durum ekledık ornegın bır kısıyı sıldııgmız zaman tablodan gıtmıyor aktıf pasit olarak gozukuor yanı sıldıgımız kısı pasıf olarak gozukuyor.
            label7.Text = db.TBLMUSTERI.Count(x => x.DURUM == false).ToString(); // Aynısı Burdada geçerli 
            label9.Text = db.TBLURUN.Sum(x => x.STOK).ToString();
            label19.Text = db.TBLSATIS.Sum(z => z.FIYAT).ToString() + "TL";
            label13.Text = (from x in db.TBLURUN orderby x.FIYAT descending select x.URUNAD).FirstOrDefault(); // Burada Dedimki bana bir sıralama yap(orderby) fiyatlarda z den a ya dogru(descending z den aya anlamına geliyor) urun adı tablosunu seç fırstordefault bana son cıkan urunu goster .
            label15.Text = (from x in db.TBLURUN orderby x.FIYAT ascending select x.URUNAD).FirstOrDefault();
            label11.Text = db.TBLURUN.Count(x => x.KATEGORI == 1).ToString(); // Beyaz eşya 1 numaralı ıd'de oldugu ııcn 1 yazdık 
            label23.Text = db.TBLURUN.Count(x => x.URUNAD == "LAPTOP").ToString(); // Ürün adı laptop olan değeri getir.
            label17.Text = (from x in db.TBLMUSTERI select x.SEHIR).Distinct().Count().ToString();
            label21.Text = db.MARKAGETİR().FirstOrDefault(); // Proseduru projeye dahıl eteme model tablosuunda sağ tık yapıyoruz oradan marka getir adlı dosyayı seçiyoruz .

        }

    }
}              /* x=> x.durum veyahut baska sey bü kullanıma lambda kullanım diyolar. Oraya yazdııgmız harfın herhangı bır önemi
                 yok oraya bır kelıme yazsakda sıkıntı olamz kullanım yapısı boyle sadece.*/