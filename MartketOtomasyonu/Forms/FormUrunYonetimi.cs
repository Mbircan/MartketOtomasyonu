﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MartketOtomasyonu.DAL;
using MartketOtomasyonu.Entities;
using System.IO;
using MartketOtomasyonu.ViewModels;

namespace MartketOtomasyonu.Forms
{
    public partial class FormUrunYonetimi : Form
    {
        public FormUrunYonetimi()
        {
            InitializeComponent();
        }

        void VerileriGetir()
        {
            try
            {
                MyContext db = new MyContext();
                cmbKategori.DataSource = db.Kategoriler.ToList();
                cmbKategori.DisplayMember = "KategoriAdi";
                cmbKategori.ValueMember = "KategoriID";

                lstUrunler.DataSource = db.Urunler.OrderBy(x => x.UrunAdi).ToList();
                lstUrunler.DisplayMember = "UrunAdi";
                lstUrunler.ValueMember = "UrunID";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private byte[] resimDosyası;

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBarkod.Text))
            {
                MessageBox.Show("Önce bir barkod oluşturmalısınız.");
                return;
            }
            MyContext db = new MyContext();
            var sonuc = db.Urunler.Select(x => x.BarkodID).ToList();
            if (sonuc.Contains(txtBarkod.Text))
            {
                MessageBox.Show("Bu barkod ile zaten bir ürün kayıtlıdır.");
                return;
            }
            try
            {
                var seciliKategori = cmbKategori.SelectedItem as Kategori;
                Urun urun = new Urun()
                {
                    UrunAdi = txtUrunAdi.Text,
                    Stok = Convert.ToInt16(nStok.Value),
                    Fiyat = nFiyat.Value,
                    KategoriID = (int)cmbKategori.SelectedValue,
                    BarkodID = txtBarkod.Text,
                     KDV=seciliKategori.KDV,
                    UrunResmi = resimDosyası                        
                };
                db.Urunler.Add(urun);
                db.SaveChanges();

                MessageBox.Show("Ürün başarıyla eklenmiştir.");
                VerileriGetir();
                lstUrunler.SelectedValue = urun.UrunID;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (lstUrunler.SelectedItem == null) return;
            var SeciliUrun = lstUrunler.SelectedItem as Urun;
            try
            {
                MyContext db = new MyContext();
                SeciliUrun = db.Urunler.Find(SeciliUrun.UrunID);
                if (SeciliUrun == null)
                {
                    MessageBox.Show("Güncellenecek ürün bulunamadı.");
                    VerileriGetir();
                    return;
                }
                var seciliKategori = cmbKategori.SelectedItem as Kategori;
                SeciliUrun.UrunAdi = txtUrunAdi.Text;
                SeciliUrun.Fiyat = nFiyat.Value;
                SeciliUrun.KategoriID = Convert.ToInt32(cmbKategori.SelectedValue);
                SeciliUrun.KDV = seciliKategori.KDV;
                SeciliUrun.UrunResmi = resimDosyası;
                db.SaveChanges();
                VerileriGetir();
                lstUrunler.SelectedValue = SeciliUrun.UrunID;
                MessageBox.Show("Ürün güncelleme başarılı.");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (lstUrunler.SelectedItem == null) return;
            var SeciliUrun = lstUrunler.SelectedItem as Urun;
            DialogResult cevap = MessageBox.Show($"{SeciliUrun.UrunAdi} isimli ürünü silmek istiyor musunuz?", "Ürün Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap == DialogResult.Yes)
            {
                try
                {
                    MyContext db = new MyContext();
                    SeciliUrun = db.Urunler.Find(SeciliUrun.UrunID);
                    if (SeciliUrun == null)
                    {
                        MessageBox.Show("Silinecek ürün bulunamadı.");
                        VerileriGetir();
                        return;
                    }
                    db.Urunler.Remove(SeciliUrun);
                    db.SaveChanges();
                    VerileriGetir();
                    MessageBox.Show($"{SeciliUrun.UrunAdi} başarıyla silinmiştir.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{SeciliUrun.UrunAdi} adlı ürün silinememiştir.\n" + ex.Message);
                }
            }
        }

        private void lstUrunler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstUrunler.SelectedItem == null)return;
            var SeciliUrun = lstUrunler.SelectedItem as Urun;
            txtUrunAdi.Text = SeciliUrun.UrunAdi;
            nFiyat.Value = SeciliUrun.Fiyat;
            nStok.Value = SeciliUrun.Stok;
            cmbKategori.SelectedValue = SeciliUrun.KategoriID;
            txtBarkod.Text = SeciliUrun.BarkodID;
            if (SeciliUrun.UrunResmi != null)
            {
                try
                {
                    MemoryStream stream = new MemoryStream(SeciliUrun.UrunResmi);
                    pbUrun.Image = new Bitmap(stream);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
                pbUrun.Image = null;
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            var ara = txtAra.Text.ToLower();
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
                            BarkodID = ur.BarkodID
                        };
            lstUrunler.DataSource = sonuc.ToList();

        }

        private void btnBarkodOlustur_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            tekrar:
            string yeniBarkod = "8690" + rnd.Next(100000000, 999999999);
            MyContext db = new MyContext();
            var sonuc = db.Urunler.Select(x => x.BarkodID).ToList();
            if (sonuc.Contains(yeniBarkod))
                goto tekrar;
            else
                txtBarkod.Text = yeniBarkod;
        }

        private void pbUrun_Click(object sender, EventArgs e)
        {
            OpenFileDialog dosyaAc = new OpenFileDialog()
            {
                Title = "Bir resim dosyası seçiniz",
                Multiselect = false,
                Filter = "JPG Formatı(*.jpg)|*.jpg:*.jpeg: |PNG Formatı | *png",
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
            };
            DialogResult result = dosyaAc.ShowDialog();
            MemoryStream memoryStream = new MemoryStream();
            var buffer = new byte[64];
            if (result == DialogResult.OK)
            {
                FileStream fileStream = File.Open(dosyaAc.FileName, FileMode.Open);
                while (fileStream.Read(buffer, 0, 64) != 0)
                {
                    memoryStream.Write(buffer, 0, 64);
                }
                resimDosyası = memoryStream.ToArray();
                pbUrun.Image = new Bitmap(memoryStream);
            }
        }

        private void FormUrunYonetimi_Load(object sender, EventArgs e)
        {
            VerileriGetir();
        }
    }
}
