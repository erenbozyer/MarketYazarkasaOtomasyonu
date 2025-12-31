using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MarketOtomasyon.DAL;
using MarketOtomasyon.Entities;

namespace MarketOtomasyon.BL
{
    public class SatisManager
    {
       
        public static bool SatisYap(DataTable sepet, decimal toplamTutar, string odemeTipi, int kasiyerID)
        {
            try
            {
                // 1. Ana Satış Kaydını Oluştur (TBL_SATISLAR)
                int satisID = SatisLogla(toplamTutar, odemeTipi, kasiyerID);

                if (satisID > 0)
                {
                    // 2. Sepetteki her ürün için işlem yap
                    foreach (DataRow row in sepet.Rows)
                    {
                        int urunID = Convert.ToInt32(row["UrunID"]);
                        int adet = Convert.ToInt32(row["Adet"]);
                        decimal birimFiyat = Convert.ToDecimal(row["Fiyat"]);

                        // A- Satış Detay Tablosuna Kaydet (YENİ EKLENDİ)
                        SatisDetayKaydet(satisID, urunID, adet, birimFiyat);

                        // B- Stoktan Düş
                        UrunManager.StokDus(urunID, adet);
                    }

                    // 3. Fiş Üret
                    FisUret(sepet, toplamTutar, odemeTipi, satisID);
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Satış işlemi sırasında hata: " + ex.Message);
                return false;
            }
        }


        // --- YENİ EKLENEN METOT: Satış Detaylarını Kaydeder ---
        private static void SatisDetayKaydet(int satisID, int urunID, int adet, decimal fiyat)
        {
            string sorgu = "INSERT INTO TBL_SATIS_DETAY (SatisID, UrunID, Adet, BirimFiyat) " +
                           "VALUES (@p1, @p2, @p3, @p4)";

            MySqlParameter[] p = {
                new MySqlParameter("@p1", satisID),
                new MySqlParameter("@p2", urunID),
                new MySqlParameter("@p3", adet),
                new MySqlParameter("@p4", fiyat)
            };

            Veritabani.KomutCalistir(sorgu, p);
        }



        private static int SatisLogla(decimal toplam, string tip, int kasiyerID)
        {
            // Veritabanına satış kaydı atar ve oluşturulan ID'yi döner
            string sorgu = "INSERT INTO TBL_SATISLAR (IslemTarihi, ToplamTutar, OdemeTipi, KasiyerID) " +
                           "VALUES (@p1, @p2, @p3, @p4); SELECT LAST_INSERT_ID();";

            MySqlParameter[] p = {
                new MySqlParameter("@p1", DateTime.Now),
                new MySqlParameter("@p2", toplam),
                new MySqlParameter("@p3", tip),
                new MySqlParameter("@p4", kasiyerID)
            };

            using (var baglanti = Veritabani.BaglantiGetir())
            {
                using (var komut = new MySqlCommand(sorgu, baglanti))
                {
                    komut.Parameters.AddRange(p);
                    return Convert.ToInt32(komut.ExecuteScalar()); // Kayıt ID'sini alıyoruz
                }
            }
        }

        private static void FisUret(DataTable sepet, decimal toplam, string tip, int satisID)
        {
            string klasorYolu = Path.Combine(Application.StartupPath, "Fisler");
            if (!Directory.Exists(klasorYolu)) Directory.CreateDirectory(klasorYolu);

            string dosyaAdi = $"Fis_{satisID}_{DateTime.Now:yyyyMMdd_HHmm}.txt";
            string tamYol = Path.Combine(klasorYolu, dosyaAdi);

            using (StreamWriter sw = new StreamWriter(tamYol))
            {
                sw.WriteLine("================================");
                sw.WriteLine("       MARKET OTOMASYONU        ");
                sw.WriteLine("================================");
                sw.WriteLine($"Fiş No  : {satisID}");
                sw.WriteLine($"Tarih   : {DateTime.Now}");
                sw.WriteLine($"Ödeme   : {tip}");
                sw.WriteLine("--------------------------------");
                sw.WriteLine("{0,-15} {1,-5} {2,8}", "Ürün", "Adet", "Tutar");

                foreach (DataRow row in sepet.Rows)
                {
                    string urunAd = row["UrunAdi"].ToString();
                    if (urunAd.Length > 15) urunAd = urunAd.Substring(0, 12) + "...";

                    sw.WriteLine("{0,-15} {1,-5} {2,8:N2}",
                        urunAd,
                        row["Adet"],
                        row["Toplam"]);
                }

                sw.WriteLine("--------------------------------");
                sw.WriteLine("TOPLAM: {0,22:N2} TL", toplam);
                sw.WriteLine("================================");
                sw.WriteLine("   Bizi Tercih Ettiğiniz İçin   ");
                sw.WriteLine("        Teşekkür Ederiz         ");
            }
        }
    }
}