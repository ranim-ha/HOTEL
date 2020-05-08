using Shared.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Model.MainModel
{
    public class WishList : BaseEntity
    {
        public Guid TGUserId { get; set; }
        public TGUser TGUser { get; set; }

        public Guid RoomId { get; set; }
        public Room Room { get; set; }

    }
}
