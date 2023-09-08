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
    public partial class FrmGiris : Form
    {
        public FrmGiris()
        {
            InitializeComponent();
        }
        EntityFrameworkEntities db=new EntityFrameworkEntities();
        private void button1_Click(object sender, EventArgs e)
        {
            var sorgu=from x in db.TBLADMIN where x.KULLANICI==textBox1.Text && x.SIFRE==textBox2.Text select x;
            if (sorgu.Any()) // Yukarıdakı şartlar sağlanıyorsa any ifadesı true donecek. 
            {
                FrmAnaForm fr=new FrmAnaForm();
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı && Şifre Yanlış ");
            }
        }

        private void FrmGiris_Load(object sender, EventArgs e)
        {

        }
    }
}
