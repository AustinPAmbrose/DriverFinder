using System.Diagnostics;
using System.Formats.Asn1;
using System.Text.Json;

namespace DriverFinder
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Launch the application
            ApplicationConfiguration.Initialize();
            var mainForm = new MainForm();
            // The form might throw an error and dispose itself
            if (mainForm.IsDisposed) return;
            Application.Run(mainForm);
        }
    }
}