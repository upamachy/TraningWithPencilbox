using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_7.Models.EntityModels
{
    [Table("Products")]
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Manufacturedate { get; set; }
        public double Price { get; set; }
        //public Category Category { get; set; }
    }
}
