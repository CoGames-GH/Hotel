using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Models
{
    public class BookingRequest
    {
        public int RequestId { get; set; }
        public int UserId { get; set; }
        public int RoomId { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        public string Status { get; set; }
        public string Comment { get; set; }
        public decimal TotalAmount { get; set; }

        public string UserName { get; set; }
        public string RoomName { get; set; }
    }
}