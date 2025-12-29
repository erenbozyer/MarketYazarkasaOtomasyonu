using System;
using System.Data;
using MySql.Data.MySqlClient;
using MarketOtomasyon.DAL; // DAL'a erişim

namespace MarketOtomasyon.BL
{
    public class UrunManager
    {
        // 1. Tüm Ürünleri Listele (Grid İçin)
        public static DataTable UrunleriGetir()
        {
            using (var baglanti = Veritabani.BaglantiGetir())
            {
                // 'Active' mantığı olmadığı için hepsini çekiyoruz
                string sorgu = "SELECT * FROM TBL_URUNLER ORDER BY UrunAdi";
                using (var da = new MySqlDataAdapter(sorgu, baglanti))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
        }

        // 2. Yeni Ürün Ekle
        public static bool UrunEkle(string barkod, string ad, string kategori, decimal alis, decimal satis, int stok)
        {
            string sorgu = "INSERT INTO TBL_URUNLER (Barkod, UrunAdi, Kategori, AlisFiyati, SatisFiyati, StokMiktari) " +
                           "VALUES (@p1, @p2, @p3, @p4, @p5, @p6)";

            MySqlParameter[] p = {
                new MySqlParameter("@p1", barkod),
                new MySqlParameter("@p2", ad),
                new MySqlParameter("@p3", kategori),
                new MySqlParameter("@p4", alis),
                new MySqlParameter("@p5", satis),
                new MySqlParameter("@p6", stok)
            };

            return Veritabani.KomutCalistir(sorgu, p);
        }

        // 3. Ürün Sil
        public static bool UrunSil(int id)
        {
            string sorgu = "DELETE FROM TBL_URUNLER WHERE UrunID=@p1";
            MySqlParameter[] p = { new MySqlParameter("@p1", id) };
            return Veritabani.KomutCalistir(sorgu, p);
        }

        // 4. Ürün Güncelle
        public static bool UrunGuncelle(int id, string barkod, string ad, string kategori, decimal alis, decimal satis, int stok)
        {
            string sorgu = "UPDATE TBL_URUNLER SET Barkod=@p1, UrunAdi=@p2, Kategori=@p3, AlisFiyati=@p4, SatisFiyati=@p5, StokMiktari=@p6 WHERE UrunID=@p7";

            MySqlParameter[] p = {
                new MySqlParameter("@p1", barkod),
                new MySqlParameter("@p2", ad),
                new MySqlParameter("@p3", kategori),
                new MySqlParameter("@p4", alis),
                new MySqlParameter("@p5", satis),
                new MySqlParameter("@p6", stok),
                new MySqlParameter("@p7", id)
            };

            return Veritabani.KomutCalistir(sorgu, p);
        }
        // 5. Barkoda Göre Tek Bir Ürün Getir (Satış Ekranı İçin)
        public static DataRow UrunGetir(string barkod)
        {
            using (var baglanti = Veritabani.BaglantiGetir())
            {
                string sorgu = "SELECT * FROM TBL_URUNLER WHERE Barkod = @p1";
                using (var komut = new MySqlCommand(sorgu, baglanti))
                {
                    komut.Parameters.AddWithValue("@p1", barkod);
                    MySqlDataAdapter da = new MySqlDataAdapter(komut);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    if (dt.Rows.Count > 0)
                        return dt.Rows[0]; // Ürünü bulduk, satırı döndür
                    else
                        return null; // Ürün yok
                }
            }
        }

        // 6. Stok Düşme İşlemi (Satış Yapılınca)
        public static void StokDus(int urunID, int satilanAdet)
        {
            string sorgu = "UPDATE TBL_URUNLER SET StokMiktari = StokMiktari - @adet WHERE UrunID = @id";
            MySqlParameter[] p = {
            new MySqlParameter("@adet", satilanAdet),
            new MySqlParameter("@id", urunID)
            };

            Veritabani.KomutCalistir(sorgu, p);
        }

    }
}