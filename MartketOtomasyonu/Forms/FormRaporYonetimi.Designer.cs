﻿namespace MartketOtomasyonu.Forms
{
    partial class FormRaporYonetimi
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
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.teslimEdildiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dtpIlk = new System.Windows.Forms.DateTimePicker();
            this.dtpSon = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbOdemeSekli = new System.Windows.Forms.ComboBox();
            this.btnGoruntule = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstSiparisler
            // 
            this.lstSiparisler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader7,
            this.columnHeader2,
            this.columnHeader3});
            this.lstSiparisler.ContextMenuStrip = this.contextMenuStrip1;
            this.lstSiparisler.FullRowSelect = true;
            this.lstSiparisler.GridLines = true;
            this.lstSiparisler.Location = new System.Drawing.Point(41, 104);
            this.lstSiparisler.Margin = new System.Windows.Forms.Padding(4);
            this.lstSiparisler.MultiSelect = false;
            this.lstSiparisler.Name = "lstSiparisler";
            this.lstSiparisler.Size = new System.Drawing.Size(927, 375);
            this.lstSiparisler.TabIndex = 0;
            this.lstSiparisler.UseCompatibleStateImageBehavior = false;
            this.lstSiparisler.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Satış No";
            this.columnHeader1.Width = 89;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Satış Tarihi";
            this.columnHeader7.Width = 99;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tutar";
            this.columnHeader2.Width = 76;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Ödeme Şekli";
            this.columnHeader3.Width = 114;
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
            // 
            // dtpIlk
            // 
            this.dtpIlk.Location = new System.Drawing.Point(41, 49);
            this.dtpIlk.Name = "dtpIlk";
            this.dtpIlk.Size = new System.Drawing.Size(200, 22);
            this.dtpIlk.TabIndex = 1;
            // 
            // dtpSon
            // 
            this.dtpSon.Location = new System.Drawing.Point(264, 49);
            this.dtpSon.Name = "dtpSon";
            this.dtpSon.Size = new System.Drawing.Size(200, 22);
            this.dtpSon.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(596, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ödeme Şekli";
            // 
            // cmbOdemeSekli
            // 
            this.cmbOdemeSekli.FormattingEnabled = true;
            this.cmbOdemeSekli.Items.AddRange(new object[] {
            "Nakit",
            "Kredi Kartı",
            "Nakit veya Kredi Kartı"});
            this.cmbOdemeSekli.Location = new System.Drawing.Point(690, 54);
            this.cmbOdemeSekli.Name = "cmbOdemeSekli";
            this.cmbOdemeSekli.Size = new System.Drawing.Size(162, 24);
            this.cmbOdemeSekli.TabIndex = 4;
            this.cmbOdemeSekli.SelectedIndexChanged += new System.EventHandler(this.cmbOdemeSekli_SelectedIndexChanged);
            // 
            // btnGoruntule
            // 
            this.btnGoruntule.Location = new System.Drawing.Point(485, 47);
            this.btnGoruntule.Name = "btnGoruntule";
            this.btnGoruntule.Size = new System.Drawing.Size(90, 31);
            this.btnGoruntule.TabIndex = 5;
            this.btnGoruntule.Text = "Görüntüle";
            this.btnGoruntule.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Başlangıç";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(261, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Bitiş";
            // 
            // FormRaporYonetimi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 544);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnGoruntule);
            this.Controls.Add(this.cmbOdemeSekli);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpSon);
            this.Controls.Add(this.dtpIlk);
            this.Controls.Add(this.lstSiparisler);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormRaporYonetimi";
            this.Text = "FormSiparisYonetimi";
            this.Load += new System.EventHandler(this.FormSiparisYonetimi_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstSiparisler;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem teslimEdildiToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.DateTimePicker dtpIlk;
        private System.Windows.Forms.DateTimePicker dtpSon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbOdemeSekli;
        private System.Windows.Forms.Button btnGoruntule;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}