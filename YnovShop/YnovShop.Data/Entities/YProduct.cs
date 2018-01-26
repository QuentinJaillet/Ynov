using System;
using System.Collections.Generic;

namespace YnovShop.Data.Entities
{
    public partial class YProduct
    {
        public int Id { get; set; }
        public int IdCategory { get; set; }
        public int IdManufacturer { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }

        public YCategory IdCategoryNavigation { get; set; }
        public YManufacturer IdManufacturerNavigation { get; set; }
    }
}
