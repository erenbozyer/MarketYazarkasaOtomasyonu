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
            this.splitAna = new DevExpress.XtraEditors.SplitContainerControl();
            this.flowUrunler = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlUstBarkod = new DevExpress.XtraEditors.PanelControl();
            this.txtBarkod = new DevExpress.XtraEditors.TextEdit();
            this.lblBarkod = new DevExpress.XtraEditors.LabelControl();
            this.gridSepet = new DevExpress.XtraGrid.GridControl();
            this.gridViewSepet = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colUrunAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAdet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFiyat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTutar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pnlAltOdeme = new DevExpress.XtraEditors.PanelControl();
            this.btnKrediKarti = new DevExpress.XtraEditors.SimpleButton();
            this.btnNakit = new DevExpress.XtraEditors.SimpleButton();
            this.lblToplamTutar = new DevExpress.XtraEditors.LabelControl();
            this.lblToplamBaslik = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.splitAna)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitAna.Panel1)).BeginInit();
            this.splitAna.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitAna.Panel2)).BeginInit();
            this.splitAna.Panel2.SuspendLayout();
            this.splitAna.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlUstBarkod)).BeginInit();
            this.pnlUstBarkod.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBarkod.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSepet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSepet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlAltOdeme)).BeginInit();
            this.pnlAltOdeme.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitAna
            // 
            this.splitAna.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitAna.Location = new System.Drawing.Point(0, 0);
            this.splitAna.Name = "splitAna";
            // 
            // splitAna.Panel1 (SOL - ÜRÜNLER)
            // 
            this.splitAna.Panel1.Controls.Add(this.flowUrunler);
            this.splitAna.Panel1.Controls.Add(this.pnlUstBarkod);
            this.splitAna.Panel1.Text = "Panel1";
            // 
            // splitAna.Panel2 (SAĞ - SEPET)
            // 
            this.splitAna.Panel2.Controls.Add(this.gridSepet);
            this.splitAna.Panel2.Controls.Add(this.pnlAltOdeme);
            this.splitAna.Panel2.Text = "Panel2";
            this.splitAna.Size = new System.Drawing.Size(1200, 700);
            this.splitAna.SplitterPosition = 750; // Sol taraf daha geniş
            this.splitAna.TabIndex = 0;
            // 
            // flowUrunler (Dinamik Butonlar Buraya Gelecek)
            // 
            this.flowUrunler.AutoScroll = true;
            this.flowUrunler.BackColor = System.Drawing.Color.WhiteSmoke;
            this.flowUrunler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowUrunler.Location = new System.Drawing.Point(0, 60);
            this.flowUrunler.Name = "flowUrunler";
            this.flowUrunler.Padding = new System.Windows.Forms.Padding(10);
            this.flowUrunler.Size = new System.Drawing.Size(750, 640);
            this.flowUrunler.TabIndex = 1;
            // 
            // pnlUstBarkod
            // 
            this.pnlUstBarkod.Controls.Add(this.txtBarkod);
            this.pnlUstBarkod.Controls.Add(this.lblBarkod);
            this.pnlUstBarkod.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUstBarkod.Location = new System.Drawing.Point(0, 0);
            this.pnlUstBarkod.Name = "pnlUstBarkod";
            this.pnlUstBarkod.Size = new System.Drawing.Size(750, 60);
            this.pnlUstBarkod.TabIndex = 0;
            // 
            // txtBarkod
            // 
            this.txtBarkod.Location = new System.Drawing.Point(130, 12);
            this.txtBarkod.Name = "txtBarkod";
            this.txtBarkod.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.txtBarkod.Properties.Appearance.Options.UseFont = true;
            this.txtBarkod.Size = new System.Drawing.Size(400, 44);
            this.txtBarkod.TabIndex = 1;
            // 
            // lblBarkod
            // 
            this.lblBarkod.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblBarkod.Appearance.Options.UseFont = true;
            this.lblBarkod.Location = new System.Drawing.Point(20, 20);
            this.lblBarkod.Name = "lblBarkod";
            this.lblBarkod.Size = new System.Drawing.Size(95, 28);
            this.lblBarkod.TabIndex = 0;
            this.lblBarkod.Text = "BARKOD:";
            // 
            // gridSepet
            // 
            this.gridSepet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridSepet.Location = new System.Drawing.Point(0, 0);
            this.gridSepet.MainView = this.gridViewSepet;
            this.gridSepet.Name = "gridSepet";
            this.gridSepet.Size = new System.Drawing.Size(438, 500);
            this.gridSepet.TabIndex = 0;
            this.gridSepet.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewSepet});
            // 
            // gridViewSepet
            // 
            this.gridViewSepet.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 11F); // Satır yazı boyutu
            this.gridViewSepet.Appearance.Row.Options.UseFont = true;
            this.gridViewSepet.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colUrunAdi,
            this.colAdet,
            this.colFiyat,
            this.colTutar});
            this.gridViewSepet.GridControl = this.gridSepet;
            this.gridViewSepet.Name = "gridViewSepet";
            this.gridViewSepet.OptionsView.ShowGroupPanel = false; // Üstteki gruplama alanı gizlensin
            this.gridViewSepet.OptionsBehavior.Editable = false; // Elle değiştirilemesin
            // 
            // colUrunAdi
            // 
            this.colUrunAdi.Caption = "Ürün Adı";
            this.colUrunAdi.FieldName = "UrunAdi";
            this.colUrunAdi.Name = "colUrunAdi";
            this.colUrunAdi.Visible = true;
            this.colUrunAdi.VisibleIndex = 0;
            this.colUrunAdi.Width = 150;
            // 
            // colAdet
            // 
            this.colAdet.Caption = "Adet";
            this.colAdet.FieldName = "Adet";
            this.colAdet.Name = "colAdet";
            this.colAdet.Visible = true;
            this.colAdet.VisibleIndex = 1;
            this.colAdet.Width = 50;
            // 
            // colFiyat
            // 
            this.colFiyat.Caption = "Fiyat";
            this.colFiyat.FieldName = "Fiyat";
            this.colFiyat.Name = "colFiyat";
            this.colFiyat.Visible = true;
            this.colFiyat.VisibleIndex = 2;
            this.colFiyat.Width = 70;
            // 
            // colTutar
            // 
            this.colTutar.Caption = "Tutar";
            this.colTutar.FieldName = "Toplam";
            this.colTutar.Name = "colTutar";
            this.colTutar.Visible = true;
            this.colTutar.VisibleIndex = 3;
            this.colTutar.Width = 80;
            // 
            // pnlAltOdeme
            // 
            this.pnlAltOdeme.Appearance.BackColor = System.Drawing.Color.White;
            this.pnlAltOdeme.Appearance.Options.UseBackColor = true;
            this.pnlAltOdeme.Controls.Add(this.btnKrediKarti);
            this.pnlAltOdeme.Controls.Add(this.btnNakit);
            this.pnlAltOdeme.Controls.Add(this.lblToplamTutar);
            this.pnlAltOdeme.Controls.Add(this.lblToplamBaslik);
            this.pnlAltOdeme.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlAltOdeme.Location = new System.Drawing.Point(0, 500);
            this.pnlAltOdeme.Name = "pnlAltOdeme";
            this.pnlAltOdeme.Size = new System.Drawing.Size(438, 200);
            this.pnlAltOdeme.TabIndex = 1;
            // 
            // btnKrediKarti
            // 
            this.btnKrediKarti.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnKrediKarti.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnKrediKarti.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnKrediKarti.Appearance.Options.UseBackColor = true;
            this.btnKrediKarti.Appearance.Options.UseFont = true;
            this.btnKrediKarti.Appearance.Options.UseForeColor = true;
            this.btnKrediKarti.Location = new System.Drawing.Point(225, 110);
            this.btnKrediKarti.Name = "btnKrediKarti";
            this.btnKrediKarti.Size = new System.Drawing.Size(200, 70);
            this.btnKrediKarti.TabIndex = 3;
            this.btnKrediKarti.Text = "KREDİ KARTI";
            this.btnKrediKarti.Click += new System.EventHandler(this.btnKrediKarti_Click);
            // 
            // btnNakit
            // 
            this.btnNakit.Appearance.BackColor = System.Drawing.Color.SeaGreen;
            this.btnNakit.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnNakit.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnNakit.Appearance.Options.UseBackColor = true;
            this.btnNakit.Appearance.Options.UseFont = true;
            this.btnNakit.Appearance.Options.UseForeColor = true;
            this.btnNakit.Location = new System.Drawing.Point(15, 110);
            this.btnNakit.Name = "btnNakit";
            this.btnNakit.Size = new System.Drawing.Size(200, 70);
            this.btnNakit.TabIndex = 2;
            this.btnNakit.Text = "NAKİT";
            this.btnNakit.Click += new System.EventHandler(this.btnNakit_Click);
            // 
            // lblToplamTutar
            // 
            this.lblToplamTutar.Appearance.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.lblToplamTutar.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.lblToplamTutar.Appearance.Options.UseFont = true;
            this.lblToplamTutar.Appearance.Options.UseForeColor = true;
            this.lblToplamTutar.Appearance.Options.UseTextOptions = true;
            this.lblToplamTutar.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.lblToplamTutar.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblToplamTutar.Location = new System.Drawing.Point(15, 40);
            this.lblToplamTutar.Name = "lblToplamTutar";
            this.lblToplamTutar.Size = new System.Drawing.Size(410, 60);
            this.lblToplamTutar.TabIndex = 1;
            this.lblToplamTutar.Text = "0,00 ₺";
            // 
            // lblToplamBaslik
            // 
            this.lblToplamBaslik.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblToplamBaslik.Appearance.Options.UseFont = true;
            this.lblToplamBaslik.Location = new System.Drawing.Point(15, 10);
            this.lblToplamBaslik.Name = "lblToplamBaslik";
            this.lblToplamBaslik.Size = new System.Drawing.Size(133, 28);
            this.lblToplamBaslik.TabIndex = 0;
            this.lblToplamBaslik.Text = "TOPLAM TUTAR";
            // 
            // FrmSatis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.splitAna);
            this.Name = "FrmSatis";
            this.Text = "Hızlı Satış Ekranı";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.splitAna.Panel1)).EndInit();
            this.splitAna.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitAna.Panel2)).EndInit();
            this.splitAna.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitAna)).EndInit();
            this.splitAna.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlUstBarkod)).EndInit();
            this.pnlUstBarkod.ResumeLayout(false);
            this.pnlUstBarkod.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBarkod.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSepet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSepet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlAltOdeme)).EndInit();
            this.pnlAltOdeme.ResumeLayout(false);
            this.pnlAltOdeme.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

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