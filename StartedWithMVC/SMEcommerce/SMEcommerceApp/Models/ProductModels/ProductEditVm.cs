using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SMEcommerceApp.Models.ProductModels
{
    public class ProductEditVm
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime ManufacturerDate { get; set; }
        public double Price { get; set; }

        public int CategoryId { get; set; }
        public List<SelectListItem> Categoies { get; set; }
    }
}
