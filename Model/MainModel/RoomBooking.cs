using Shared.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Model.MainModel
{
    public class RoomBooking : BaseEntity

    {

        #region Properties
        public int RoomPrice { get; set; }
        public DateTime BookingStartDate { get; set; }
        public DateTime BookingEndDate { get; set; }
       
        #endregion
        #region Navigation Properties
        public Guid RoomId { get; set; }
        public Room Room { get; set; }
        public Guid BookingId { get; set; }
        public Booking Booking { get; set; }
        #endregion
    }
}
