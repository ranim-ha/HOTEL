using Shared.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Model.MainModel
{
    public class Room : BaseEntity
    {
        #region Properties
        #endregion

        #region Navigation Properties
        public Guid RoomTypeID { get; set; }
        public ICollection<WishList> WishLists { get; set; }
        public ICollection<RoopTag> RoopTags { get; set; }
        public ICollection<Image> Images { get; set; }
        public ICollection<RoomBooking> RoomBookings { get; set; }
        #endregion
        #region Constructors
        #endregion
        #region Methods
        #endregion
    }
}
