using System;
using System.Windows.Forms;
using Hotel.Forms;
using Hotel.Models;

namespace Hotel
{
    internal static class Program
    {
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            using (var login = new LoginForm())
            {
                if (login.ShowDialog() != DialogResult.OK) return;
            }
            Application.Run(new MainForm());
        }
    }
}