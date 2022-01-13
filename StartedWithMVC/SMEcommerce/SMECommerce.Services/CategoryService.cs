using SMEcommerce.Models.EntityModels;
using SMEcommerce.Repositories;
using SMEcommerce.Repositories.Abstractions;
using SMECommerce.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SMECommerce.Services
{
    public class CategoryService : ICategoryService
    {
       ICategoryRepository _categoryRepository;
        IPremiumCategoryRepository _PremiumCategoryRepository;

        public CategoryService(ICategoryRepository categoryRepository,IPremiumCategoryRepository premiumCategoryRepository)
        {
            _categoryRepository = categoryRepository;
            _PremiumCategoryRepository = premiumCategoryRepository;
            //_categoryRepository = new CategoryRepositories();
        }

        

        public ICollection<Category> GetAll()
        {
            return _categoryRepository.GetAll();
        }

        public Category GetId(int id)
        {
            return _categoryRepository.GetId(id);
        }
        public bool Add(Category category)
        {
            //logic for category add

            if(string.IsNullOrEmpty(category.Name))
            {
                return false;
            }

            return _categoryRepository.Add(category);
        }

        public bool Update(Category category)
        {
            return _categoryRepository.Update(category);
        }

        public bool Remove(Category category)
        {
            return _categoryRepository.Update(category);
        }
        public Category CategoryName(int id)
        {
            return _categoryRepository.CategoryName(id);
        }
    }
}
