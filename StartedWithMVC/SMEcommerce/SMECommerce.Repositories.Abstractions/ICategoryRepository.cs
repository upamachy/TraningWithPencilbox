using SMEcommerce.Models.EntityModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace SMEcommerce.Repositories.Abstractions
{
    public interface ICategoryRepository:IRepositories<Category>
    {
        ICollection<Category>GetTopCategory();
        Category CategoryName(int id);
    }
}
