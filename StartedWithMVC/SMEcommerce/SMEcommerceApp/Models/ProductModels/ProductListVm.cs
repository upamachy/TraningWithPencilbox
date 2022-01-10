
using SMEcommerce.Models.EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SMEcommerceApp.Models.ProductModels
{
    public class ProductListVm
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public ICollection<Item> ProductList { get; set; }
    }
}
