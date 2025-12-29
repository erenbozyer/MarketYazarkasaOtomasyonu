using System;
using System.Windows.Forms;
using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.UserSkins;

namespace MarketOtomasyon
{
    static class Program
    {
        /// <summary>
        /// Uygulamanın ana girdi noktası.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // DevExpress temalarını aktif et
            SkinManager.EnableFormSkins();
            // UserLookAndFeel.Default.SetSkinStyle("WXI"); // Modern tema (İsteğe bağlı)
            
            // DİKKAT: Burası new FrmLogin() olmalı!
            Application.Run(new FrmLogin());
        }
    }
}