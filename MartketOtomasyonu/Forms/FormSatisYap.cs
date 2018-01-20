using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MartketOtomasyonu.DAL;
using MartketOtomasyonu.Entities;
using MartketOtomasyonu.ViewModels;

namespace MartketOtomasyonu.Forms
{
    public partial class FormSatisYap : Form
    {
        public FormSatisYap()
        {
            InitializeComponent();
        }
        List<SepetViewModel> sepetList = new List<SepetViewModel>();
        List<UrunViewModel> urunList = new List<UrunViewModel>();


        void SepetGuncelle()
        {
            lstSepet.Items.Clear();
            sepetList.ForEach(x => lstSepet.Items.Add(x));
            SepetHesapla();
        }

        void SepetHesapla()
        {
            decimal toplam = 0, toplamKDV = 0;
            toplam = sepetList.Sum(x => x.Toplam);
            toplamKDV = sepetList.Sum(x => x.KDVTutarı);
            nmrKDV.Value = toplamKDV;
            nmrToplam.Value = toplam;
        }

        void VerileriGetir(string arama = "")
        {
            try
            {
                var ara = arama.ToLower();
                MyContext db = new MyContext();
                var sonuc = from ur in db.Urunler
                            where (ur.UrunAdi.ToLower().Contains(ara) || ur.Kategori.KategoriAdi.ToLower().Contains(ara))
                            orderby ur.UrunAdi ascending
                            select new UrunViewModel
                            {
                                UrunID = ur.UrunID,
                                KategoriAdi = ur.Kategori.KategoriAdi,
                                UrunAdi = ur.UrunAdi,
                                Fiyat = ur.Fiyat,
                                Stok = ur.Stok,
                                KDV = ur.KDV,
                                BarkodID = ur.BarkodID,
                                 UrunResmi=ur.UrunResmi
                            };
                lstUrunler.DataSource = sonuc.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); ;
            }
        }

        private void FormSiparis_Load(object sender, EventArgs e)
        {
            VerileriGetir();
            nNakit.TextChanged += new EventHandler(nNakit_TextChanged);
        }
        private void nNakit_TextChanged(object sender, EventArgs e)
        {
            lblParaUstu.Text = $"{nNakit.Value - nmrToplam.Value:c2}";
        }


        private void txtBarkod_KeyDown(object sender, KeyEventArgs e)
        {
            MyContext db = new MyContext();
            if (e.KeyCode == Keys.Enter)
            {
                var urun = db.Urunler.Where(x => x.BarkodID == txtBarkod.Text).Select(y =>
                 new UrunViewModel
                 {
                     UrunID = y.UrunID,
                     KategoriAdi = y.Kategori.KategoriAdi,
                     UrunAdi = y.UrunAdi,
                     Fiyat = y.Fiyat,
                     BarkodID = y.BarkodID,
                     KDV = y.KDV,
                     Stok = y.Stok
                 }).FirstOrDefault();
                if (urun == null)
                {
                    MessageBox.Show("Bu barkod ile kayıtlı ürün yoktur.");
                    return;
                }
                bool kontrol = StokKontrol(urun);
                if (!kontrol)
                {
                    MessageBox.Show("Stoktan fazlasını ekleyemezsiniz.");
                    txtBarkod.Clear();
                    return;
                }
                bool varmi = false;
                sepetList.ForEach(x =>
                {
                    if (x.UrunAdi == urun.UrunAdi)
                    {
                        varmi = true;
                        x.Adet++;
                    }

                });

                if (!varmi)
                {
                    var model = new SepetViewModel()
                    {
                        UrunID = urun.UrunID,
                        Indirim = nmrIndirim.Value,
                        UrunAdi = urun.UrunAdi,
                        KDV = urun.KDV,
                        Fiyat = urun.Fiyat ?? 0
                    };
                    sepetList.Add(model);
                }
                SepetGuncelle();
                txtBarkod.Clear();
            }
        }

        private void txtAra_TextChanged_1(object sender, EventArgs e)
        {
            VerileriGetir(txtAra.Text);

        }

