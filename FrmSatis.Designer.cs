namespace MarketOtomasyon
{
    partial class FrmSatis
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            splitAna = new DevExpress.XtraEditors.SplitContainerControl();
            flowUrunler = new System.Windows.Forms.FlowLayoutPanel();
            pnlUstBarkod = new DevExpress.XtraEditors.PanelControl();
            txtBarkod = new DevExpress.XtraEditors.TextEdit();
            lblBarkod = new DevExpress.XtraEditors.LabelControl();
            gridSepet = new DevExpress.XtraGrid.GridControl();
            gridViewSepet = new DevExpress.XtraGrid.Views.Grid.GridView();
            colUrunAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            colAdet = new DevExpress.XtraGrid.Columns.GridColumn();
            colFiyat = new DevExpress.XtraGrid.Columns.GridColumn();
            colTutar = new DevExpress.XtraGrid.Columns.GridColumn();
            pnlAltOdeme = new DevExpress.XtraEditors.PanelControl();
            btnKrediKarti = new DevExpress.XtraEditors.SimpleButton();
            btnNakit = new DevExpress.XtraEditors.SimpleButton();
            lblToplamTutar = new DevExpress.XtraEditors.LabelControl();
            lblToplamBaslik = new DevExpress.XtraEditors.LabelControl();
            lblAlinanParaBaslik = new DevExpress.XtraEditors.LabelControl();
            txtAlinanPara = new DevExpress.XtraEditors.TextEdit();
            lblParaUstuBaslik = new DevExpress.XtraEditors.LabelControl();
            lblParaUstuTutar = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)splitAna).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitAna.Panel1).BeginInit();
            splitAna.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitAna.Panel2).BeginInit();
            splitAna.Panel2.SuspendLayout();
            splitAna.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pnlUstBarkod).BeginInit();
            pnlUstBarkod.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtBarkod.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridSepet).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridViewSepet).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pnlAltOdeme).BeginInit();
            pnlAltOdeme.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtAlinanPara.Properties).BeginInit();
            SuspendLayout();
            // 
            // splitAna
            // 
            splitAna.Dock = System.Windows.Forms.DockStyle.Fill;
            splitAna.Location = new System.Drawing.Point(0, 0);
            splitAna.Name = "splitAna";
            // 
            // splitAna.Panel1
            // 
            splitAna.Panel1.Controls.Add(flowUrunler);
            splitAna.Panel1.Controls.Add(pnlUstBarkod);
            splitAna.Panel1.Text = "Panel1";
            // 
            // splitAna.Panel2
            // 
            splitAna.Panel2.Controls.Add(gridSepet);
            splitAna.Panel2.Controls.Add(pnlAltOdeme);
            splitAna.Panel2.Text = "Panel2";
            splitAna.Size = new System.Drawing.Size(1713, 700);
            splitAna.SplitterPosition = 750;
            splitAna.TabIndex = 0;
            // 
            // flowUrunler
            // 
            flowUrunler.AutoScroll = true;
            flowUrunler.BackColor = System.Drawing.Color.WhiteSmoke;
            flowUrunler.Dock = System.Windows.Forms.DockStyle.Fill;
            flowUrunler.Location = new System.Drawing.Point(0, 60);
            flowUrunler.Name = "flowUrunler";
            flowUrunler.Padding = new System.Windows.Forms.Padding(10);
            flowUrunler.Size = new System.Drawing.Size(750, 640);
            flowUrunler.TabIndex = 1;
            // 
            // pnlUstBarkod
            // 
            pnlUstBarkod.Controls.Add(txtBarkod);
            pnlUstBarkod.Controls.Add(lblBarkod);
            pnlUstBarkod.Dock = System.Windows.Forms.DockStyle.Top;
            pnlUstBarkod.Location = new System.Drawing.Point(0, 0);
            pnlUstBarkod.Name = "pnlUstBarkod";
            pnlUstBarkod.Size = new System.Drawing.Size(750, 60);
            pnlUstBarkod.TabIndex = 0;
            // 
            // txtBarkod
            // 
            txtBarkod.Location = new System.Drawing.Point(130, 12);
            txtBarkod.Name = "txtBarkod";
            txtBarkod.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            txtBarkod.Properties.Appearance.Options.UseFont = true;
            txtBarkod.Size = new System.Drawing.Size(400, 44);
            txtBarkod.TabIndex = 1;
            // 
            // lblBarkod
            // 
            lblBarkod.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            lblBarkod.Appearance.Options.UseFont = true;
            lblBarkod.Location = new System.Drawing.Point(20, 20);
            lblBarkod.Name = "lblBarkod";
            lblBarkod.Size = new System.Drawing.Size(88, 28);
            lblBarkod.TabIndex = 0;
            lblBarkod.Text = "BARKOD:";
            // 
            // gridSepet
            // 
            gridSepet.Dock = System.Windows.Forms.DockStyle.Fill;
            gridSepet.Location = new System.Drawing.Point(0, 0);
            gridSepet.MainView = gridViewSepet;
            gridSepet.Name = "gridSepet";
            gridSepet.Size = new System.Drawing.Size(951, 500);
            gridSepet.TabIndex = 0;
            gridSepet.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridViewSepet });
            // 
            // gridViewSepet
            // 
            gridViewSepet.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 11F);
            gridViewSepet.Appearance.Row.Options.UseFont = true;
            gridViewSepet.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colUrunAdi, colAdet, colFiyat, colTutar });
            gridViewSepet.GridControl = gridSepet;
            gridViewSepet.Name = "gridViewSepet";
            gridViewSepet.OptionsBehavior.Editable = false;
            gridViewSepet.OptionsView.ShowGroupPanel = false;
            // 
            // colUrunAdi
            // 
            colUrunAdi.Caption = "Ürün Adı";
            colUrunAdi.FieldName = "UrunAdi";
            colUrunAdi.Name = "colUrunAdi";
            colUrunAdi.Visible = true;
            colUrunAdi.VisibleIndex = 0;
            colUrunAdi.Width = 150;
            // 
            // colAdet
            // 
            colAdet.Caption = "Adet";
            colAdet.FieldName = "Adet";
            colAdet.Name = "colAdet";
            colAdet.Visible = true;
            colAdet.VisibleIndex = 1;
            colAdet.Width = 50;
            // 
            // colFiyat
            // 
            colFiyat.Caption = "Fiyat";
            colFiyat.FieldName = "Fiyat";
            colFiyat.Name = "colFiyat";
            colFiyat.Visible = true;
            colFiyat.VisibleIndex = 2;
            colFiyat.Width = 70;
            // 
            // colTutar
            // 
            colTutar.Caption = "Tutar";
            colTutar.FieldName = "Toplam";
            colTutar.Name = "colTutar";
            colTutar.Visible = true;
            colTutar.VisibleIndex = 3;
            colTutar.Width = 80;
            // 
            // pnlAltOdeme
            // 
            pnlAltOdeme.Appearance.BackColor = System.Drawing.Color.White;
            pnlAltOdeme.Appearance.Options.UseBackColor = true;
            pnlAltOdeme.Controls.Add(btnKrediKarti);
            pnlAltOdeme.Controls.Add(btnNakit);
            pnlAltOdeme.Controls.Add(lblToplamTutar);
            pnlAltOdeme.Controls.Add(lblToplamBaslik);
            pnlAltOdeme.Controls.Add(lblAlinanParaBaslik);
            pnlAltOdeme.Controls.Add(txtAlinanPara);
            pnlAltOdeme.Controls.Add(lblParaUstuBaslik);
            pnlAltOdeme.Controls.Add(lblParaUstuTutar);
            pnlAltOdeme.Dock = System.Windows.Forms.DockStyle.Bottom;
            pnlAltOdeme.Location = new System.Drawing.Point(0, 500);
            pnlAltOdeme.Name = "pnlAltOdeme";
            pnlAltOdeme.Size = new System.Drawing.Size(951, 200);
            pnlAltOdeme.TabIndex = 1;
            // 
            // btnKrediKarti
            // 
            btnKrediKarti.Appearance.BackColor = System.Drawing.Color.FromArgb(255, 128, 0);
            btnKrediKarti.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            btnKrediKarti.Appearance.ForeColor = System.Drawing.Color.White;
            btnKrediKarti.Appearance.Options.UseBackColor = true;
            btnKrediKarti.Appearance.Options.UseFont = true;
            btnKrediKarti.Appearance.Options.UseForeColor = true;
            btnKrediKarti.Location = new System.Drawing.Point(225, 110);
            btnKrediKarti.Name = "btnKrediKarti";
            btnKrediKarti.Size = new System.Drawing.Size(200, 70);
            btnKrediKarti.TabIndex = 3;
            btnKrediKarti.Text = "KREDİ KARTI";
            btnKrediKarti.Click += btnKrediKarti_Click;
            // 
            // btnNakit
            // 
            btnNakit.Appearance.BackColor = System.Drawing.Color.SeaGreen;
            btnNakit.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            btnNakit.Appearance.ForeColor = System.Drawing.Color.White;
            btnNakit.Appearance.Options.UseBackColor = true;
            btnNakit.Appearance.Options.UseFont = true;
            btnNakit.Appearance.Options.UseForeColor = true;
            btnNakit.Location = new System.Drawing.Point(15, 110);
            btnNakit.Name = "btnNakit";
            btnNakit.Size = new System.Drawing.Size(200, 70);
            btnNakit.TabIndex = 2;
            btnNakit.Text = "NAKİT";
            btnNakit.Click += btnNakit_Click;
            // 
            // lblToplamTutar
            // 
            lblToplamTutar.Appearance.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            lblToplamTutar.Appearance.ForeColor = System.Drawing.Color.Maroon;
            lblToplamTutar.Appearance.Options.UseFont = true;
            lblToplamTutar.Appearance.Options.UseForeColor = true;
            lblToplamTutar.Appearance.Options.UseTextOptions = true;
            lblToplamTutar.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            lblToplamTutar.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            lblToplamTutar.Location = new System.Drawing.Point(15, 40);
            lblToplamTutar.Name = "lblToplamTutar";
            lblToplamTutar.Size = new System.Drawing.Size(410, 60);
            lblToplamTutar.TabIndex = 1;
            lblToplamTutar.Text = "0,00 ₺";
            // 
            // lblToplamBaslik
            // 
            lblToplamBaslik.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F);
            lblToplamBaslik.Appearance.Options.UseFont = true;
            lblToplamBaslik.Location = new System.Drawing.Point(15, 10);
            lblToplamBaslik.Name = "lblToplamBaslik";
            lblToplamBaslik.Size = new System.Drawing.Size(140, 28);
            lblToplamBaslik.TabIndex = 0;
            lblToplamBaslik.Text = "TOPLAM TUTAR";
            // 
            // lblAlinanParaBaslik
            // 
            lblAlinanParaBaslik.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F);
            lblAlinanParaBaslik.Appearance.Options.UseFont = true;
            lblAlinanParaBaslik.Location = new System.Drawing.Point(450, 10);
            lblAlinanParaBaslik.Name = "lblAlinanParaBaslik";
            lblAlinanParaBaslik.Size = new System.Drawing.Size(124, 28);
            lblAlinanParaBaslik.TabIndex = 4;
            lblAlinanParaBaslik.Text = "ALINAN PARA";
            // 
            // txtAlinanPara
            // 
            txtAlinanPara.EditValue = "0,00";
            txtAlinanPara.Location = new System.Drawing.Point(450, 40);
            txtAlinanPara.Name = "txtAlinanPara";
            txtAlinanPara.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            txtAlinanPara.Properties.Appearance.Options.UseFont = true;
            txtAlinanPara.Size = new System.Drawing.Size(200, 44);
            txtAlinanPara.TabIndex = 5;
            // 
            // lblParaUstuBaslik
            // 
            lblParaUstuBaslik.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F);
            lblParaUstuBaslik.Appearance.Options.UseFont = true;
            lblParaUstuBaslik.Location = new System.Drawing.Point(680, 10);
            lblParaUstuBaslik.Name = "lblParaUstuBaslik";
            lblParaUstuBaslik.Size = new System.Drawing.Size(103, 28);
            lblParaUstuBaslik.TabIndex = 6;
            lblParaUstuBaslik.Text = "PARA ÜSTÜ";
            // 
            // lblParaUstuTutar
            // 
            lblParaUstuTutar.Appearance.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            lblParaUstuTutar.Appearance.ForeColor = System.Drawing.Color.Green;
            lblParaUstuTutar.Appearance.Options.UseFont = true;
            lblParaUstuTutar.Appearance.Options.UseForeColor = true;
            lblParaUstuTutar.Location = new System.Drawing.Point(680, 40);
            lblParaUstuTutar.Name = "lblParaUstuTutar";
            lblParaUstuTutar.Size = new System.Drawing.Size(114, 54);
            lblParaUstuTutar.TabIndex = 7;
            lblParaUstuTutar.Text = "0,00 ₺";
            // 
            // FrmSatis
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1713, 700);
            Controls.Add(splitAna);
            Name = "FrmSatis";
            Text = "Hızlı Satış Ekranı";
            WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)splitAna.Panel1).EndInit();
            splitAna.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitAna.Panel2).EndInit();
            splitAna.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitAna).EndInit();
            splitAna.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pnlUstBarkod).EndInit();
            pnlUstBarkod.ResumeLayout(false);
            pnlUstBarkod.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtBarkod.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridSepet).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridViewSepet).EndInit();
            ((System.ComponentModel.ISupportInitialize)pnlAltOdeme).EndInit();
            pnlAltOdeme.ResumeLayout(false);
            pnlAltOdeme.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtAlinanPara.Properties).EndInit();
            ResumeLayout(false);





        }

        #endregion
        private DevExpress.XtraEditors.LabelControl lblAlinanParaBaslik;
        private DevExpress.XtraEditors.TextEdit txtAlinanPara;
        private DevExpress.XtraEditors.LabelControl lblParaUstuBaslik;
        private DevExpress.XtraEditors.LabelControl lblParaUstuTutar;



        private DevExpress.XtraEditors.SplitContainerControl splitAna;
        private System.Windows.Forms.FlowLayoutPanel flowUrunler;
        private DevExpress.XtraEditors.PanelControl pnlUstBarkod;
        private DevExpress.XtraEditors.TextEdit txtBarkod;
        private DevExpress.XtraEditors.LabelControl lblBarkod;
        private DevExpress.XtraGrid.GridControl gridSepet;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewSepet;
        private DevExpress.XtraEditors.PanelControl pnlAltOdeme;
        private DevExpress.XtraEditors.SimpleButton btnKrediKarti;
        private DevExpress.XtraEditors.SimpleButton btnNakit;
        private DevExpress.XtraEditors.LabelControl lblToplamTutar;
        private DevExpress.XtraEditors.LabelControl lblToplamBaslik;
        private DevExpress.XtraGrid.Columns.GridColumn colUrunAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colAdet;
        private DevExpress.XtraGrid.Columns.GridColumn colFiyat;
        private DevExpress.XtraGrid.Columns.GridColumn colTutar;
    }
}