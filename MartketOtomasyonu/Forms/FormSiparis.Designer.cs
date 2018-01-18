namespace MartketOtomasyonu.Forms
{
    partial class FormSiparis
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nmrToplam = new System.Windows.Forms.NumericUpDown();
            this.nmrIndirim = new System.Windows.Forms.NumericUpDown();
            this.nmrKDV = new System.Windows.Forms.NumericUpDown();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.btnSepeteEkle = new System.Windows.Forms.Button();
            this.lstSepet = new System.Windows.Forms.ListBox();
            this.lstUrunler = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBarkod = new System.Windows.Forms.TextBox();
            this.lblStok = new System.Windows.Forms.Label();
            this.btnSiparisVer = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nNakit = new System.Windows.Forms.NumericUpDown();
            this.lblParaUstu = new System.Windows.Forms.Label();
            this.lblPara = new System.Windows.Forms.Label();
            this.lblOdenen = new System.Windows.Forms.Label();
            this.rbKredi = new System.Windows.Forms.RadioButton();
            this.rbNakit = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.nmrToplam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrIndirim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrKDV)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nNakit)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(421, 375);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 24);
            this.label2.TabIndex = 22;
            this.label2.Text = "KDV Tutarı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(464, 329);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 24);
            this.label1.TabIndex = 21;
            this.label1.Text = "Tutar";
            // 
            // nmrToplam
            // 
            this.nmrToplam.DecimalPlaces = 2;
            this.nmrToplam.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nmrToplam.Location = new System.Drawing.Point(560, 327);
            this.nmrToplam.Margin = new System.Windows.Forms.Padding(4);
            this.nmrToplam.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nmrToplam.Name = "nmrToplam";
            this.nmrToplam.ReadOnly = true;
            this.nmrToplam.Size = new System.Drawing.Size(124, 28);
            this.nmrToplam.TabIndex = 20;
            this.nmrToplam.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // nmrIndirim
            // 
            this.nmrIndirim.DecimalPlaces = 2;
            this.nmrIndirim.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nmrIndirim.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nmrIndirim.Location = new System.Drawing.Point(259, 186);
            this.nmrIndirim.Margin = new System.Windows.Forms.Padding(4);
            this.nmrIndirim.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmrIndirim.Name = "nmrIndirim";
            this.nmrIndirim.Size = new System.Drawing.Size(147, 28);
            this.nmrIndirim.TabIndex = 19;
            this.nmrIndirim.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // nmrKDV
            // 
            this.nmrKDV.DecimalPlaces = 2;
            this.nmrKDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nmrKDV.Location = new System.Drawing.Point(560, 375);
            this.nmrKDV.Margin = new System.Windows.Forms.Padding(4);
            this.nmrKDV.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nmrKDV.Name = "nmrKDV";
            this.nmrKDV.ReadOnly = true;
            this.nmrKDV.Size = new System.Drawing.Size(124, 28);
            this.nmrKDV.TabIndex = 18;
            this.nmrKDV.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtAra
            // 
            this.txtAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAra.Location = new System.Drawing.Point(21, 34);
            this.txtAra.Margin = new System.Windows.Forms.Padding(4);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(231, 28);
            this.txtAra.TabIndex = 17;
            this.txtAra.TextChanged += new System.EventHandler(this.txtAra_TextChanged_1);
            // 
            // btnSepeteEkle
            // 
            this.btnSepeteEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSepeteEkle.Location = new System.Drawing.Point(259, 119);
            this.btnSepeteEkle.Margin = new System.Windows.Forms.Padding(4);
            this.btnSepeteEkle.Name = "btnSepeteEkle";
            this.btnSepeteEkle.Size = new System.Drawing.Size(147, 59);
            this.btnSepeteEkle.TabIndex = 16;
            this.btnSepeteEkle.Text = "Sepete Ekle";
            this.btnSepeteEkle.UseVisualStyleBackColor = true;
            this.btnSepeteEkle.Click += new System.EventHandler(this.btnSepeteEkle_Click_1);
            // 
            // lstSepet
            // 
            this.lstSepet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstSepet.FormattingEnabled = true;
            this.lstSepet.ItemHeight = 18;
            this.lstSepet.Location = new System.Drawing.Point(413, 59);
            this.lstSepet.Margin = new System.Windows.Forms.Padding(4);
            this.lstSepet.Name = "lstSepet";
            this.lstSepet.Size = new System.Drawing.Size(271, 220);
            this.lstSepet.TabIndex = 15;
            // 
            // lstUrunler
            // 
            this.lstUrunler.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstUrunler.FormattingEnabled = true;
            this.lstUrunler.ItemHeight = 18;
            this.lstUrunler.Location = new System.Drawing.Point(21, 66);
            this.lstUrunler.Margin = new System.Windows.Forms.Padding(4);
            this.lstUrunler.Name = "lstUrunler";
            this.lstUrunler.Size = new System.Drawing.Size(231, 220);
            this.lstUrunler.TabIndex = 14;
            this.lstUrunler.SelectedIndexChanged += new System.EventHandler(this.lstUrunler_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(43, 354);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 24);
            this.label3.TabIndex = 24;
            this.label3.Text = "BARKOD GİR :";
            // 
            // txtBarkod
            // 
            this.txtBarkod.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBarkod.Location = new System.Drawing.Point(37, 400);
            this.txtBarkod.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBarkod.Name = "txtBarkod";
            this.txtBarkod.Size = new System.Drawing.Size(152, 28);
            this.txtBarkod.TabIndex = 25;
            this.txtBarkod.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBarkod_KeyDown);
            // 
            // lblStok
            // 
            this.lblStok.AutoSize = true;
            this.lblStok.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblStok.Location = new System.Drawing.Point(268, 78);
            this.lblStok.Name = "lblStok";
            this.lblStok.Size = new System.Drawing.Size(0, 18);
            this.lblStok.TabIndex = 26;
            this.lblStok.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSiparisVer
            // 
            this.btnSiparisVer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSiparisVer.Location = new System.Drawing.Point(597, 438);
            this.btnSiparisVer.Margin = new System.Windows.Forms.Padding(4);
            this.btnSiparisVer.Name = "btnSiparisVer";
            this.btnSiparisVer.Size = new System.Drawing.Size(147, 59);
            this.btnSiparisVer.TabIndex = 27;
            this.btnSiparisVer.Text = "Satın Al";
            this.btnSiparisVer.UseVisualStyleBackColor = true;
            this.btnSiparisVer.Click += new System.EventHandler(this.btnSiparisVer_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nNakit);
            this.groupBox1.Controls.Add(this.lblParaUstu);
            this.groupBox1.Controls.Add(this.lblPara);
            this.groupBox1.Controls.Add(this.lblOdenen);
            this.groupBox1.Controls.Add(this.rbKredi);
            this.groupBox1.Controls.Add(this.rbNakit);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(691, 59);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(319, 342);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ödeme Şekli";
            // 
            // nNakit
            // 
            this.nNakit.DecimalPlaces = 2;
            this.nNakit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nNakit.Location = new System.Drawing.Point(165, 162);
            this.nNakit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nNakit.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.nNakit.Name = "nNakit";
            this.nNakit.Size = new System.Drawing.Size(100, 26);
            this.nNakit.TabIndex = 16;
            this.nNakit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nNakit.Visible = false;
            this.nNakit.ValueChanged += new System.EventHandler(this.nNakit_ValueChanged);
            // 
            // lblParaUstu
            // 
            this.lblParaUstu.AutoSize = true;
            this.lblParaUstu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblParaUstu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblParaUstu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblParaUstu.Location = new System.Drawing.Point(165, 206);
            this.lblParaUstu.MinimumSize = new System.Drawing.Size(100, 25);
            this.lblParaUstu.Name = "lblParaUstu";
            this.lblParaUstu.Size = new System.Drawing.Size(100, 25);
            this.lblParaUstu.TabIndex = 5;
            this.lblParaUstu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblParaUstu.Visible = false;
            // 
            // lblPara
            // 
            this.lblPara.AutoSize = true;
            this.lblPara.Location = new System.Drawing.Point(69, 212);
            this.lblPara.Name = "lblPara";
            this.lblPara.Size = new System.Drawing.Size(74, 18);
            this.lblPara.TabIndex = 4;
            this.lblPara.Text = "Para Üstü";
            this.lblPara.Visible = false;
            // 
            // lblOdenen
            // 
            this.lblOdenen.AutoSize = true;
            this.lblOdenen.Location = new System.Drawing.Point(43, 165);
            this.lblOdenen.Name = "lblOdenen";
            this.lblOdenen.Size = new System.Drawing.Size(105, 18);
            this.lblOdenen.TabIndex = 3;
            this.lblOdenen.Text = "Ödenen Miktar";
            this.lblOdenen.Visible = false;
            // 
            // rbKredi
            // 
            this.rbKredi.AutoSize = true;
            this.rbKredi.Location = new System.Drawing.Point(37, 79);
            this.rbKredi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbKredi.Name = "rbKredi";
            this.rbKredi.Size = new System.Drawing.Size(97, 22);
            this.rbKredi.TabIndex = 1;
            this.rbKredi.TabStop = true;
            this.rbKredi.Text = "Kredi Kartı";
            this.rbKredi.UseVisualStyleBackColor = true;
            this.rbKredi.CheckedChanged += new System.EventHandler(this.rbKredi_CheckedChanged);
            // 
            // rbNakit
            // 
            this.rbNakit.AutoSize = true;
            this.rbNakit.Location = new System.Drawing.Point(37, 39);
            this.rbNakit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbNakit.Name = "rbNakit";
            this.rbNakit.Size = new System.Drawing.Size(63, 22);
            this.rbNakit.TabIndex = 0;
            this.rbNakit.TabStop = true;
            this.rbNakit.Text = "Nakit";
            this.rbNakit.UseVisualStyleBackColor = true;
            this.rbNakit.CheckedChanged += new System.EventHandler(this.rbNakit_CheckedChanged);
            // 
            // FormSiparis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 542);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSiparisVer);
            this.Controls.Add(this.lblStok);
            this.Controls.Add(this.txtBarkod);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nmrToplam);
            this.Controls.Add(this.nmrIndirim);
            this.Controls.Add(this.nmrKDV);
            this.Controls.Add(this.txtAra);
            this.Controls.Add(this.btnSepeteEkle);
            this.Controls.Add(this.lstSepet);
            this.Controls.Add(this.lstUrunler);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormSiparis";
            this.Text = "FormSiparis";
            this.Load += new System.EventHandler(this.FormSiparis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmrToplam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrIndirim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrKDV)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nNakit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nmrToplam;
        private System.Windows.Forms.NumericUpDown nmrIndirim;
        private System.Windows.Forms.NumericUpDown nmrKDV;
        private System.Windows.Forms.TextBox txtAra;
        private System.Windows.Forms.Button btnSepeteEkle;
        private System.Windows.Forms.ListBox lstSepet;
        private System.Windows.Forms.ListBox lstUrunler;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBarkod;
        private System.Windows.Forms.Label lblStok;
        private System.Windows.Forms.Button btnSiparisVer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbKredi;
        private System.Windows.Forms.RadioButton rbNakit;
        private System.Windows.Forms.Label lblParaUstu;
        private System.Windows.Forms.Label lblPara;
        private System.Windows.Forms.Label lblOdenen;
        private System.Windows.Forms.NumericUpDown nNakit;
    }
}