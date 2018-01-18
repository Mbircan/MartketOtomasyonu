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
    public partial class FormSiparisYonetimi : Form
    {
        public FormSiparisYonetimi()
        {
            InitializeComponent();
        }

        private void FormSiparisYonetimi_Load(object sender, EventArgs e)
        {
            VerileriGetir();
        }

        private void VerileriGetir()
        {
            try
            {
                MyContext db = new MyContext();
                var siparisler = db.Siparisler
                    .Select(x => new SiparisViewModel()
                    {
                        SiparisID = x.SiparisID,
                        SiparisTarihi = x.SiparisTarihi,
                        TeslimTarihi = x.TeslimTarihi,
                        ToplamSiparisTutari = 0,
                        OdemeSekli = x.OdemeSekli

                    })
                    .ToList();

                foreach (var item in siparisler)
                {
                    item.ToplamSiparisTutari = db.SiparisDetaylar
                        .Where(x => x.SiparisID == item.SiparisID)
                        .Sum(x => x.Adet * x.Fiyat * (1 - x.Indirim));
                    ListViewItem viewItem = new ListViewItem(item.SiparisID.ToString("0000"));
                    viewItem.SubItems.Add($"{item.SiparisTarihi:dd MMMM yyyy}");
                    viewItem.SubItems.Add(item.TeslimTarihi != null ? $"{item.TeslimTarihi:dd MMMM yyyy}" : "Teslim edilmedi");
                    viewItem.SubItems.Add($"{item.ToplamSiparisTutari:c2}");
                    viewItem.SubItems.Add(item.OdemeSekli);
                    lstSiparisler.Items.Add(viewItem);
                }
                lstSiparisler.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void teslimEdildiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lstSiparisler.SelectedItems == null) return;
            MyContext db = new MyContext();
            var siparisNo = Convert.ToInt32(lstSiparisler.SelectedItems[0].Text);
            var siparis = db.Siparisler.Find(siparisNo);
            siparis.TeslimTarihi = DateTime.Now;
            foreach (var item in siparis.SiparisDetaylar)
            {
                item.Urun.Stok -= (short)item.Adet;
            }
            db.SaveChanges();
            lstSiparisler.Items.Clear();
            VerileriGetir();
        }
    }
}
