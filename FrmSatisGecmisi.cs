using System;
using System.Data;
using DevExpress.XtraEditors;
using MarketOtomasyon.BL;

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
    }
}