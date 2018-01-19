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
                var siparisler = db.Siparisler
                    .Select(x => new SiparisViewModel()
                    {
                        SiparisID = x.SiparisID,
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
        }
    }
}
