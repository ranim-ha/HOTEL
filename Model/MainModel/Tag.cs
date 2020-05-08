using Shared.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Model.MainModel
{
    public class Tag : BaseEntity
    {

        #region Properties
        public string Name { get; set; }
        public string icon { get; set; }
        #endregion
        #region Navigation Properties
        public ICollection<RoomTag> RoomTags { get; set; }
        #endregion
    }
}