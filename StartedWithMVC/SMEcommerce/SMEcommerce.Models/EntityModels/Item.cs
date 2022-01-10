﻿using SMEcommerce.Models.EntityModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMEcommerce.Models.EntityModels
{
    [Table("Products")]
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime ManufactureDate { get; set; }
        public double Price { get; set; }

        [ForeignKey("Category")]
        public int? CategoryId { get; set; }
        public Category Category { get; set; }

        //[ForeignKey("Brand")]
        //public int? BrandId { get; set; }
        //public Brand Brand { get; set; }
    }
}
