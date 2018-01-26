using System;
using System.Collections.Generic;

namespace YnovShop.Data.Entities
{
    public partial class YCategory
    {
        public YCategory()
        {
            YProduct = new HashSet<YProduct>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public ICollection<YProduct> YProduct { get; set; }
    }
}
