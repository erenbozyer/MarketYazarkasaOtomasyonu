using System;

namespace MarketOtomasyon.Entities
{
    // Veritabanındaki TBL_SATISLAR tablosunun aynısı
    public class Satis
    {
        public int SatisID { get; set; }
        public DateTime IslemTarihi { get; set; }
        public decimal ToplamTutar { get; set; }
        public string OdemeTipi { get; set; } // Nakit, Kredi Kartı
        public int KasiyerID { get; set; }
    }
}