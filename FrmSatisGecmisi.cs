using DevExpress.XtraEditors;
using MarketOtomasyon.BL;
using System;
using System.Data;
using System.Windows.Forms;
using System.Drawing; // Color sınıfı için gerekli

namespace MarketOtomasyon
{
    public partial class FrmSatisGecmisi : XtraForm
    {
        public FrmSatisGecmisi()
        {
            InitializeComponent();
            SatislariYukle();
        }

        private void SatislariYukle()
        {
            // Üstteki grid'e ana satış listesini yükle
            gridControlSatislar.DataSource = SatisGecmisiManager.SatislariGetir();
        }
        private void btnIadeEt_Click(object sender, EventArgs e)
        {
            DataRow dr = gridViewSatislar.GetDataRow(gridViewSatislar.FocusedRowHandle);
            if (dr != null)
            {
                if (dr["Durum"].ToString() == "İptal Edildi")
                {
                    XtraMessageBox.Show("Bu satış zaten iptal edilmiş.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int satisID = Convert.ToInt32(dr["SatisID"]);
                DialogResult onay = XtraMessageBox.Show($"{satisID} nolu satışı iptal etmek ve ürünleri stoğa iade etmek istediğinize emin misiniz?", "Satış İptali", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (onay == DialogResult.Yes)
                {
                    if (SatisGecmisiManager.SatisIptalEt(satisID))
                    {
                        XtraMessageBox.Show("Satış iptal edildi ve stoklar güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        SatislariYukle(); // Listeyi yenile
                    }
                }
            }
        }

        // İptal edilen satırları kırmızı yapma
        private void gridViewSatislar_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            if (e.RowHandle >= 0)
            {
                string durum = gridViewSatislar.GetRowCellValue(e.RowHandle, "Durum").ToString();
                if (durum == "İptal Edildi")
                {
                    e.Appearance.BackColor = Color.Salmon; // Kırmızımsı arka plan
                    e.Appearance.BackColor2 = Color.SeaShell;
                    e.HighPriority = true; // Diğer stil ayarlarının üzerine yaz
                }
            }
        }
        // Üst tablodaki satır değiştiğinde tetiklenir
        private void gridViewSatislar_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridViewSatislar.GetDataRow(gridViewSatislar.FocusedRowHandle);
            if (dr != null)
            {
                int satisID = Convert.ToInt32(dr["SatisID"]);
                // Alttaki grid'e o satışın ürün detaylarını yükle
                gridControlDetaylar.DataSource = SatisGecmisiManager.SatisDetaylariniGetir(satisID);
            }
        }

        private void gridControlDetaylar_Click(object sender, EventArgs e)
        {

        }
    }
}