using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using MarketOtomasyon.BL; // BL Katmanını unutma

namespace MarketOtomasyon
{
    public partial class FrmSatis : DevExpress.XtraEditors.XtraForm
    {
        DataTable dtSepet = new DataTable();

        public FrmSatis()
        {
            InitializeComponent();

            SepetTablosunuHazirla();

            // SAHTE VERİLERİ SİLDİK -> YERİNE GERÇEKLERİ GELDİ
            VeritabanindanUrunleriYukle();

            // Barkod Kutusuna Enter özelliği ekle
            txtBarkod.KeyDown += TxtBarkod_KeyDown;
        }

        // 1. SEPET TABLOSU (ID'yi de tutuyoruz artık)
        void SepetTablosunuHazirla()
        {
            if (dtSepet.Columns.Count == 0)
            {
                dtSepet.Columns.Add("UrunID", typeof(int)); // Veritabanı ID'si lazım
                dtSepet.Columns.Add("UrunAdi");
                dtSepet.Columns.Add("Adet", typeof(int));
                dtSepet.Columns.Add("Fiyat", typeof(decimal));
                dtSepet.Columns.Add("Toplam", typeof(decimal));
            }
            gridSepet.DataSource = dtSepet;

            // HATALI SATIRI SİLDİK: gridViewSepet.Columns["UrunID"].Visible = false;
            // Çünkü tasarımcıda UrunID sütunu eklemediğimiz için zaten görünmeyecek.
        }

        // 2. GERÇEK ÜRÜNLERİ BUTON YAPMA
        void VeritabanindanUrunleriYukle()
        {
            flowUrunler.Controls.Clear(); // Önce temizle

            // Tüm ürünleri çek
            DataTable dt = UrunManager.UrunleriGetir();

            foreach (DataRow row in dt.Rows)
            {
                string ad = row["UrunAdi"].ToString();
                decimal fiyat = Convert.ToDecimal(row["SatisFiyati"]);
                string barkod = row["Barkod"].ToString();
                int id = Convert.ToInt32(row["UrunID"]);

                // Her satır için buton oluştur
                SimpleButton btn = new SimpleButton();
                btn.Text = $"{ad}\n{fiyat:C2}"; // Alt alta yaz (C2: Para birimi formatı)
                btn.Size = new Size(150, 120);
                btn.Appearance.Font = new Font("Segoe UI", 11, FontStyle.Bold);
                btn.ToolTip = $"Barkod: {barkod}\nStok: {row["StokMiktari"]}"; // Mouse ile üzerine gelince bilgi ver

                // Tıklayınca sepete ekle
                btn.Click += (s, e) => SepeteEkle(id, ad, fiyat, 1);

                flowUrunler.Controls.Add(btn);
            }
        }

        // 3. BARKOD OKUTMA MANTIĞI (ENTER TUŞU)
        private void TxtBarkod_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string barkod = txtBarkod.Text.Trim();
                if (!string.IsNullOrEmpty(barkod))
                {
                    // BL Katmanına sor: Bu barkodlu ürün var mı?
                    DataRow urun = UrunManager.UrunGetir(barkod);

                    if (urun != null)
                    {
                        // Varsa Sepete Ekle
                        SepeteEkle(
                            Convert.ToInt32(urun["UrunID"]),
                            urun["UrunAdi"].ToString(),
                            Convert.ToDecimal(urun["SatisFiyati"]),
                            1
                        );
                        txtBarkod.Text = ""; // Kutuyu temizle
                    }
                    else
                    {
                        // Sesli uyarı verip kullanıcıyı uyar
                        System.Media.SystemSounds.Hand.Play();
                        XtraMessageBox.Show("Ürün Bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtBarkod.SelectAll();
                    }
                }
            }
        }

        // 4. SEPETE EKLEME VE GÜNCELLEME
        void SepeteEkle(int id, string ad, decimal fiyat, int adet)
        {
            // Sepette bu ürün var mı kontrol et
            foreach (DataRow row in dtSepet.Rows)
            {
                if (Convert.ToInt32(row["UrunID"]) == id)
                {
                    // Varsa adedini artır
                    row["Adet"] = Convert.ToInt32(row["Adet"]) + adet;
                    row["Toplam"] = Convert.ToDecimal(row["Adet"]) * fiyat;
                    ToplamHesapla();
                    return;
                }
            }

            // Yoksa yeni satır ekle
            dtSepet.Rows.Add(id, ad, adet, fiyat, fiyat * adet);
            ToplamHesapla();
        }

        void ToplamHesapla()
        {
            decimal toplam = 0;
            foreach (DataRow row in dtSepet.Rows)
            {
                toplam += Convert.ToDecimal(row["Toplam"]);
            }
            lblToplamTutar.Text = $"{toplam:N2} ₺";
        }

        // 5. SATIŞI TAMAMLAMA (Şimdilik sadece ekranı temizler, sonra veritabanına kaydedeceğiz)
        private void btnNakit_Click(object sender, EventArgs e)
        {
            if (dtSepet.Rows.Count > 0)
            {
                XtraMessageBox.Show("Satış Başarıyla Tamamlandı (Nakit)", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                EkranTemizle();
            }
            else
                XtraMessageBox.Show("Sepet Boş!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnKrediKarti_Click(object sender, EventArgs e)
        {
            if (dtSepet.Rows.Count > 0)
            {
                XtraMessageBox.Show("Satış Başarıyla Tamamlandı (Kredi Kartı)", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                EkranTemizle();
            }
            else
                XtraMessageBox.Show("Sepet Boş!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        void EkranTemizle()
        {
            dtSepet.Rows.Clear();
            lblToplamTutar.Text = "0,00 ₺";
            txtBarkod.Focus();
        }
    }
}