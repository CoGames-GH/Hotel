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
        private void dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;          // заголовок
            int roomId = Convert.ToInt32(dgv.Rows[e.RowIndex].Cells["RoomId"].Value);
            OpenRequest(roomId);
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            if (dgv.CurrentRow == null) return;
            int roomId = Convert.ToInt32(dgv.CurrentRow.Cells["RoomId"].Value);
            OpenRequest(roomId);
        }

        private void OpenRequest(int roomId)
        {
            using (var rf = new RequestForm(roomId))
            {
                if (rf.ShowDialog(this) == DialogResult.OK)
                    LoadCatalog();
            }
        }
        private void btnSearch_Click(object sender, EventArgs e) => LoadCatalog();
    }
}