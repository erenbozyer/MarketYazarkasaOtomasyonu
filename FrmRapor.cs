using System;
using System.IO;
using System.Windows.Forms;
using MarketOtomasyon.BL;

namespace MarketOtomasyon
{
    public partial class FrmZRaporu : DevExpress.XtraEditors.XtraForm
    {
        public FrmZRaporu()
        {
            InitializeComponent();
            deTarih.DateTime = DateTime.Now; // Varsayılan olarak bugünü seç
        }

        private void btnRaporla_Click(object sender, EventArgs e)
        {
            if (deTarih.EditValue == null) return;

            DateTime secilenTarih = deTarih.DateTime;

            // 1. Raporu oluştur (BL Katmanındaki metodumuz)
            RaporManager.ZRaporuOlustur(secilenTarih);

            // 2. Oluşturulan dosyayı oku ve MemoEdit'e bas
            string dosyaAdi = $"Z_Raporu_{secilenTarih:yyyyMMdd}.txt";
            string tamYol = Path.Combine(Application.StartupPath, "Raporlar", dosyaAdi);

            if (File.Exists(tamYol))
            {
                txtOnizleme.Text = File.ReadAllText(tamYol);
            }
            else
            {
                txtOnizleme.Text = "Seçilen tarihe ait satış verisi bulunamadı veya rapor oluşturulamadı.";
            }
        }
    }
}