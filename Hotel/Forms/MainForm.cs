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

            var miCatalog = new ToolStripMenuItem("Каталог номеров");
            miCatalog.Click += (s, e) => OpenChild(new CatalogForm());
            menu.Items.Add(miCatalog);

            if (LoginForm.CurrentUser.Role == "Менеджер" || LoginForm.CurrentUser.Role == "Админ")
            {
                var miAppr = new ToolStripMenuItem("Согласование");
                miAppr.Click += (s, e) => OpenChild(new ApprovalForm());
                menu.Items.Add(miAppr);
            }

            if (LoginForm.CurrentUser.Role == "Бухгалтер" || LoginForm.CurrentUser.Role == "Админ")
            {
                var miRep = new ToolStripMenuItem("Отчёты");
                miRep.Click += (s, e) => OpenChild(new ReportForm());
                menu.Items.Add(miRep);
            }

            var miExit = new ToolStripMenuItem("Выход");
            miExit.Click += (s, e) => Close();
            menu.Items.Add(miExit);

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