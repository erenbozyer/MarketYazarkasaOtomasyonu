using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using MarketOtomasyon.BL; // BL Katmanı

namespace MarketOtomasyon
{
    public partial class FrmLogin : DevExpress.XtraEditors.XtraForm
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        // Giriş Butonu Tıklanınca
        private void btnGiris_Click(object sender, EventArgs e)
        {
            // Basit doğrulama
            if (string.IsNullOrEmpty(txtKullaniciAdi.Text) || string.IsNullOrEmpty(txtSifre.Text))
            {
                XtraMessageBox.Show("Kullanıcı adı ve şifre boş olamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // BL katmanındaki KullaniciManager'ı çağır
                var kullanici = KullaniciManager.GirisYap(txtKullaniciAdi.Text, txtSifre.Text);

                if (kullanici != null)
                {
                    
                    // Buradan sonra Ana Menüyü açacağız
                    // Veritabanından bilgileri al
                    string adSoyad = kullanici["AdSoyad"].ToString();
                    string rol = kullanici["Rol"].ToString();

                    // Ana Menüyü oluştur ve bilgileri gönder
                    FrmAnaMenu anaMenu = new FrmAnaMenu(adSoyad, rol);

                    // Login formunu gizle
                    this.Hide();

                    // Ana menüyü aç
                    anaMenu.Show();
                }
                else
                {
                    XtraMessageBox.Show("Hatalı bilgiler!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Hata: " + ex.Message);
            }
        }

        // Kapat (X) Butonu Tıklanınca
        private void btnKapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}