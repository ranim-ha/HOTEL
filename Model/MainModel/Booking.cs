using System;
using System.Collections.Generic;
using System.Text;

namespace Model.MainModel
{
   public class Booking
    {

        #region Properties
        #endregion
        #region Navigation Properties
        public Guid BillId{ get; set; }
        public ICollection<RoomBooking> RoomBookings { get; set; }
        #endregion
    }
}
