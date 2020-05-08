using Shared.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Model.MainModel
{
   public class RoomType:BaseEntity
    {
        #region Properties
        public string Name { get; set; }
        #endregion
        #region navigation Properties
        public ICollection<Room> Rooms { get; set; }
        #endregion
    }
}
