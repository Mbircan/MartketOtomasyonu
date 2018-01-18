using System;
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

namespace MartketOtomasyonu.Forms
{
    public partial class FormKategoriler : Form
    {
        public FormKategoriler()
        {
            InitializeComponent();
        }

        private void FormKategoriler_Load(object sender, EventArgs e)
        {
            VerileriGetir();
        }

        void VerileriGetir()
        {
            try
            {
                MyContext db = new MyContext();
                lstKategoriler.DataSource = db.Kategoriler.ToList();
                lstKategoriler.DisplayMember = "KategoriAdi";
                lstKategoriler.ValueMember = "KategoriID";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); ;
            }
        }   

        private void btnUrunler_Click(object sender, EventArgs e)
        {
            FormUrunler urunlerForm = new FormUrunler();
            urunlerForm.Text = "Ürünler";
            urunlerForm.ShowDialog();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnKategoriler_Click(object sender, EventArgs e)
        {
            FormUrunler formUrunler = new FormUrunler();
            this.Hide();
            formUrunler.Show();
        }

        private void btnAnasayfa_Click(object sender, EventArgs e)
        {
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Kategori kategori = new Kategori()
            {
                KategoriAdi = txtKategoriAdi.Text,
                Aciklama = rtxtAciklama.Text
            };
            MyContext db = new MyContext();
            db.Kategoriler.Add(kategori);
            db.SaveChanges();
            MessageBox.Show("Kategori başarıyla eklendi.");
            VerileriGetir();
            lstKategoriler.SelectedValue = kategori.KategoriID;
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            string ara = txtAra.Text.ToLower();
            try
            {
                MyContext db = new MyContext();
                var sonuc = db.Kategoriler
                          .Where(x => x.KategoriAdi.ToLower().Contains(ara))
                          .OrderBy(x => x.KategoriAdi).ToList();
                lstKategoriler.DataSource = sonuc;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (lstKategoriler.SelectedItem == null) return;
            var SeciliKategori = lstKategoriler.SelectedItem as Kategori;

            try
            {
                MyContext db = new MyContext();
                SeciliKategori = db.Kategoriler.Find(SeciliKategori.KategoriID);
                if (SeciliKategori == null)
                {
                    MessageBox.Show("Güncellenecek ürün bulunamadı.");
                    VerileriGetir();
                    return;
                }
                SeciliKategori.KategoriAdi = txtKategoriAdi.Text;
                SeciliKategori.Aciklama = rtxtAciklama.Text;
                db.SaveChanges();
                VerileriGetir();
                lstKategoriler.SelectedValue = SeciliKategori.KategoriID;
                MessageBox.Show("Kategori güncelleme başarılı.");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (lstKategoriler.SelectedItem == null) return;
            var SeciliKategori = lstKategoriler.SelectedItem as Kategori;
            DialogResult cevap = MessageBox.Show($"{SeciliKategori.KategoriAdi} isimli kategoriyi silmek istiyor musunuz?", "Kategori Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap == DialogResult.Yes)
            {
                try
                {
                    MyContext db = new MyContext();
                    SeciliKategori = db.Kategoriler.Find(SeciliKategori.KategoriID);
                    if (SeciliKategori == null)
                    {
                        MessageBox.Show("Silinecek kategori bulunamadı.");
                        VerileriGetir();
                        return;
                    }
                    if (SeciliKategori.Urunler.Any())
                    {
                        MessageBox.Show($"{SeciliKategori}'nin {SeciliKategori.Urunler.Count} adet ürünü olduğundan bu kategoriyi silemezsiniz!");
                        return;
                    }
                    db.Kategoriler.Remove(SeciliKategori);
                    db.SaveChanges();
                    VerileriGetir();
                    MessageBox.Show($"{SeciliKategori.KategoriAdi} başarıyla silinmiştir.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{SeciliKategori.KategoriAdi} adlı kategori silinememiştir.\n" + ex.Message);
                }
            }
        }

        private void lstKategoriler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstKategoriler.SelectedItem == null) return;

            var SeciliKategori = lstKategoriler.SelectedItem as Kategori;
            txtKategoriAdi.Text = SeciliKategori.KategoriAdi;
            rtxtAciklama.Text = SeciliKategori.Aciklama;
        }

        private void btnSiparisler_Click(object sender, EventArgs e)
        {
            FormSiparisYonetimi formSiparisYonetimi = new FormSiparisYonetimi();
            formSiparisYonetimi.ShowDialog();
        }
    }
}
