using System;
using System.Windows.Forms;
using MarketOtomasyon.BL;

namespace MarketOtomasyon
{
    public partial class FrmDurumKontrol : DevExpress.XtraEditors.XtraForm
    {
        public FrmDurumKontrol()
        {
            InitializeComponent();
            VerileriYukle();
        }

        void VerileriYukle()
        {
            // Kritik Stok Listesi
            gridStok.DataSource = DurumManager.KritikStoklariGetir();

            // Günlük Ciro Özeti (Grafik 1)
            chartGunluk.DataSource = DurumManager.GunlukSatisOzet();
            chartGunluk.Series[0].ArgumentDataMember = "OdemeTipi";
            chartGunluk.Series[0].ValueDataMembers.AddRange(new string[] { "Tutar" });

            // Haftalık Popülerlik (Grafik 2)
            chartHaftalik.DataSource = DurumManager.HaftalikPopulerUrunler();
            chartHaftalik.Series[0].ArgumentDataMember = "UrunAdi";
            chartHaftalik.Series[0].ValueDataMembers.AddRange(new string[] { "ToplamAdet" });
        }
    }
}