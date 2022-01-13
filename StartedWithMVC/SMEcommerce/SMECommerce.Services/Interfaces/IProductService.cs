using SMEcommerce.Models.EntityModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace SMECommerce.Services.Interfaces
{
    public interface IProductService
    {
        bool Add(Item item);
        bool Update(Item item);
        bool Remove(Item item);
        Item GetById(int id);
        ICollection<Item> GetAll();
        bool Save();
    }
}
