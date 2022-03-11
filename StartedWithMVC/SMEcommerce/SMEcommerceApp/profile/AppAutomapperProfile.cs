using AutoMapper;
using SMEcommerce.Models.EntityModels;
using SMEcommerceApp.Models.CategoryModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SMEcommerceApp.profile
{
    public class AppAutomapperProfile :Profile
    {
        public AppAutomapperProfile()
        {
            CreateMap<CategoryCreate, Category>();
            CreateMap<CategoryListVM, Category>();
            CreateMap<CategoryEditVM, Category>();
            CreateMap<Category, CategoryCreate>();
            CreateMap<Category, CategoryListVM>();
            CreateMap<Category, CategoryEditVM>();
            CreateMap<Category, CategoryResult>();
        }
    }
}
