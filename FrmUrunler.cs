using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using MarketOtomasyon.BL; // BL Katmanı

namespace MarketOtomasyon
{
    public partial class FrmUrunler : DevExpress.XtraEditors.XtraForm
    {
        // Seçili ürünün ID'sini tutmak için (Güncelleme ve Silme için)
        int seciliUrunID = 0;

        public FrmUrunler()
        {
            InitializeComponent();
            Listele(); // Form açılınca listeyi getir

            // Grid Tıklama Olayını Bağla (Satıra basınca veriler kutulara dolsun)
            gridViewUrunler.FocusedRowChanged += GridViewUrunler_FocusedRowChanged;

            // Buton Olaylarını Bağla
            btnKaydet.Click += BtnKaydet_Click;
            btnSil.Click += BtnSil_Click;
            btnTemizle.Click += BtnTemizle_Click;
        }

        void Listele()
        {
            gridUrunler.DataSource = UrunManager.UrunleriGetir();
        }

        void Temizle()
        {
            txtBarkod.Text = "";
            txtUrunAdi.Text = "";
            txtKategori.Text = "";
            txtAlisFiyat.Text = "";
            txtSatisFiyat.Text = "";
            txtStok.Text = "";
            seciliUrunID = 0;
            txtBarkod.Focus();
        }

        // --- BUTON İŞLEMLERİ ---

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                // Basit Doğrulama
                if (txtBarkod.Text == "" || txtUrunAdi.Text == "" || txtSatisFiyat.Text == "")
                {
                    XtraMessageBox.Show("Lütfen önemli alanları doldurunuz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Sayısal Dönüşümler
                decimal alis = decimal.Parse(txtAlisFiyat.Text);
                decimal satis = decimal.Parse(txtSatisFiyat.Text);
                int stok = int.Parse(txtStok.Text);

                if (seciliUrunID == 0)
                {
                    // YENİ KAYIT
                    bool sonuc = UrunManager.UrunEkle(txtBarkod.Text, txtUrunAdi.Text, txtKategori.Text, alis, satis, stok);
                    if (sonuc) XtraMessageBox.Show("Ürün Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // GÜNCELLEME
                    bool sonuc = UrunManager.UrunGuncelle(seciliUrunID, txtBarkod.Text, txtUrunAdi.Text, txtKategori.Text, alis, satis, stok);
                    if (sonuc) XtraMessageBox.Show("Ürün Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                Listele();
                Temizle();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Hata (Fiyatlara nokta yerine virgül kullanın): " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            if (seciliUrunID != 0)
            {
                if (XtraMessageBox.Show("Bu ürünü silmek istediğinize emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    UrunManager.UrunSil(seciliUrunID);
                    Listele();
                    Temizle();
                }
            }
            else
            {
                XtraMessageBox.Show("Lütfen silinecek bir ürün seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        // --- GRID SATIR SEÇİMİ ---
        private void GridViewUrunler_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            // Seçili satırdaki verileri alıp kutulara dolduruyoruz
            var row = gridViewUrunler.GetDataRow(e.FocusedRowHandle);
            if (row != null)
            {
                seciliUrunID = Convert.ToInt32(row["UrunID"]);
                txtBarkod.Text = row["Barkod"].ToString();
                txtUrunAdi.Text = row["UrunAdi"].ToString();
                txtKategori.Text = row["Kategori"].ToString();
                txtAlisFiyat.Text = row["AlisFiyati"].ToString();
                txtSatisFiyat.Text = row["SatisFiyati"].ToString();
                txtStok.Text = row["StokMiktari"].ToString();
            }
        }
    }
}