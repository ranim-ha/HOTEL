using System;
using System.Collections.Generic;
using System.Text;

namespace Model.MainModel
{
    public class RoomTag
    {
        #region Properties
        public string Value { get; set; }
        #endregion

        #region Navigation Properties
        public Tag Tags { get; set; }
        public Guid TagId { get; set; }
        public Room Room { get; set; }
        public Guid RoomId { get; set; }
        #endregion
    }
}
