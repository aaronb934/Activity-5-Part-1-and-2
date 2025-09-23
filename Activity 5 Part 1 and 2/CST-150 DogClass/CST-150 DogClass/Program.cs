/*
 * Aaron Belschner
 * CST-150
 * Activity 5 Part 1
 * 9/18/25
 * This is my own work
 */

namespace CST_150_DogClass
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
            Application.Run(new PresentationLayer.FrmMain());
        }
    }
}