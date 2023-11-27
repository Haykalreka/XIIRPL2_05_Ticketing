using XIIRPL2_05_Ticketing.MasterForm;

namespace XIIRPL2_05_Ticketing
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            //FormLogin FormLogin = new FormLogin();
            //FormLogin.Show();
            FormMasterBandara bandara = new FormMasterBandara();
            bandara.Show();
            //FormMasterMaskapai maskapai = new FormMasterMaskapai();
            //.Show();

            //FormMasterKodePromo kodePromo = new FormMasterKodePromo();
            //kodePromo.Show();



            Application.Run();
        }
    }
}