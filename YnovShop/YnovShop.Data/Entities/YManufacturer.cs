using System;
using System.Collections.Generic;

namespace YnovShop.Data.Entities
{
    public partial class YManufacturer
    {
        public YManufacturer()
        {
            YProduct = new HashSet<YProduct>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Logo { get; set; }

        public ICollection<YProduct> YProduct { get; set; }
    }
}
