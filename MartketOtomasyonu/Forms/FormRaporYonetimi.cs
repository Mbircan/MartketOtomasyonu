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
                sonuc = db.Satislar.Where(x => x.OdemeSekli == "Nakit" || x.OdemeSekli == "Kredi Kartı")
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
                    .Sum(x => x.Adet * x.Fiyat * (1 - x.Indirim) * (1 + x.KDV));
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
            var sonuc = db.Satislar.Where(x => dtpIlk.Value <= x.SatisTarihi && dtpSon.Value >= x.SatisTarihi).Select(y => new SatisViewModel
            {
                OdemeSekli = y.OdemeSekli,
                SatisID = y.SatisID,
                SatisTarihi = y.SatisTarihi ?? DateTime.Now,
                ToplamSiparisTutari = 0
            }).ToList();
            Filtrele(sonuc);
        }

        private void detaylarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lstSatislar.SelectedItems == null) return;
            FormSatisDetaylari formSatisDetaylari = new FormSatisDetaylari();
            var satisNo = Convert.ToInt32(lstSatislar.SelectedItems[0].Text);
            MyContext db = new MyContext();
            var sonuc = db.SatisDetaylar
                          .Where(x => x.SatisID == satisNo)
                          .Select(y => new SatisDetayViewModel
                          {
                              SatisID = y.SatisID,
                              UrunID = y.UrunID,
                              Adet = y.Adet,
                              Fiyat = y.Fiyat,
                              Indirim = y.Indirim,
                              KDV = y.KDV
                          }).ToList();
            sonuc.ForEach(x =>
            {
                ListViewItem viewItem = new ListViewItem(x.SatisID.ToString());
                viewItem.SubItems.Add(x.UrunID.ToString());
                viewItem.SubItems.Add(x.Adet.ToString());
                viewItem.SubItems.Add($"{x.Fiyat:c2}");
                viewItem.SubItems.Add($"{x.Indirim:c2}");
                viewItem.SubItems.Add(x.KDV.ToString());
                formSatisDetaylari.lstSatisDetaylar.Items.Add(viewItem);
            });
            formSatisDetaylari.lstSatisDetaylar.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            formSatisDetaylari.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int offset = 0;
            for (int i = 0; i < lstSatislar.Items.Count; i++)
            {
                e.Graphics.DrawString(" " + lstSatislar.Items[i].SubItems[0].Text +" "+ lstSatislar.Items[i].SubItems[1].Text+" " + lstSatislar.Items[i].SubItems[2].Text +" "+ lstSatislar.Items[i].SubItems[3].Text, new Font("Arial Bold", 20),
                new SolidBrush(Color.Black), 20, 20 + offset);
                offset += 35;
            }
            
        }
        private void btnYazdır_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }
    }
}
