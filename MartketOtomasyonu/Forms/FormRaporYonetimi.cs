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
    public partial class FormRaporYonetimi : Form
    {
        public FormRaporYonetimi()
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
                var satislar = db.Satislar
                    .Select(x => new SatisViewModel()
                    {
                        SatisID = x.SatisID,
                        SatisTarihi = x.SatisTarihi ?? DateTime.Now,
                        ToplamSiparisTutari = 0,
                        OdemeSekli = x.OdemeSekli

                    })
                    .ToList();
                Filtrele(satislar);
                //foreach (var item in satislar)
                //{
                //    item.ToplamSiparisTutari = db.SatisDetaylar
                //        .Where(x => x.SatisID == item.SatisID)
                //        .Sum(x => x.Adet * x.Fiyat * (1 - x.Indirim));
                //    ListViewItem viewItem = new ListViewItem(item.SatisID.ToString("0000"));
                //    viewItem.SubItems.Add($"{item.SatisTarihi:dd MMMM yyyy}");
                //    viewItem.SubItems.Add($"{item.ToplamSiparisTutari:c2}");
                //    viewItem.SubItems.Add(item.OdemeSekli);
                //    lstSiparisler.Items.Add(viewItem);
                //}
                lstSatislar.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbOdemeSekli_SelectedIndexChanged(object sender, EventArgs e)
        {
            MyContext db = new MyContext();
            lstSatislar.Items.Clear();
            List<SatisViewModel> sonuc = new List<SatisViewModel>();
            if (cmbOdemeSekli.SelectedIndex == 0)
            {
                 sonuc = db.Satislar.Where(x => x.OdemeSekli == "Nakit")
                                       .Select(x => new SatisViewModel
                                       {
                                           SatisID = x.SatisID,
                                           SatisTarihi = x.SatisTarihi ?? DateTime.Now,
                                           ToplamSiparisTutari = 0,
                                           OdemeSekli = x.OdemeSekli
                                       }).ToList();
            }
            else if (cmbOdemeSekli.SelectedIndex == 1)
            {
                sonuc = db.Satislar.Where(x => x.OdemeSekli == "Kredi Kartı")
                                       .Select(x => new SatisViewModel
                                       {
                                           SatisID = x.SatisID,
                                           SatisTarihi = x.SatisTarihi ?? DateTime.Now,
                                           ToplamSiparisTutari = 0,
                                           OdemeSekli = x.OdemeSekli
                                       }).ToList();
            }
            else if (cmbOdemeSekli.SelectedIndex == 2)
            {
                sonuc = db.Satislar.Where(x => x.OdemeSekli == "Nakit"||x.OdemeSekli=="Kredi Kartı")
                                       .Select(x => new SatisViewModel
                                       {
                                           SatisID = x.SatisID,
                                           SatisTarihi = x.SatisTarihi ?? DateTime.Now,
                                           ToplamSiparisTutari = 0,
                                           OdemeSekli = x.OdemeSekli
                                       }).ToList();
            }
            Filtrele(sonuc);
        }
        private void Filtrele(List<SatisViewModel> satisViewModel)
        {
            MyContext db = new MyContext();
            foreach (var item in satisViewModel)
            {
                item.ToplamSiparisTutari = db.SatisDetaylar
                    .Where(x => x.SatisID == item.SatisID)
                    .Sum(x => x.Adet * x.Fiyat * (1 - x.Indirim));
                ListViewItem viewItem = new ListViewItem(item.SatisID.ToString("0000"));
                viewItem.SubItems.Add($"{item.SatisTarihi:dd MMMM yyyy}");
                viewItem.SubItems.Add($"{item.ToplamSiparisTutari:c2}");
                viewItem.SubItems.Add(item.OdemeSekli);
                lstSatislar.Items.Add(viewItem);
            }
        }

        private void btnGoruntule_Click(object sender, EventArgs e)
        {
            MyContext db = new MyContext();
            lstSatislar.Items.Clear();
            var sonuc = db.Satislar.Where(x => x.SatisTarihi >= dtpIlk.Value && x.SatisTarihi < dtpSon.Value).Select(y => new SatisViewModel
            {
                OdemeSekli = y.OdemeSekli,
                SatisID = y.SatisID,
                SatisTarihi = y.SatisTarihi ?? DateTime.Now,
                ToplamSiparisTutari = 0
            }).ToList();
            Filtrele(sonuc);
        }
    }
}
