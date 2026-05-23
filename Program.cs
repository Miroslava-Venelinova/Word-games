namespace WinFormsApp
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]// To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Start());
        }
    }
}