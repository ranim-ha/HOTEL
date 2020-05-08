using Shared.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Model.MainModel
{
    public class Bill:BaseEntity

    {

        #region Properties
        public int Price { get; set; }
        public DateTime Time { get; set; }
        public bool PaymentState { get; set; }
        #endregion
        #region Navigation Properties
        public Guid BookingId { get; set; }
        #endregion
    }
}
