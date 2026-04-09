using System;
using System.Windows.Forms;
using Hotel.Data_Access_Layer;

namespace Hotel.Forms
{
    public partial class ReportForm : Form
    {
        public ReportForm() { InitializeComponent(); }

        private void btnBuild_Click(object sender, EventArgs e)
        {
            var from = dtpFrom.Value.Date;
            var to = dtpTo.Value.Date;
            dgv.DataSource = DbRepository.GetReport(from, to);
        }
    }
}