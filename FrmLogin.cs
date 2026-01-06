using DevExpress.XtraEditors;
using MarketOtomasyon.BL; // BL Katmanı
using System;
using System.Data;
using System.Windows.Forms;

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
                DataRow kullanici = KullaniciManager.GirisYap(txtKullaniciAdi.Text, txtSifre.Text);

                if (kullanici != null)
                {
                    GlobalVariables.KasiyerID = Convert.ToInt32(kullanici["KullaniciID"]);
                    GlobalVariables.KullaniciAdi = kullanici["KullaniciAdi"].ToString();
                    GlobalVariables.Rol = kullanici["Rol"].ToString();
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