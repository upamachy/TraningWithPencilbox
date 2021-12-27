using Microsoft.AspNetCore.Mvc;
using SMEcommerce.Models.EntityModels;
using SMEcommerce.Repositories;
using SMEcommerceApp.Models.CategoryModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SMEcommerceApp.Controllers
{
    public class CategoryController : Controller
    {
        public string Index()
        {
            return "This is a default Controller";
        }

        #region Model
        //public string Create(CategoryCreate category)
        //{
        //    return $"Category Name:{category.Name} and code:{category.Code}";
        //}

        public string CategoryListCreate(CategoryCreate[] categories)
        {
            string data = "Category List Created" + Environment.NewLine;
            if(categories!=null && categories.Any())
            {
                foreach (var category in categories)
                {
                    data += $"Category Name:{category.Name} and code:{category.Code}"+Environment.NewLine;
                }
            }

            return data;
        }
        #endregion

        #region View

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(CategoryCreate model)
        {
            CategoryRepositories categoryRepo = new CategoryRepositories();
            if (model.Name!=null)
            {
                
                var category = new Category()
                {
                    Name = model.Name,
                    Description = model.Description,
                    Code = model.Code
                };

                var isAdded = categoryRepo.Add(category);
                if(isAdded)
                {
                    return View("Success");
                }
            }
          return View();
        }

        #endregion
    }
}
