namespace MartketOtomasyonu.Forms
{
    partial class FormUrunler
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.nStok = new System.Windows.Forms.NumericUpDown();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.cmbKategori = new System.Windows.Forms.ComboBox();
            this.nFiyat = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.txtUrunAdi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lstUrunler = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBarkod = new System.Windows.Forms.TextBox();
            this.btnBarkodOlustur = new System.Windows.Forms.Button();
            this.pbUrun = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nStok)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nFiyat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUrun)).BeginInit();
            this.SuspendLayout();
            // 
            // nStok
            // 
            this.nStok.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nStok.Location = new System.Drawing.Point(98, 167);
            this.nStok.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nStok.Name = "nStok";
            this.nStok.Size = new System.Drawing.Size(179, 24);
            this.nStok.TabIndex = 33;
            this.nStok.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnSil
            // 
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Location = new System.Drawing.Point(216, 385);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(74, 45);
            this.btnSil.TabIndex = 39;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.Location = new System.Drawing.Point(129, 385);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(74, 45);
            this.btnGuncelle.TabIndex = 38;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.Location = new System.Drawing.Point(33, 385);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(74, 45);
            this.btnKaydet.TabIndex = 37;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // cmbKategori
            // 
            this.cmbKategori.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbKategori.FormattingEnabled = true;
            this.cmbKategori.Location = new System.Drawing.Point(96, 123);
            this.cmbKategori.Name = "cmbKategori";
            this.cmbKategori.Size = new System.Drawing.Size(180, 26);
            this.cmbKategori.TabIndex = 31;
            // 
            // nFiyat
            // 
            this.nFiyat.DecimalPlaces = 2;
            this.nFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nFiyat.Location = new System.Drawing.Point(97, 78);
            this.nFiyat.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nFiyat.Name = "nFiyat";
            this.nFiyat.Size = new System.Drawing.Size(179, 24);
            this.nFiyat.TabIndex = 30;
            this.nFiyat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(26, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 18);
            this.label3.TabIndex = 42;
            this.label3.Text = "Kategori";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(49, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 18);
            this.label2.TabIndex = 41;
            this.label2.Text = "Fiyat";
            // 
            // txtAra
            // 
            this.txtAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAra.Location = new System.Drawing.Point(335, 42);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(274, 24);
            this.txtAra.TabIndex = 35;
            this.txtAra.TextChanged += new System.EventHandler(this.txtAra_TextChanged);
            // 
            // txtUrunAdi
            // 
            this.txtUrunAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUrunAdi.Location = new System.Drawing.Point(97, 40);
            this.txtUrunAdi.Name = "txtUrunAdi";
            this.txtUrunAdi.Size = new System.Drawing.Size(179, 24);
            this.txtUrunAdi.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(22, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 18);
            this.label1.TabIndex = 40;
            this.label1.Text = "Ürün Adı";
            // 
            // lstUrunler
            // 
            this.lstUrunler.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstUrunler.FormattingEnabled = true;
            this.lstUrunler.ItemHeight = 18;
            this.lstUrunler.Location = new System.Drawing.Point(335, 71);
            this.lstUrunler.Name = "lstUrunler";
            this.lstUrunler.Size = new System.Drawing.Size(274, 310);
            this.lstUrunler.TabIndex = 36;
            this.lstUrunler.SelectedIndexChanged += new System.EventHandler(this.lstUrunler_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(51, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 18);
            this.label6.TabIndex = 45;
            this.label6.Text = "Stok";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(34, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 18);
            this.label4.TabIndex = 46;
            this.label4.Text = "Barkod";
            // 
            // txtBarkod
            // 
            this.txtBarkod.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBarkod.Location = new System.Drawing.Point(98, 221);
            this.txtBarkod.Name = "txtBarkod";
            this.txtBarkod.ReadOnly = true;
            this.txtBarkod.Size = new System.Drawing.Size(129, 23);
            this.txtBarkod.TabIndex = 47;
            // 
            // btnBarkodOlustur
            // 
            this.btnBarkodOlustur.Location = new System.Drawing.Point(233, 212);
            this.btnBarkodOlustur.Name = "btnBarkodOlustur";
            this.btnBarkodOlustur.Size = new System.Drawing.Size(75, 37);
            this.btnBarkodOlustur.TabIndex = 48;
            this.btnBarkodOlustur.Text = "Barkod Oluştur";
            this.btnBarkodOlustur.UseVisualStyleBackColor = true;
            this.btnBarkodOlustur.Click += new System.EventHandler(this.btnBarkodOlustur_Click);
            // 
            // pbUrun
            // 
            this.pbUrun.Location = new System.Drawing.Point(98, 276);
            this.pbUrun.Name = "pbUrun";
            this.pbUrun.Size = new System.Drawing.Size(129, 71);
            this.pbUrun.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbUrun.TabIndex = 49;
            this.pbUrun.TabStop = false;
            this.pbUrun.Click += new System.EventHandler(this.pbUrun_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(2, 297);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 18);
            this.label5.TabIndex = 50;
            this.label5.Text = "Ürün Resmi";
            // 
            // FormUrunler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 454);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pbUrun);
            this.Controls.Add(this.btnBarkodOlustur);
            this.Controls.Add(this.txtBarkod);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nStok);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.cmbKategori);
            this.Controls.Add(this.nFiyat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAra);
            this.Controls.Add(this.txtUrunAdi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstUrunler);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormUrunler";
            this.Text = "FormUrunler";
            this.Load += new System.EventHandler(this.FormUrunler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nStok)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nFiyat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUrun)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nStok;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.ComboBox cmbKategori;
        private System.Windows.Forms.NumericUpDown nFiyat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAra;
        private System.Windows.Forms.TextBox txtUrunAdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstUrunler;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBarkod;
        private System.Windows.Forms.Button btnBarkodOlustur;
        private System.Windows.Forms.PictureBox pbUrun;
        private System.Windows.Forms.Label label5;
    }
}