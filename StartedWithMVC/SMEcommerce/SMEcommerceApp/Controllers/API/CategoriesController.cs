using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SMEcommerce.Models.EntityModels;
using SMECommerce.Services.Abstractions;
using SMEcommerceApp.Models.CategoryModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SMEcommerceApp.Controllers.API
{
    [Route("api/categories")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {

        ICategoryService _categoryService;
        IMapper _mapper;
        public CategoriesController(ICategoryService categoryService, IMapper mapper)
        {
            _categoryService = categoryService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetCategories()
        {
            var categories = _categoryService.GetAll();
            if (categories == null)
            {
                return NoContent();
            }
            var categoryResults = _mapper.Map<IList<CategoryResult>>(categories);
            return Ok(categoryResults);
        }

        [HttpGet("{id}")]

        public IActionResult GetById(int? id)
        {
            if(id==null)
            {
                return BadRequest("Please provide the id");
            }

            var category = _categoryService.GetById((int)id);

            if(category==null)
            {
                return NotFound();
            }
            var categoryResult = _mapper.Map<CategoryResult>(category);
            return Ok(categoryResult);
        }

        [HttpPost]

        public IActionResult Post(CategoryCreate model)
        {
            if(ModelState.IsValid)
            {
                var category = _mapper.Map<Category>(model);

                var isSuccess = _categoryService.Add(category);

            }
        }
    }
}
