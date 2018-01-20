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

        private void Glow_MouseEnter(object sender, EventArgs e)
        {
            var button = sender as Button;
            switch (button.Name)
            {
                case "btnUrunYonetimi":
                    btnUrunYonetimi.UseVisualStyleBackColor = false;
                    btnUrunYonetimi.Font = new Font(Font.FontFamily, 11);
                    btnUrunYonetimi.BackColor = Color.Aquamarine;
                    break;
                case "btnKategoriYonetimi":
                    btnKategoriYonetimi.UseVisualStyleBackColor = false;
                    btnKategoriYonetimi.Font = new Font(Font.FontFamily, 11);
                    btnKategoriYonetimi.BackColor = Color.Aquamarine;
                    break;
                case "btnSatisYap":
                    btnSatisYap.UseVisualStyleBackColor = false;
                    btnSatisYap.Font = new Font(Font.FontFamily, 11);
                    btnSatisYap.BackColor = Color.Aquamarine;
                    break;
                case "btnStokYonetimi":
                    btnStokYonetimi.UseVisualStyleBackColor = false;
                    btnStokYonetimi.Font = new Font(Font.FontFamily, 11);
                    btnStokYonetimi.BackColor = Color.Aquamarine;
                    break;
                case "btnRaporYonetimi":
                    btnRaporYonetimi.UseVisualStyleBackColor = false;
                    btnRaporYonetimi.Font = new Font(Font.FontFamily, 11);
                    btnRaporYonetimi.BackColor = Color.Aquamarine;
                    break;
                case "btnCikis":
                    btnCikis.UseVisualStyleBackColor = false;
                    btnCikis.Font = new Font(Font.FontFamily, 11);
                    btnCikis.BackColor = Color.Aquamarine;
                    break;
                default:
                    break;
            }

        }

        private void Glow_MouseLeave(object sender, EventArgs e)
        {
            var button = sender as Button;
            switch (button.Name)
            {
                case "btnUrunYonetimi":
                    btnUrunYonetimi.UseVisualStyleBackColor = true;
                    btnUrunYonetimi.Font = new Font(Font.FontFamily, 10);
                    break;
                case "btnKategoriYonetimi":
                    btnKategoriYonetimi.UseVisualStyleBackColor = true;
                    btnKategoriYonetimi.Font = new Font(Font.FontFamily, 10);
                    break;
                case "btnSatisYap":
                    btnSatisYap.UseVisualStyleBackColor = true;
                    btnSatisYap.Font = new Font(Font.FontFamily, 10);
                    break;
                case "btnStokYonetimi":
                    btnStokYonetimi.UseVisualStyleBackColor = true;
                    btnStokYonetimi.Font = new Font(Font.FontFamily, 10);
                    break;
                case "btnRaporYonetimi":
                    btnRaporYonetimi.UseVisualStyleBackColor = true;
                    btnRaporYonetimi.Font = new Font(Font.FontFamily, 10);
                    break;
                case "btnCikis":
                    btnCikis.UseVisualStyleBackColor = true;
                    btnCikis.Font = new Font(Font.FontFamily, 10);
                    break;
                default:
                    break;
            }
        }

    }
}
