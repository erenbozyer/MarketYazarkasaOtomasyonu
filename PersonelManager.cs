using System;
using System.Data;
using MySql.Data.MySqlClient;
using MarketOtomasyon.DAL;

namespace MarketOtomasyon.BL
{
    public class PersonelManager
    {
        // 1. Tüm Personelleri Listele
        public static DataTable KullanicilariGetir()
        {
            using (var baglanti = Veritabani.BaglantiGetir())
            {
                string sorgu = "SELECT KullaniciID, KullaniciAdi, Sifre, Rol FROM TBL_KULLANICILAR ORDER BY KullaniciAdi";
                using (var da = new MySqlDataAdapter(sorgu, baglanti))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
        }

        // 2. Yeni Personel Ekle
        public static bool KullaniciEkle(string kadi, string sifre, string rol)
        {
            string sorgu = "INSERT INTO TBL_KULLANICILAR (KullaniciAdi, Sifre, Rol) VALUES (@p1, @p2, @p3)";
            MySqlParameter[] p = {
                new MySqlParameter("@p1", kadi),
                new MySqlParameter("@p2", sifre),
                new MySqlParameter("@p3", rol)
            };
            return Veritabani.KomutCalistir(sorgu, p);
        }

        // 3. Personel Güncelle
        public static bool KullaniciGuncelle(int id, string kadi, string sifre, string rol)
        {
            string sorgu = "UPDATE TBL_KULLANICILAR SET KullaniciAdi=@p1, Sifre=@p2, Rol=@p3 WHERE KullaniciID=@p4";
            MySqlParameter[] p = {
                new MySqlParameter("@p1", kadi),
                new MySqlParameter("@p2", sifre),
                new MySqlParameter("@p3", rol),
                new MySqlParameter("@p4", id)
            };
            return Veritabani.KomutCalistir(sorgu, p);
        }

        // 4. Personel Sil
        public static bool KullaniciSil(int id)
        {
            string sorgu = "DELETE FROM TBL_KULLANICILAR WHERE KullaniciID=@p1";
            MySqlParameter[] p = { new MySqlParameter("@p1", id) };
            return Veritabani.KomutCalistir(sorgu, p);
        }
    }
}