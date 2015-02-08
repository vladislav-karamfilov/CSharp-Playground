namespace StudentInfoSystem.UI
{
    using System;
    using System.Windows.Forms;
    using global::StudentInfoSystem.UI.Views;

    internal static class StudentInfoSystem
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        internal static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
