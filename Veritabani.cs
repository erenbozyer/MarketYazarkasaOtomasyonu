using System;
using System.Data;
using MySql.Data.MySqlClient; // Az önce yüklediğimiz kütüphane

namespace MarketOtomasyon.DAL
{
    public class Veritabani
    {
        // MySQL Bağlantı Cümlesi (ConnectionString)
        // Eğer XAMPP kullanıyorsan genelde şifre yoktur, Pwd=; kalabilir.
        // Şifren varsa Pwd=SeninSifren; yapmalısın.
        private static string baglantiCumlesi = "Server=localhost;Database=DbMarketOtomasyon;Uid=root;Pwd=;";

        public static MySqlConnection BaglantiGetir()
        {
            MySqlConnection baglanti = new MySqlConnection(baglantiCumlesi);

            // Bağlantı kapalıysa açalım
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }
            return baglanti;
        }

        // Veritabanı işlemlerini (Ekle/Sil/Güncelle) yönetecek temel metod
        // Bu metodu bütün formlarda kullanacağız, kod tekrarını önler 
        public static bool KomutCalistir(string sqlSorgusu, params MySqlParameter[] parametreler)
        {
            using (MySqlConnection baglan = new MySqlConnection(baglantiCumlesi))
            {
                using (MySqlCommand komut = new MySqlCommand(sqlSorgusu, baglan))
                {
                    if (parametreler != null)
                    {
                        komut.Parameters.AddRange(parametreler);
                    }

                    try
                    {
                        baglan.Open();
                        komut.ExecuteNonQuery(); // İşlemi yap (Ekle/Sil/Güncelle)
                        return true;
                    }
                    catch (Exception ex)
                    {
                        // Hata olursa burada yakalarız (Loglama yapılabilir)
                        System.Windows.Forms.MessageBox.Show("Veritabanı Hatası: " + ex.Message);
                        return false;
                    }
                }
            }
        }
    }
}