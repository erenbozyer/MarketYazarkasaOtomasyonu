using System;
using System.Data;
using MySql.Data.MySqlClient;
using MarketOtomasyon.DAL;

namespace MarketOtomasyon.BL
{
    public class DurumManager
    {
        // 1. Kritik Stok Kontrolü (< 20 adet)
        public static DataTable KritikStoklariGetir()
        {
            string sorgu = "SELECT UrunAdi, StokMiktari,KritikStokSeviyesi FROM TBL_URUNLER WHERE StokMiktari < KritikStokSeviyesi ORDER BY StokMiktari ASC";
            using (var baglanti = Veritabani.BaglantiGetir())
            {
                MySqlDataAdapter da = new MySqlDataAdapter(sorgu, baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        // 2. Günlük Ciro Dağılımı (Nakit vs Kart)
        public static DataTable GunlukSatisOzet()
        {
            string sorgu = "SELECT OdemeTipi, SUM(ToplamTutar) as Tutar FROM TBL_SATISLAR " +
                           "WHERE DATE(IslemTarihi) = CURDATE() GROUP BY OdemeTipi";
            using (var baglanti = Veritabani.BaglantiGetir())
            {
                MySqlDataAdapter da = new MySqlDataAdapter(sorgu, baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        // 3. Haftalık Popüler Ürünler (Top 5)
        public static DataTable HaftalikPopulerUrunler()
        {
            string sorgu = @"SELECT u.UrunAdi, SUM(sd.Adet) as ToplamAdet 
                             FROM TBL_SATIS_DETAY sd 
                             JOIN TBL_URUNLER u ON sd.UrunID = u.UrunID 
                             JOIN TBL_SATISLAR s ON sd.SatisID = s.SatisID 
                             WHERE s.IslemTarihi >= DATE_SUB(CURDATE(), INTERVAL 7 DAY) 
                             GROUP BY u.UrunAdi 
                             ORDER BY ToplamAdet DESC LIMIT 5";
            using (var baglanti = Veritabani.BaglantiGetir())
            {
                MySqlDataAdapter da = new MySqlDataAdapter(sorgu, baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
    }
}