        private void lstUrunler_SelectedIndexChanged(object sender, EventArgs e)
        {
            var seciliUrun = lstUrunler.SelectedItem as UrunViewModel;
            lblStok.Text = $"Stok Durumu : {seciliUrun.Stok}";
            if (seciliUrun.Stok >= 0 && seciliUrun.Stok <= 10)
                lblStok.BackColor = Color.Red;
            else if (seciliUrun.Stok > 10 && seciliUrun.Stok <= 30)
                lblStok.BackColor = Color.Yellow;
            else
                lblStok.BackColor = Color.Green;
            if (seciliUrun.UrunResmi != null)
            {
                try
                {
                    MemoryStream stream = new MemoryStream(seciliUrun.UrunResmi);
                    pbUrunResmi.Image = new Bitmap(stream);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
                pbUrunResmi.Image = null;

        }


        bool StokKontrol(UrunViewModel seciliUrun)
        {
            bool varmi = false, cevap = false;
            sepetList.ForEach(x =>
            {
                if (x.UrunID == seciliUrun.UrunID)
                {
                    varmi = true;
                    if (seciliUrun.Stok > x.Adet)
                        cevap = true;
                    else
                        cevap = false;
                }
            });
            if (!varmi)
            {
                if (seciliUrun.Stok > 0)
                    cevap = true;
                else
                    cevap = false;
            }
            return cevap;
        }

        private void rbNakit_CheckedChanged(object sender, EventArgs e)
        {
            if (rbNakit.Checked == true)
            {
                rbKredi.Checked = false;
                lblOdenen.Visible = true;
                nNakit.Visible = true;
                nNakit.ReadOnly = false;
                lblPara.Visible = true;
                lblParaUstu.Visible = true;
                nNakit.ResetText();
                nNakit.Controls[0].Visible = true;
            }

        }

        private void rbKredi_CheckedChanged(object sender, EventArgs e)
        {
            if (rbKredi.Checked == true)
            {
                rbNakit.Checked = false;
                lblOdenen.Visible = true;
                lblPara.Visible = false;
                lblParaUstu.Visible = false;
                nNakit.Visible = true;
                nNakit.ReadOnly = true;
                nNakit.Value = nmrToplam.Value;
                nNakit.Controls[0].Visible = false;
            }

        }

        private void nNakit_ValueChanged(object sender, EventArgs e)
        {
            lblParaUstu.Text = $"{nNakit.Value - nmrToplam.Value:c2}";
        }

        private void btnSatisYap_Click(object sender, EventArgs e)
        {
            if (sepetList.Count == 0)
            {
                MessageBox.Show("Önce sepete ürün ekleyiniz.");
                return;
            }
            if (!rbNakit.Checked && !rbKredi.Checked)
            {
                MessageBox.Show("Ödeme şeklini seçiniz.");
                return;
            }
            if (rbNakit.Checked && nmrToplam.Value > nNakit.Value)
            {
                MessageBox.Show("Girilen para yetersiz.");
                return;
            }
            string mesaj = $"{nmrToplam.Value:c2} tutarındaki satın alımı onaylıyor musunuz?";
            var cevap = MessageBox.Show(mesaj, "Satış Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap != DialogResult.Yes) return;
            MyContext db = new MyContext();
            using (var tran = db.Database.BeginTransaction())
            {
                try
                {
                    var yeniSatis = new Satis();
                    db.Satislar.Add(yeniSatis);
                    db.SaveChanges();
                    if (rbNakit.Checked)
                        yeniSatis.OdemeSekli = rbNakit.Text;
                    else if (rbKredi.Checked)
                        yeniSatis.OdemeSekli = rbKredi.Text;
                    foreach (var item in sepetList)
                    {
                        var satisDetay = new SatisDetay()
                        {
                            SatisID = yeniSatis.SatisID,
                            UrunID = item.UrunID,
                            Fiyat = item.Fiyat,
                            Adet = item.Adet,
                            Indirim = item.Indirim,
                            KDV = item.KDV,
                        };
                        db.SatisDetaylar.Add(satisDetay);
                    }
                    db.SaveChanges();
                    var siparis = db.SatisDetaylar.Where(x => x.SatisID == yeniSatis.SatisID).ToList();
                    var satis = db.Satislar.Find(yeniSatis.SatisID);
                    satis.SatisTarihi = DateTime.Now;
                    foreach (var item in siparis)
                    {
                        var urun = db.Urunler.Find(item.UrunID);
                        urun.Stok -= (short)item.Adet;
                    }
                    VerileriGetir();
                    db.SaveChanges();
                    tran.Commit();
                    MessageBox.Show($"{yeniSatis.SatisID} nolu satın alımınız Onaylanmıştır");
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnSepeteEkle_Click(object sender, EventArgs e)
        {
            if (lstUrunler.SelectedItem == null) return;
            var seciliUrun = lstUrunler.SelectedItem as UrunViewModel;
            bool kontrol = StokKontrol(seciliUrun);
            if (!kontrol)
            {
                MessageBox.Show("Stoktan fazlasını ekleyemezsiniz.");
                return;
            }
            bool varmi = false;
            sepetList.ForEach(x =>
            {
                if (x.UrunAdi == seciliUrun.UrunAdi)
                {
                    varmi = true;
                    x.Adet++;
                }

            });

            if (!varmi)
            {
                var model = new SepetViewModel()
                {
                    UrunID = seciliUrun.UrunID,
                    Indirim = nmrIndirim.Value,
                    UrunAdi = seciliUrun.UrunAdi,
                    KDV = seciliUrun.KDV,
                    Fiyat = seciliUrun.Fiyat ?? 0
                };
                sepetList.Add(model);
            }
            SepetGuncelle();
        }

        private void sepettenÇıkarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lstSepet.SelectedItem == null) return;
            var seciliUrun = lstSepet.SelectedItem as SepetViewModel;
            sepetList.Remove(seciliUrun);
            SepetGuncelle();
        }

        private void nmrToplam_ValueChanged(object sender, EventArgs e)
        {
            lblParaUstu.Text = $"{nNakit.Value - nmrToplam.Value:c2}";
        }
    }
}
