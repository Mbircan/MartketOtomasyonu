using MartketOtomasyonu.DAL;
using MartketOtomasyonu.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MartketOtomasyonu.Forms
{
    public partial class FormStokYonetimi : Form
    {
        public FormStokYonetimi()
        {
            InitializeComponent();
        }

        private void FormStokYonetimi_Load(object sender, EventArgs e)
        {
            VerileriGetir();
        }

        private void VerileriGetir()
        {
            MyContext db = new MyContext();
            var sonuc = db.Urunler.Select(x => new StokViewModel
            {
                UrunAdi = x.UrunAdi,
                UrunID = x.UrunID,
                Stok = x.Stok
            }).ToList();
            lstUrunler.DataSource = sonuc;
        }

        private void lstUrunler_SelectedIndexChanged(object sender, EventArgs e)
        {
            var seciliUrun = lstUrunler.SelectedItem as StokViewModel;
            lblStok.Text = seciliUrun.Stok.ToString();
            if (seciliUrun.Stok == 0)
                lblStok.BackColor = Color.Red;
            else if (seciliUrun.Stok > 0 && seciliUrun.Stok < 20)
                lblStok.BackColor = Color.Yellow;
            else
                lblStok.BackColor = Color.Green;
        }

        private void btnStokGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                MyContext db = new MyContext();
                if (lstUrunler.SelectedItem == null) return;
                var seciliUrun = lstUrunler.SelectedItem as StokViewModel;
                var urun = db.Urunler.Find(seciliUrun.UrunID);
                urun.Stok = short.Parse(txtStok.Text);
                db.SaveChanges();
                VerileriGetir();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
