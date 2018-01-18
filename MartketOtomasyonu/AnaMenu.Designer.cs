namespace MartketOtomasyonu
{
    partial class AnaMenu
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
            this.btnUrunler = new System.Windows.Forms.Button();
            this.btnSiparisYonetimi = new System.Windows.Forms.Button();
            this.btnStokYonetimi = new System.Windows.Forms.Button();
            this.btnSiparisler = new System.Windows.Forms.Button();
            this.btnKategoriler = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnUrunler
            // 
            this.btnUrunler.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUrunler.Location = new System.Drawing.Point(97, 86);
            this.btnUrunler.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUrunler.Name = "btnUrunler";
            this.btnUrunler.Size = new System.Drawing.Size(199, 78);
            this.btnUrunler.TabIndex = 0;
            this.btnUrunler.Text = "Ürün Yönetimi";
            this.btnUrunler.UseVisualStyleBackColor = true;
            this.btnUrunler.Click += new System.EventHandler(this.btnUrunler_Click);
            // 
            // btnSiparisYonetimi
            // 
            this.btnSiparisYonetimi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSiparisYonetimi.Location = new System.Drawing.Point(373, 201);
            this.btnSiparisYonetimi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSiparisYonetimi.Name = "btnSiparisYonetimi";
            this.btnSiparisYonetimi.Size = new System.Drawing.Size(199, 78);
            this.btnSiparisYonetimi.TabIndex = 1;
            this.btnSiparisYonetimi.Text = "Rapor Yönetimi";
            this.btnSiparisYonetimi.UseVisualStyleBackColor = true;
            this.btnSiparisYonetimi.Click += new System.EventHandler(this.btnSiparisYonetimi_Click);
            // 
            // btnStokYonetimi
            // 
            this.btnStokYonetimi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnStokYonetimi.Location = new System.Drawing.Point(373, 86);
            this.btnStokYonetimi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnStokYonetimi.Name = "btnStokYonetimi";
            this.btnStokYonetimi.Size = new System.Drawing.Size(199, 78);
            this.btnStokYonetimi.TabIndex = 2;
            this.btnStokYonetimi.Text = "StokYönetimi";
            this.btnStokYonetimi.UseVisualStyleBackColor = true;
            this.btnStokYonetimi.Click += new System.EventHandler(this.btnStokYonetimi_Click);
            // 
            // btnSiparisler
            // 
            this.btnSiparisler.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSiparisler.Location = new System.Drawing.Point(97, 308);
            this.btnSiparisler.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSiparisler.Name = "btnSiparisler";
            this.btnSiparisler.Size = new System.Drawing.Size(199, 78);
            this.btnSiparisler.TabIndex = 3;
            this.btnSiparisler.Text = "Alışveriş Yap";
            this.btnSiparisler.UseVisualStyleBackColor = true;
            this.btnSiparisler.Click += new System.EventHandler(this.btnSiparisler_Click);
            // 
            // btnKategoriler
            // 
            this.btnKategoriler.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKategoriler.Location = new System.Drawing.Point(97, 201);
            this.btnKategoriler.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnKategoriler.Name = "btnKategoriler";
            this.btnKategoriler.Size = new System.Drawing.Size(199, 78);
            this.btnKategoriler.TabIndex = 4;
            this.btnKategoriler.Text = "Kategori Yönetimi";
            this.btnKategoriler.UseVisualStyleBackColor = true;
            this.btnKategoriler.Click += new System.EventHandler(this.btnKategoriler_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button5.Location = new System.Drawing.Point(373, 308);
            this.button5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(199, 78);
            this.button5.TabIndex = 5;
            this.button5.Text = "Çıkış";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // AnaMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 479);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btnKategoriler);
            this.Controls.Add(this.btnSiparisler);
            this.Controls.Add(this.btnStokYonetimi);
            this.Controls.Add(this.btnSiparisYonetimi);
            this.Controls.Add(this.btnUrunler);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AnaMenu";
            this.Text = "AnaMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUrunler;
        private System.Windows.Forms.Button btnSiparisYonetimi;
        private System.Windows.Forms.Button btnStokYonetimi;
        private System.Windows.Forms.Button btnSiparisler;
        private System.Windows.Forms.Button btnKategoriler;
        private System.Windows.Forms.Button button5;
    }
}