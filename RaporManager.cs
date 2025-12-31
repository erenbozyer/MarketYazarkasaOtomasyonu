using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MarketOtomasyon.DAL;

namespace MarketOtomasyon.BL
{
    public class RaporManager
    {
        

        public static void ZRaporuOlustur(DateTime tarih)
        {
            try
            {
                string tarihStr = tarih.ToString("yyyy-MM-dd");

                // 1. Özet Verileri Çek (Toplam Tutar, Nakit/Kredi Kartı Dağılımı)
                decimal toplamCiro = 0;
                decimal toplamNakit = 0;
                decimal toplamKredi = 0;
                int toplamSatisAdedi = 0;

                string ozetSorgu = @"SELECT 
                                    SUM(ToplamTutar) as GenelToplam,
                                    COUNT(SatisID) as SatisSayisi,
                                    SUM(CASE WHEN OdemeTipi = 'Nakit' THEN ToplamTutar ELSE 0 END) as NakitToplam,
                                    SUM(CASE WHEN OdemeTipi = 'Kredi Kartı' THEN ToplamTutar ELSE 0 END) as KrediToplam
                                   FROM TBL_SATISLAR 
                                   WHERE DATE(IslemTarihi) = @tarih";

                using (var baglanti = Veritabani.BaglantiGetir())
                {
                    using (var komut = new MySqlCommand(ozetSorgu, baglanti))
                    {
                        komut.Parameters.AddWithValue("@tarih", tarihStr);
                        using (var dr = komut.ExecuteReader())
                        {
                            if (dr.Read() && dr["GenelToplam"] != DBNull.Value)
                            {
                                toplamCiro = Convert.ToDecimal(dr["GenelToplam"]);
                                toplamSatisAdedi = Convert.ToInt32(dr["SatisSayisi"]);
                                toplamNakit = Convert.ToDecimal(dr["NakitToplam"]);
                                toplamKredi = Convert.ToDecimal(dr["KrediToplam"]);
                            }
                        }
                    }

                    // 2. Satılan Ürünlerin Detaylı Listesini Çek
                    string urunDetaySorgu = @"SELECT u.UrunAdi, SUM(sd.Adet) as ToplamAdet, SUM(sd.Adet * sd.BirimFiyat) as SatisTutari
                                            FROM TBL_SATIS_DETAY sd
                                            JOIN TBL_URUNLER u ON sd.UrunID = u.UrunID
                                            JOIN TBL_SATISLAR s ON sd.SatisID = s.SatisID
                                            WHERE DATE(s.IslemTarihi) = @tarih
                                            GROUP BY u.UrunAdi";

                    DataTable dtUrunler = new DataTable();
                    using (var da = new MySqlDataAdapter(urunDetaySorgu, baglanti))
                    {
                        da.SelectCommand.Parameters.AddWithValue("@tarih", tarihStr);
                        da.Fill(dtUrunler);
                    }

                    // 3. Dosyaya Yazdır
                    ZRaporuDosyala(tarih, toplamCiro, toplamNakit, toplamKredi, toplamSatisAdedi, dtUrunler);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Z Raporu oluşturulurken hata: " + ex.Message);
            }
        }

        private static void ZRaporuDosyala(DateTime tarih, decimal ciro, decimal nakit, decimal kredi, int adet, DataTable urunler)
        {
            string klasorYolu = Path.Combine(Application.StartupPath, "Raporlar");
            if (!Directory.Exists(klasorYolu)) Directory.CreateDirectory(klasorYolu);

            string dosyaAdi = $"Z_Raporu_{tarih:yyyyMMdd}.txt";
            string tamYol = Path.Combine(klasorYolu, dosyaAdi);

            using (StreamWriter sw = new StreamWriter(tamYol))
            {
                sw.WriteLine("================================");
                sw.WriteLine("       GÜN SONU (Z) RAPORU      ");
                sw.WriteLine("================================");
                sw.WriteLine($"Tarih         : {tarih.ToShortDateString()}");
                sw.WriteLine($"Rapor Saati   : {DateTime.Now.ToShortTimeString()}");
                sw.WriteLine("--------------------------------");
                sw.WriteLine($"Toplam Satış  : {adet}");
                sw.WriteLine($"Nakit Toplam  : {nakit:N2} TL");
                sw.WriteLine($"K.Kartı Toplam: {kredi:N2} TL");
                sw.WriteLine($"GENEL CİRO    : {ciro:N2} TL");
                sw.WriteLine("--------------------------------");
                sw.WriteLine("SATILAN ÜRÜN DAĞILIMI:");
                sw.WriteLine("{0,-15} {1,5} {2,10}", "Ürün Adı", "Adet", "Tutar");

                foreach (DataRow row in urunler.Rows)
                {
                    string ad = row["UrunAdi"].ToString();
                    if (ad.Length > 15) ad = ad.Substring(0, 12) + "...";
                    sw.WriteLine("{0,-15} {1,5} {2,10:N2}", ad, row["ToplamAdet"], row["SatisTutari"]);
                }

                sw.WriteLine("================================");
                sw.WriteLine("         RAPOR SONU             ");
            }

            MessageBox.Show($"Z Raporu Başarıyla Oluşturuldu:\n{tamYol}", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}