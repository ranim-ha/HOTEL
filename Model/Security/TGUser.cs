using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Security
{
    public class TGUser : IdentityUser<Guid>
    {
        #region Properties
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string ImageProfile { get; set; }
        public string Gender { get; set; }
        public string Country { get; set; }


    }
