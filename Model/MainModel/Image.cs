using Shared.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Model.MainModel
{
    public class Image : BaseEntity
    {
        #region Properties
        public string Url { get; set; }
        public Boolean isCovered { get; set; }
        #endregion
        #region Navigation Properties
        public Guid RoomId { get; set; }
        public Room Room { get; set; }
        #endregion
        #region Constructors
        #endregion
        #region Methods
        #endregion
    }
}
