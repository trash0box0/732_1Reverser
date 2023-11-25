namespace _732_1Reverser
{
    internal static class Program
    {
        private static DBWorker worker = new DBWorker("D:\\users.db");
        private static MainForm mainForm = new MainForm();
        private static authForm authForm = new authForm(mainForm, worker);

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        /// 
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            authForm.Show();

            Application.Run(mainForm);
        }
    }
}