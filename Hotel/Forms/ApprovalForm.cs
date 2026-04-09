using Hotel.Data_Access_Layer;
using System;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Hotel.Forms
{
    public partial class ApprovalForm : Form
    {
        public ApprovalForm() { InitializeComponent(); LoadRequests(); }

        void LoadRequests()
        {
            dgv.DataSource = DbRepository.GetRequestsForApproval();
        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            if (dgv.CurrentRow == null) return;
            int id = (int)dgv.CurrentRow.Cells["RequestId"].Value;
            DbRepository.ApproveRequest(id, true, tbComment.Text);
            LoadRequests();
        }

        private void btnReject_Click(object sender, EventArgs e)
        {
            if (dgv.CurrentRow == null) return;
            int id = (int)dgv.CurrentRow.Cells["RequestId"].Value;
            DbRepository.ApproveRequest(id, false, tbComment.Text);
            LoadRequests();
        }
    }
}