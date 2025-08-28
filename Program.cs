using System;
using System.Globalization;
using System.Windows.Forms;
using ProyectoSubastasWinForms_NET8.Views;

namespace ProyectoSubastasWinForms_NET8
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("es-AR");
            CultureInfo.DefaultThreadCurrentUICulture = new CultureInfo("es-AR");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
