using System;

namespace MarketOtomasyon.Entities
{
    // Veritabanındaki TBL_URUNLER tablosunun aynısı
    public class Urun
    {
        public int UrunID { get; set; }
        public string Barkod { get; set; }
        public string UrunAdi { get; set; }
        public string Kategori { get; set; }
        public decimal AlisFiyati { get; set; }
        public decimal SatisFiyati { get; set; }
        public int StokMiktari { get; set; }
        public int KritikStokSeviyesi { get; set; }
    }
}