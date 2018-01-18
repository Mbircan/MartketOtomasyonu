namespace MartketOtomasyonu.Forms
{
    partial class FormSiparisYonetimi
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
            this.components = new System.ComponentModel.Container();
            this.lstSiparisler = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.teslimEdildiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstSiparisler
            // 
            this.lstSiparisler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader2,
            this.columnHeader3});
            this.lstSiparisler.ContextMenuStrip = this.contextMenuStrip1;
            this.lstSiparisler.FullRowSelect = true;
            this.lstSiparisler.GridLines = true;
            this.lstSiparisler.Location = new System.Drawing.Point(41, 36);
            this.lstSiparisler.Margin = new System.Windows.Forms.Padding(4);
            this.lstSiparisler.MultiSelect = false;
            this.lstSiparisler.Name = "lstSiparisler";
            this.lstSiparisler.Size = new System.Drawing.Size(927, 443);
            this.lstSiparisler.TabIndex = 0;
            this.lstSiparisler.UseCompatibleStateImageBehavior = false;
            this.lstSiparisler.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Sipariş No";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Sipariş Tarihi";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Durum";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tutar";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.teslimEdildiToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(163, 28);
            // 
            // teslimEdildiToolStripMenuItem
            // 
            this.teslimEdildiToolStripMenuItem.Name = "teslimEdildiToolStripMenuItem";
            this.teslimEdildiToolStripMenuItem.Size = new System.Drawing.Size(162, 24);
            this.teslimEdildiToolStripMenuItem.Text = "Teslim Edildi";
            this.teslimEdildiToolStripMenuItem.Click += new System.EventHandler(this.teslimEdildiToolStripMenuItem_Click);
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Ödeme Şekli";
            // 
            // FormSiparisYonetimi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 544);
            this.Controls.Add(this.lstSiparisler);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormSiparisYonetimi";
            this.Text = "FormSiparisYonetimi";
            this.Load += new System.EventHandler(this.FormSiparisYonetimi_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lstSiparisler;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem teslimEdildiToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}