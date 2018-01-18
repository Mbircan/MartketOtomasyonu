using MartketOtomasyonu.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MartketOtomasyonu
{
    public partial class AnaMenu : Form
    {
        public AnaMenu()
        {
            InitializeComponent();
        }

        private void btnUrunler_Click(object sender, EventArgs e)
        {
            FormUrunler formUrunler = new FormUrunler();
            formUrunler.ShowDialog();
        }

        private void btnKategoriler_Click(object sender, EventArgs e)
        {
            FormKategoriler formKategoriler = new FormKategoriler();
            formKategoriler.ShowDialog();
        }

        private void btnSiparisler_Click(object sender, EventArgs e)
        {
            FormSiparis formSiparis = new FormSiparis();
            formSiparis.ShowDialog();
        }

        private void btnSiparisYonetimi_Click(object sender, EventArgs e)
        {
            FormSiparisYonetimi formSiparisYonetimi = new FormSiparisYonetimi();
            formSiparisYonetimi.ShowDialog();
        }

        private void btnStokYonetimi_Click(object sender, EventArgs e)
        {
            FormStokYonetimi formStokYonetimi = new FormStokYonetimi();
            formStokYonetimi.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
