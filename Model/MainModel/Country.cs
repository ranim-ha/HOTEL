using System;
using System.Collections.Generic;
using System.Text;

namespace Model.MainModel
{
    public class Country
    {
        #region Properties
        public string Name { get; set; }
        #endregion

        #region Navigation Properties
        public ICollection<City> cities { get; set; }
      
        #endregion

    }
}
