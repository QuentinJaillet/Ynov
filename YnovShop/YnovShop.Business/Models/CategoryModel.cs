using System;
using System.Collections.Generic;
using System.Text;

namespace YnovShop.Business.Models
{
    public class CategoryModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public int ProductsCount { get; set; }
    }
}
