using SMEcommerce.Models.EntityModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace SMEcommerce.Repositories.Abstractions
{
    public interface IPremiumCategoryRepository
    {
        bool Add(Category category);
        bool Remove(Category category);
        bool Update(Category category);
        ICollection<Category> GetAll();
        Category GetId(int id);
    }
}
