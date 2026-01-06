namespace MarketOtomasyon.BL
{
    public static class GlobalVariables
    {
        // Giriş yapan kullanıcının tüm bilgilerini burada tutacağız
        public static int KasiyerID { get; set; }
        public static string KullaniciAdi { get; set; }
        public static string Rol { get; set; } // Müdür / Kasiyer
    }
}