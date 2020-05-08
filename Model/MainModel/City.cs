using System;
using System.Collections.Generic;
using System.Text;

namespace Model.MainModel
{
    public class City
    {

        #region Properties
        public string Name { get; set; }
        #endregion

        #region Navigation Properties
        public Guid CountryId { get; set; }
        public Country Country { get; set; }
        #endregion
    }
}
