using System.Collections.Generic;

namespace SMEcommerce.Models.EntityModels
{
    public class Brand
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<Item> Items { get; set; }

    }
}
