using System;
using System.Data;
using MySql.Data.MySqlClient;
using MarketOtomasyon.DAL; // DAL'a erişim

namespace MarketOtomasyon.BL
{
    public class KullaniciManager
    {
        // Geriye 'Kullanici' nesnesi döndürelim ki, giriş yapanın kim olduğunu bilelim
        // (Müdür mü Kasiyer mi?)
        public static DataRow GirisYap(string kadi, string sifre)
        {
            string sorgu = "SELECT * FROM TBL_KULLANICILAR WHERE KullaniciAdi=@p1 AND Sifre=@p2";

            MySqlParameter[] parametreler = {
                new MySqlParameter("@p1", kadi),
                new MySqlParameter("@p2", sifre)
            };

            // DAL katmanındaki bağlantıyı kullanıp veriyi çekiyoruz
            using (var baglanti = Veritabani.BaglantiGetir())
            {
                using (var komut = new MySqlCommand(sorgu, baglanti))
                {
                    komut.Parameters.AddRange(parametreler);
                    MySqlDataAdapter da = new MySqlDataAdapter(komut);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        return dt.Rows[0]; // Kullanıcı bulundu, bilgilerini döndür
                    }
                }
            }
            return null; // Kullanıcı bulunamadı
        }
    }
}