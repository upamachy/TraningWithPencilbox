using SMEcommerce.Models.EntityModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace SMEcommerce.Repositories.Abstractions
{
    public interface IProductRepository:IRepositories<Item>
    {
        bool Save();
    }
}
