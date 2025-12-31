using DevExpress.XtraBars;
using MarketOtomasyon.BL;
using System;
using System.Windows.Forms;

namespace MarketOtomasyon
{
    public partial class FrmAnaMenu : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        // Boş Constructor (Tasarımcı Hata Vermesin Diye)
        public FrmAnaMenu()
        {
            InitializeComponent();
        }

        // Ana Constructor (Giriş Ekranından Gelen Veriyi Almak İçin)
        public FrmAnaMenu(string adSoyad, string rol) : this()
        {
            // Giriş yapanı alta yazalım
            lblKullaniciBilgi.Caption = $"Aktif Kullanıcı: {adSoyad} ({rol})";

            // --- YETKİLENDİRME ---
            if (rol == "KASIYER")
            {
                // Kasiyer ise Yönetici Paneli sayfasını tamamen gizle
                pageYonetim.Visible = false;
            }
            else
            {
                // Müdür ise her şey açık
                pageYonetim.Visible = true;
            }

            // Olayları (Events) Elle Bağlayalım (Designer hata vermesin diye burada yapıyoruz)
            this.btnSatisEkrani.ItemClick += new ItemClickEventHandler(this.btnSatisEkrani_ItemClick);
            this.btnCikis.ItemClick += new ItemClickEventHandler(this.btnCikis_ItemClick);
        }

        // 1. Satış Ekranını Açan Metot
        private void btnSatisEkrani_ItemClick(object sender, ItemClickEventArgs e)
        {
            // Satış formunu oluştur
            FrmSatis frm = new FrmSatis();

            // Ana formun içinde açılsın (MDI Child)
            frm.MdiParent = this;

            // Aç
            frm.Show();
        }

        // 2. Çıkış Yapan Metot
        private void btnCikis_ItemClick(object sender, ItemClickEventArgs e)
        {
            Application.Exit();
        }

        private void btnStokYonetimi_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmUrunler frm = new FrmUrunler();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnRaporlar_ItemClick(object sender, ItemClickEventArgs e)
        {

            // Formun daha önce açılıp açılmadığını kontrol etmek iyi bir pratiktir
            FrmZRaporu frm = new FrmZRaporu();
            frm.MdiParent = this; // Eğer MDI kullanıyorsan
                                  // Varsa bir Panel içine gömmek istiyorsan:
                                  // frm.TopLevel = false;
                                  // pnlAnaIcerik.Controls.Add(frm);
                                  // frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void btnKullanicilar_ItemClick(object sender, ItemClickEventArgs e)
        {
            // Formun daha önce açılıp açılmadığını kontrol etmek iyi bir pratiktir
            FrmPersonelYonetim frm = new FrmPersonelYonetim();
            frm.MdiParent = this; // Eğer MDI kullanıyorsan
                                  // Varsa bir Panel içine gömmek istiyorsan:
                                  // frm.TopLevel = false;
                                  // pnlAnaIcerik.Controls.Add(frm);
                                  // frm.Dock = DockStyle.Fill;
            frm.Show();
        }
    }
}