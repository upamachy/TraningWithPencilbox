using SMEcommerce.Models.EntityModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace SMECommerce.Services.Abstractions
{
    public interface ICategoryService:IService<Category>
    {
       
        Category CategoryName(int id);
    }
}
