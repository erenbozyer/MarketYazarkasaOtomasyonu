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
            barButtonGroup1 = new DevExpress.XtraBars.BarButtonGroup();
            btnSatisGecmisi = new DevExpress.XtraBars.BarButtonItem();
            barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            pageSatis = new DevExpress.XtraBars.Ribbon.RibbonPage();
            groupSatis = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            pageYonetim = new DevExpress.XtraBars.Ribbon.RibbonPage();
            groupStok = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            groupRapor = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            groupAyarlar = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            groupDurum = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            btnDurumKontrol = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)ribbon).BeginInit();
            SuspendLayout();
            // 
            // ribbon
            // 
            ribbon.ExpandCollapseItem.Id = 0;
            ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] { ribbon.ExpandCollapseItem, btnSatisEkrani, btnStokYonetimi, btnRaporlar, btnKullanicilar, btnCikis, lblKullaniciBilgi, barButtonGroup1, btnSatisGecmisi, barButtonItem1, btnDurumKontrol });
            ribbon.Location = new System.Drawing.Point(0, 0);
            ribbon.MaxItemId = 20;
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
            btnSatisEkrani.ItemClick += btnSatisEkrani_ItemClick;
            // 
            // btnStokYonetimi
            // 
            btnStokYonetimi.Caption = "Stok Listesi";
            btnStokYonetimi.Id = 2;
            btnStokYonetimi.Name = "btnStokYonetimi";
            btnStokYonetimi.ItemClick += btnStokYonetimi_ItemClick;
            // 
            // btnRaporlar
            // 
            btnRaporlar.Caption = "Gün Sonu Raporu";
            btnRaporlar.Id = 3;
            btnRaporlar.Name = "btnRaporlar";
            btnRaporlar.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            btnRaporlar.ItemClick += btnRaporlar_ItemClick;
            // 
            // btnKullanicilar
            // 
            btnKullanicilar.Caption = "Personel Yönetimi";
            btnKullanicilar.Id = 4;
            btnKullanicilar.Name = "btnKullanicilar";
            btnKullanicilar.ItemClick += btnKullanicilar_ItemClick;
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
            // barButtonGroup1
            // 
            barButtonGroup1.Caption = "barButtonGroup1";
            barButtonGroup1.Id = 11;
            barButtonGroup1.ItemLinks.Add(btnSatisEkrani);
            barButtonGroup1.Name = "barButtonGroup1";
            // 
            // btnSatisGecmisi
            // 
            btnSatisGecmisi.Caption = "Satış Geçmişi";
            btnSatisGecmisi.Id = 13;
            btnSatisGecmisi.Name = "btnSatisGecmisi";
            btnSatisGecmisi.ItemClick += btnSatisGecmisi_ItemClick;
            // 
            // barButtonItem1
            // 
            barButtonItem1.Caption = "barButtonItem1";
            barButtonItem1.Id = 17;
            barButtonItem1.Name = "barButtonItem1";
            barButtonItem1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // pageSatis
            // 
            pageSatis.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] { groupSatis });
            pageSatis.Name = "pageSatis";
            pageSatis.Text = "KASİYER İŞLEMLERİ";
            // 
            // groupSatis
            // 
            groupSatis.ItemLinks.Add(barButtonGroup1, true);
            groupSatis.ItemLinks.Add(btnSatisGecmisi, true);
            groupSatis.ItemLinks.Add(btnCikis, true);
            groupSatis.Name = "groupSatis";
            groupSatis.Text = "Satış";
            // 
            // pageYonetim
            // 
            pageYonetim.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] { groupStok, groupRapor, groupAyarlar, groupDurum });
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
            // groupDurum
            // 
            groupDurum.ItemLinks.Add(btnDurumKontrol);
            groupDurum.Name = "groupDurum";
            groupDurum.Text = "Durum";
            // 
            // btnDurumKontrol
            // 
            btnDurumKontrol.Caption = "Mağza Durumunu İncele\r\n";
            btnDurumKontrol.Id = 19;
            btnDurumKontrol.Name = "btnDurumKontrol";
            btnDurumKontrol.ItemClick += btnDurumKontrol_ItemClick;
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
        private DevExpress.XtraBars.BarButtonGroup barButtonGroup1;
        private DevExpress.XtraBars.BarButtonItem btnSatisGecmisi;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem btnDurumKontrol;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup groupDurum;
    }
}