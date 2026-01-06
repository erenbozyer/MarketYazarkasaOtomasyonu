using System;
using System.Data;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json; // Newtonsoft.Json paketini NuGet'ten eklemelisiniz
using MySql.Data.MySqlClient;
using MarketOtomasyon.DAL;

namespace MarketOtomasyon.BL
{
    public class MusteriManager
    {
        private const string API_KEY = "AIzaSyBT1qEgKorXOMG_-pr5yD2hW5_B6hIBrfM";

        // Müşterinin tüm geçmiş ürünlerini getirir
        public static string MusteriGecmisiGetir(string musteriKodu)
        {
            string urunler = "";
            using (var baglanti = Veritabani.BaglantiGetir())
            {
                string sorgu = @"SELECT DISTINCT u.UrunAdi FROM TBL_SATIS_DETAY sd 
                                 JOIN TBL_SATISLAR s ON sd.SatisID = s.SatisID 
                                 JOIN TBL_MUSTERILER m ON s.MusteriID = m.MusteriID
                                 JOIN TBL_URUNLER u ON sd.UrunID = u.UrunID
                                 WHERE m.MusteriKodu = @p1";

                using (var komut = new MySqlCommand(sorgu, baglanti))
                {
                    komut.Parameters.AddWithValue("@p1", musteriKodu);
                    using (var dr = komut.ExecuteReader())
                    {
                        while (dr.Read()) urunler += dr["UrunAdi"].ToString() + ", ";
                    }
                }
            }
            return urunler;
        }

        public static async Task<string> GeminiOnerisiAl(string musteriKodu)
        {
            string gecmis = MusteriGecmisiGetir(musteriKodu);
            if (string.IsNullOrEmpty(gecmis)) return "Bu müşterinin geçmiş alışveriş kaydı bulunamadı.";

            // Stoktaki ürünleri al (Sınırlandırma için AI'ya verilecek)
            DataTable dtUrunler = UrunManager.UrunleriGetir();
            string stoktakiUrunler = "";
            foreach (DataRow r in dtUrunler.Rows) stoktakiUrunler += r["UrunAdi"] + ", ";

            // Promt Şablonu
            string prompt = $@"Sen bir market satış asistanısın. 
            Müşterinin geçmişte aldığı ürünler: {gecmis}. 
            Marketimizdeki mevcut ürün listesi: {stoktakiUrunler}. 
            Bu müşteriye geçmiş tercihlerine bakarak mevcut ürünlerimizden 3 tane mantıklı ürün öner.
            ÖNEMLİ: Sadece mevcut ürün listesindeki ürünleri öner, dışına çıkma.
            Yanıtı sadece ürün isimleri ve kısa birer cümlelik 'neden' açıklamasıyla ver.";

            return await GeminiApiSorgula(prompt);
        }

        private static async Task<string> GeminiApiSorgula(string prompt)
        {
            using (var client = new HttpClient())
            {
                var requestBody = new { contents = new[] { new { parts = new[] { new { text = prompt } } } } };
                var json = JsonConvert.SerializeObject(requestBody);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                var response = await client.PostAsync($"https://generativelanguage.googleapis.com/v1beta/models/gemini-2.5-flash:generateContent?key={API_KEY}", content);
                var resultJson = await response.Content.ReadAsStringAsync();

                dynamic data = JsonConvert.DeserializeObject(resultJson);
                return data.candidates[0].content.parts[0].text;
            }
        }
    }
}