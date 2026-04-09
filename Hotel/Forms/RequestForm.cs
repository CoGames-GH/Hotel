using System;
using System.Windows.Forms;
using Hotel.Data_Access_Layer;
using Hotel.Models;

namespace Hotel.Forms
{
    public partial class RequestForm : Form
    {
        private readonly int _roomId;
        public RequestForm(int roomId)
        {
            InitializeComponent();
            _roomId = roomId;
            dtpCheckIn.MinDate = DateTime.Today;
            dtpCheckOut.MinDate = DateTime.Today.AddDays(1);
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            var req = new BookingRequest
            {
                UserId = LoginForm.CurrentUser.Id,
                RoomId = _roomId,
                CheckInDate = dtpCheckIn.Value.Date,
                CheckOutDate = dtpCheckOut.Value.Date,
                TotalAmount = CalcTotal()
            };
            if (DbRepository.InsertRequest(req) > 0)
            {
                MessageBox.Show("Заявка отправлена на согласование");
                DialogResult = DialogResult.OK;
            }
            else MessageBox.Show("Ошибка сохранения");
        }

        private decimal CalcTotal()
        {
            int nights = (dtpCheckOut.Value.Date - dtpCheckIn.Value.Date).Days;
            var dt = SqlHelper.ExecQuery("SELECT PricePerNight FROM Rooms WHERE Id=@r",
                new System.Data.SqlClient.SqlParameter("@r", _roomId));
            decimal price = (decimal)dt.Rows[0]["PricePerNight"];
            return price * nights;
        }
    }
}