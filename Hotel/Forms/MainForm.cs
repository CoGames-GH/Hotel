using System;
using System.Windows.Forms;
using Hotel.Models;

namespace Hotel.Forms
{
    public partial class MainForm : Form
    {
        private MenuStrip menu;

        public MainForm()
        {
            InitializeComponent();
            Text = $"Сервис бронирования – {LoginForm.CurrentUser.Name} ({LoginForm.CurrentUser.Role})";
            BuildMenu();
        }

        private void BuildMenu()
        {
            menu = new MenuStrip();

            // 1. Каталог номеров – доступен всем
            var miCatalog = new ToolStripMenuItem("Каталог номеров");
            miCatalog.Click += (s, e) => OpenChild(new CatalogForm());
            menu.Items.Add(miCatalog);

            // 2. Согласование – только руководитель
            if (LoginForm.CurrentUser.Role == "Manager")
            {
                var miAppr = new ToolStripMenuItem("Согласование");
                miAppr.Click += (s, e) => OpenChild(new ApprovalForm());
                menu.Items.Add(miAppr);
            }

            // 3. Отчёты – только бухгалтер
            if (LoginForm.CurrentUser.Role == "Accountant")
            {
                var miRep = new ToolStripMenuItem("Отчёты");
                miRep.Click += (s, e) => OpenChild(new ReportForm());
                menu.Items.Add(miRep);
            }

            // 4. Выход
            var miExit = new ToolStripMenuItem("Выход");
            miExit.Click += (s, e) => Close();
            menu.Items.Add(miExit);

            // Добавляем MenuStrip на форму
            Controls.Add(menu);
            MainMenuStrip = menu;
        }

        private void OpenChild(Form f)
        {
            f.MdiParent = this;
            f.WindowState = FormWindowState.Maximized;
            f.Show();
        }
    }
}