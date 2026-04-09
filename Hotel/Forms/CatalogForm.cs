using System;
using System.Drawing;
using System.Windows.Forms;
using Hotel.Data_Access_Layer;

namespace Hotel.Forms
{
    public partial class CatalogForm : Form
    {
        public CatalogForm()
        {
            InitializeComponent();
            LoadCatalog();
        }

        void LoadCatalog()
        {
            var city = tbCity.Text.Trim();
            var from = dtpFrom.Checked ? dtpFrom.Value.Date : (DateTime?)null;
            var to = dtpTo.Checked ? dtpTo.Value.Date : (DateTime?)null;
            decimal? maxPrice = null;
            if (decimal.TryParse(tbPrice.Text, out var p)) maxPrice = p;

            var dt = DbRepository.GetRooms(city, from, to, maxPrice);
            dgv.DataSource = dt;
        }

        private void btnSearch_Click(object sender, EventArgs e) => LoadCatalog();
    }
}