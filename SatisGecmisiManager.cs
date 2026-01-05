using System;
using System.Data;
using MySql.Data.MySqlClient;
using MarketOtomasyon.DAL;

namespace MarketOtomasyon.BL
{
    public class SatisGecmisiManager
    {
        // Satışları getirirken 'Durum' sütununu da çekiyoruz
        // Satışları getirirken 'Durum' sütununu da çekiyoruz
        public static DataTable SatislariGetir()
        {
            using (var baglanti = Veritabani.BaglantiGetir())
            {
                string sorgu = "SELECT SatisID, IslemTarihi, ToplamTutar, OdemeTipi, Durum FROM TBL_SATISLAR ORDER BY IslemTarihi DESC";
                using (var da = new MySqlDataAdapter(sorgu, baglanti))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
        }

        public static bool SatisIptalEt(int satisID)
        {
            using (var baglanti = Veritabani.BaglantiGetir())
            {
                // 1. Satışın durumunu güncelle
                string sorguDurum = "UPDATE TBL_SATISLAR SET Durum = 'İptal Edildi' WHERE SatisID = @p1";
                MySqlParameter[] p1 = { new MySqlParameter("@p1", satisID) };
                bool durumGuncellendi = Veritabani.KomutCalistir(sorguDurum, p1);

                if (durumGuncellendi)
                {
                    // 2. Stokları geri yükle (Satış detayındaki ürünleri bul ve miktarları artır)
                    DataTable dtDetay = SatisDetaylariniGetir(satisID);
                    foreach (DataRow row in dtDetay.Rows)
                    {
                        int urunID = Convert.ToInt32(row["UrunID"]);
                        int adet = Convert.ToInt32(row["Adet"]);

                        // UrunManager'daki StokDus metodunun tersini yapıyoruz (Stok artırımı)
                        string stokSorgu = "UPDATE TBL_URUNLER SET StokMiktari = StokMiktari + @adet WHERE UrunID = @id";
                        MySqlParameter[] pStok = {
                            new MySqlParameter("@adet", adet),
                            new MySqlParameter("@id", urunID)
                        };
                        Veritabani.KomutCalistir(stokSorgu, pStok);
                    }
                    return true;
                }
                return false;
            }
        }

        public static DataTable SatisDetaylariniGetir(int satisID)
        {
            using (var baglanti = Veritabani.BaglantiGetir())
            {
                string sorgu = @"SELECT sd.UrunID, u.UrunAdi, sd.Adet, sd.BirimFiyat, (sd.Adet * sd.BirimFiyat) as Toplam 
                                 FROM TBL_SATIS_DETAY sd 
                                 INNER JOIN TBL_URUNLER u ON sd.UrunID = u.UrunID 
                                 WHERE sd.SatisID = @p1";
                using (var komut = new MySqlCommand(sorgu, baglanti))
                {
                    komut.Parameters.AddWithValue("@p1", satisID);
                    MySqlDataAdapter da = new MySqlDataAdapter(komut);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
        }
    }
}