using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SMEcommerceApp.Models.ProductModels
{
    public class ProductCreateVm
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime ManufacturerDate { get; set; }
        public double Price { get; set; }

        //-------Select Drop-Down-------------
        public int CategoryId { get; set; }
        public List<SelectListItem> SelectCategoies { get; set; }

        
    }
}
