namespace MarketOtomasyon
{
    partial class FrmUrunler
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
            this.groupIslemler = new DevExpress.XtraEditors.GroupControl();
            this.btnTemizle = new DevExpress.XtraEditors.SimpleButton();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.txtStok = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtSatisFiyat = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtAlisFiyat = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtKategori = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtUrunAdi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtBarkod = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gridUrunler = new DevExpress.XtraGrid.GridControl();
            this.gridViewUrunler = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.groupIslemler)).BeginInit();
            this.groupIslemler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtStok.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSatisFiyat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAlisFiyat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKategori.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUrunAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBarkod.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridUrunler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewUrunler)).BeginInit();
            this.SuspendLayout();

            // --- SOL PANEL (GİRİŞ) ---
            this.groupIslemler.Controls.Add(this.btnTemizle);
            this.groupIslemler.Controls.Add(this.btnSil);
            this.groupIslemler.Controls.Add(this.btnKaydet);
            this.groupIslemler.Controls.Add(this.txtStok);
            this.groupIslemler.Controls.Add(this.labelControl6);
            this.groupIslemler.Controls.Add(this.txtSatisFiyat);
            this.groupIslemler.Controls.Add(this.labelControl5);
            this.groupIslemler.Controls.Add(this.txtAlisFiyat);
            this.groupIslemler.Controls.Add(this.labelControl4);
            this.groupIslemler.Controls.Add(this.txtKategori);
            this.groupIslemler.Controls.Add(this.labelControl3);
            this.groupIslemler.Controls.Add(this.txtUrunAdi);
            this.groupIslemler.Controls.Add(this.labelControl2);
            this.groupIslemler.Controls.Add(this.txtBarkod);
            this.groupIslemler.Controls.Add(this.labelControl1);
            this.groupIslemler.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupIslemler.Location = new System.Drawing.Point(0, 0);
            this.groupIslemler.Name = "groupIslemler";
            this.groupIslemler.Size = new System.Drawing.Size(350, 600);
            this.groupIslemler.Text = "Ürün Bilgileri";

            // --- GİRİŞ KUTULARI ---
            int y = 40; int gap = 50;

            // Barkod
            this.labelControl1.Location = new System.Drawing.Point(20, y);
            this.labelControl1.Text = "Barkod:";
            this.txtBarkod.Location = new System.Drawing.Point(120, y - 3);
            this.txtBarkod.Size = new System.Drawing.Size(200, 22);

            // Ürün Adı
            y += gap;
            this.labelControl2.Location = new System.Drawing.Point(20, y);
            this.labelControl2.Text = "Ürün Adı:";
            this.txtUrunAdi.Location = new System.Drawing.Point(120, y - 3);
            this.txtUrunAdi.Size = new System.Drawing.Size(200, 22);

            // Kategori
            y += gap;
            this.labelControl3.Location = new System.Drawing.Point(20, y);
            this.labelControl3.Text = "Kategori:";
            this.txtKategori.Location = new System.Drawing.Point(120, y - 3);
            this.txtKategori.Size = new System.Drawing.Size(200, 22);

            // Alış Fiyat
            y += gap;
            this.labelControl4.Location = new System.Drawing.Point(20, y);
            this.labelControl4.Text = "Alış Fiyatı:";
            this.txtAlisFiyat.Location = new System.Drawing.Point(120, y - 3);
            this.txtAlisFiyat.Size = new System.Drawing.Size(200, 22);

            // Satış Fiyat
            y += gap;
            this.labelControl5.Location = new System.Drawing.Point(20, y);
            this.labelControl5.Text = "Satış Fiyatı:";
            this.txtSatisFiyat.Location = new System.Drawing.Point(120, y - 3);
            this.txtSatisFiyat.Size = new System.Drawing.Size(200, 22);

            // Stok
            y += gap;
            this.labelControl6.Location = new System.Drawing.Point(20, y);
            this.labelControl6.Text = "Stok Miktarı:";
            this.txtStok.Location = new System.Drawing.Point(120, y - 3);
            this.txtStok.Size = new System.Drawing.Size(200, 22);

            // --- BUTONLAR ---
            y += gap + 20;
            this.btnKaydet.Location = new System.Drawing.Point(120, y);
            this.btnKaydet.Size = new System.Drawing.Size(200, 40);
            this.btnKaydet.Text = "KAYDET / GÜNCELLE";

            y += 50;
            this.btnSil.Location = new System.Drawing.Point(120, y);
            this.btnSil.Size = new System.Drawing.Size(200, 40);
            this.btnSil.Text = "SİL";

            y += 50;
            this.btnTemizle.Location = new System.Drawing.Point(120, y);
            this.btnTemizle.Size = new System.Drawing.Size(200, 40);
            this.btnTemizle.Text = "TEMİZLE";

            // --- SAĞ TARAF (GRID) ---
            this.gridUrunler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridUrunler.Location = new System.Drawing.Point(350, 0);
            this.gridUrunler.MainView = this.gridViewUrunler;
            this.gridUrunler.Name = "gridUrunler";
            this.gridUrunler.Size = new System.Drawing.Size(650, 600);

            this.gridViewUrunler.GridControl = this.gridUrunler;
            this.gridViewUrunler.Name = "gridViewUrunler";
            this.gridViewUrunler.OptionsBehavior.Editable = false; // Grid üzerinde elle değişiklik yapılmasın
            this.gridViewUrunler.OptionsView.ShowGroupPanel = false;

            // --- FORM AYARLARI ---
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.gridUrunler);
            this.Controls.Add(this.groupIslemler);
            this.Name = "FrmUrunler";
            this.Text = "Ürün ve Stok Yönetimi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;

            ((System.ComponentModel.ISupportInitialize)(this.groupIslemler)).EndInit();
            this.groupIslemler.ResumeLayout(false);
            this.groupIslemler.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtStok.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSatisFiyat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAlisFiyat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKategori.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUrunAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBarkod.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridUrunler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewUrunler)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupIslemler;
        private DevExpress.XtraEditors.TextEdit txtBarkod;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtStok;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txtSatisFiyat;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtAlisFiyat;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtKategori;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtUrunAdi;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton btnTemizle;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
        private DevExpress.XtraGrid.GridControl gridUrunler;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewUrunler;
    }
}