using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SMEcommerce.Models.EntityModels;
using SMECommerce.Services.Abstractions;
using SMEcommerceApp.Models.CategoryModels;
using System;
using System.Linq;

namespace SMEcommerceApp.Controllers
{
    public class CategoryController : Controller
    {
        ICategoryService _categoryService;
        IMapper _mapper;
        public CategoryController(ICategoryService categoryService,IMapper mapper)
        {
            _categoryService = categoryService;
            _mapper = mapper;
        }
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
           
            if (model.Name!=null)
            {

                //var category = new Category()
                //{
                //    Name = model.Name,
                //    Description = model.Description,
                //    Code = model.Code
                //};

                var category = _mapper.Map<Category>(model);
                var isAdded = _categoryService.Add(category);
                if(isAdded)
                {
                    return RedirectToAction("List");
                }
            }
          return View();
        }

        public IActionResult Edit(int? id)
        {
            if(id==null)
            {
                return RedirectToAction("List");
            }

            var category = _categoryService.GetById((int)id);

            if(category==null)
            {
                return RedirectToAction("List");
            }

            var categoryEditVm = new CategoryEditVM()
            {
                Id=category.Id,
                Name = category.Name,
                Code = category.Code,
                Description = category.Description

            };

            return View(categoryEditVm);
        }

        [HttpPost]
        public IActionResult Edit(CategoryEditVM model)
        {
            if(ModelState.IsValid)
            {
                //var category = new Category()
                //{
                //    Id = model.Id,
                //    Name = model.Name,
                //    Code = model.Code,
                //    Description = model.Description
                //};
               var category= _mapper.Map<Category>(model);
                bool isUpdated = _categoryService.Update(category);
                if(isUpdated)
                {
                    return RedirectToAction("List");
                }
            }
            return View();
        }

        public IActionResult Delete(int? id)
        {
            if(id==null)
            {
                return RedirectToAction("List");
            }

            var category = _categoryService.GetById((int)id);
            if(category==null)
            {
                return RedirectToAction("List");
            }

            bool isremoved = _categoryService.Remove(category);
            if(isremoved)
            {
                return RedirectToAction("List");
            }
            return RedirectToAction("List");
        }
        

        public IActionResult List()
        {
            var categoryList = _categoryService.GetAll();
            //ViewBag.CategoryList = categoryList;
            //viewBag mainly used to get the data from controller in view.
            //viewBag mainly a dynamic + expand obj type.Where it can get the property using dot with it and doesn't need to declare the property separately.
            //ViewData["CategoryList"] = categoryList;
            //viewBag ultimately use viewData as underline datastore.
            //viewBag-Dynamic type obj 
            //viewdata-Dynamic type dictionary

            var categoryListVm = new CategoryListVM()
            {
                Title = "Category Overview",
                Description = "You can manage category from this page .You can create,Update and delete categories...",
                CategoryList = categoryList.ToList()

            };

            return View(categoryListVm);
        }

        #endregion
    }
}
