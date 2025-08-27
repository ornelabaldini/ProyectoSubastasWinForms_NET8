using System;
using System.Windows.Forms;
using ProyectoSubastasWinForms_NET8.Views;

namespace ProyectoSubastasWinForms_NET8
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            // Inicialización clásica para evitar dependencias de ApplicationConfiguration (plantilla VS)
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
