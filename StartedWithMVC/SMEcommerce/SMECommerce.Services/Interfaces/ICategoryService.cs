using SMEcommerce.Models.EntityModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace SMECommerce.Services.Interfaces
{
    public interface ICategoryService
    {
        bool Add(Category category);
        bool Remove(Category category);
        bool Update(Category category);
        ICollection<Category> GetAll();
        Category GetId(int id);
        Category CategoryName(int id);
    }
}
