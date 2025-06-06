using Org.BouncyCastle.Tls;
using System;
using System.Windows.Forms;

namespace TrabalhoLp2
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
            Application.Run(new Form1()); // Ensure LoginForm exists in the TrabalhoLp2.Forms namespace
        }
    }
}