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

        private void btnSatisYap_Click(object sender, EventArgs e)
        {
            FormSatisYap formSatisYap = new FormSatisYap();
            formSatisYap.ShowDialog();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnUrunYonetimi_Click(object sender, EventArgs e)
        {
            FormUrunYonetimi formUrunYonetimi = new FormUrunYonetimi();
            formUrunYonetimi.ShowDialog();
        }

        private void btnKategoriYonetimi_Click(object sender, EventArgs e)
        {
            FormKategoriYonetimi formKategoriYonetimi = new FormKategoriYonetimi();
            formKategoriYonetimi.ShowDialog();
        }

        private void btnRaporYonetimi_Click(object sender, EventArgs e)
        {
            FormRaporYonetimi formRaporYonetimi = new FormRaporYonetimi();
            formRaporYonetimi.ShowDialog();
        }

        private void btnStokYonetimi_Click(object sender, EventArgs e)
        {
            FormStokYonetimi formStokYonetimi = new FormStokYonetimi();
            formStokYonetimi.ShowDialog();
        }
    }
}
