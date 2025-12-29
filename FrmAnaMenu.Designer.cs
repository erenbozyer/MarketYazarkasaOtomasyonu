namespace MarketOtomasyon
{
    partial class FrmAnaMenu
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
            ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            btnSatisEkrani = new DevExpress.XtraBars.BarButtonItem();
            btnStokYonetimi = new DevExpress.XtraBars.BarButtonItem();
            btnRaporlar = new DevExpress.XtraBars.BarButtonItem();
            btnKullanicilar = new DevExpress.XtraBars.BarButtonItem();
            btnCikis = new DevExpress.XtraBars.BarButtonItem();
            lblKullaniciBilgi = new DevExpress.XtraBars.BarStaticItem();
            pageSatis = new DevExpress.XtraBars.Ribbon.RibbonPage();
            groupSatis = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            pageYonetim = new DevExpress.XtraBars.Ribbon.RibbonPage();
            groupStok = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            groupRapor = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            groupAyarlar = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            ((System.ComponentModel.ISupportInitialize)ribbon).BeginInit();
            SuspendLayout();
            // 
            // ribbon
            // 
            ribbon.ExpandCollapseItem.Id = 0;
            ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] { ribbon.ExpandCollapseItem, btnSatisEkrani, btnStokYonetimi, btnRaporlar, btnKullanicilar, btnCikis, lblKullaniciBilgi });
            ribbon.Location = new System.Drawing.Point(0, 0);
            ribbon.MaxItemId = 7;
            ribbon.Name = "ribbon";
            ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] { pageSatis, pageYonetim });
            ribbon.Size = new System.Drawing.Size(1024, 193);
            ribbon.StatusBar = ribbonStatusBar;
            // 
            // btnSatisEkrani
            // 
            btnSatisEkrani.Caption = "Hızlı Satış Ekranı";
            btnSatisEkrani.Id = 1;
            btnSatisEkrani.Name = "btnSatisEkrani";
            btnSatisEkrani.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // btnStokYonetimi
            // 
            btnStokYonetimi.Caption = "Stok Listesi";
            btnStokYonetimi.Id = 2;
            btnStokYonetimi.Name = "btnStokYonetimi";
            btnStokYonetimi.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            btnStokYonetimi.ItemClick += btnStokYonetimi_ItemClick;
            // 
            // btnRaporlar
            // 
            btnRaporlar.Caption = "Gün Sonu Raporu";
            btnRaporlar.Id = 3;
            btnRaporlar.Name = "btnRaporlar";
            // 
            // btnKullanicilar
            // 
            btnKullanicilar.Caption = "Personel Yönetimi";
            btnKullanicilar.Id = 4;
            btnKullanicilar.Name = "btnKullanicilar";
            // 
            // btnCikis
            // 
            btnCikis.Caption = "Oturumu Kapat";
            btnCikis.Id = 5;
            btnCikis.Name = "btnCikis";
            btnCikis.ItemClick += btnCikis_ItemClick;
            // 
            // lblKullaniciBilgi
            // 
            lblKullaniciBilgi.Caption = "Giriş Yapan: ...";
            lblKullaniciBilgi.Id = 6;
            lblKullaniciBilgi.Name = "lblKullaniciBilgi";
            // 
            // pageSatis
            // 
            pageSatis.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] { groupSatis });
            pageSatis.Name = "pageSatis";
            pageSatis.Text = "KASİYER İŞLEMLERİ";
            // 
            // groupSatis
            // 
            groupSatis.ItemLinks.Add(btnSatisEkrani);
            groupSatis.ItemLinks.Add(btnCikis);
            groupSatis.Name = "groupSatis";
            groupSatis.Text = "Satış";
            // 
            // pageYonetim
            // 
            pageYonetim.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] { groupStok, groupRapor, groupAyarlar });
            pageYonetim.Name = "pageYonetim";
            pageYonetim.Text = "YÖNETİCİ PANELİ";
            // 
            // groupStok
            // 
            groupStok.ItemLinks.Add(btnStokYonetimi);
            groupStok.Name = "groupStok";
            groupStok.Text = "Ürünler";
            // 
            // groupRapor
            // 
            groupRapor.ItemLinks.Add(btnRaporlar);
            groupRapor.Name = "groupRapor";
            groupRapor.Text = "Analiz";
            // 
            // groupAyarlar
            // 
            groupAyarlar.ItemLinks.Add(btnKullanicilar);
            groupAyarlar.Name = "groupAyarlar";
            groupAyarlar.Text = "Ayarlar";
            // 
            // ribbonStatusBar
            // 
            ribbonStatusBar.ItemLinks.Add(lblKullaniciBilgi);
            ribbonStatusBar.Location = new System.Drawing.Point(0, 557);
            ribbonStatusBar.Name = "ribbonStatusBar";
            ribbonStatusBar.Ribbon = ribbon;
            ribbonStatusBar.Size = new System.Drawing.Size(1024, 30);
            // 
            // FrmAnaMenu
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1024, 587);
            Controls.Add(ribbonStatusBar);
            Controls.Add(ribbon);
            IsMdiContainer = true;
            Name = "FrmAnaMenu";
            Ribbon = ribbon;
            StatusBar = ribbonStatusBar;
            Text = "Market Otomasyon Sistemi v1.0";
            WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)ribbon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage pageSatis;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup groupSatis;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem btnSatisEkrani;
        private DevExpress.XtraBars.BarButtonItem btnStokYonetimi;
        private DevExpress.XtraBars.BarButtonItem btnRaporlar;
        private DevExpress.XtraBars.BarButtonItem btnKullanicilar;
        private DevExpress.XtraBars.BarButtonItem btnCikis;
        private DevExpress.XtraBars.BarStaticItem lblKullaniciBilgi;
        private DevExpress.XtraBars.Ribbon.RibbonPage pageYonetim;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup groupStok;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup groupRapor;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup groupAyarlar;
    }
}