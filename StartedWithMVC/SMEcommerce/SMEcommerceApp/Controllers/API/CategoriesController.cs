using AutoMapper;
using Microsoft.AspNetCore.Mvc;
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
            if(categories==null)
            {
                return NoContent();
            }
            var categoryResults = _mapper.Map<IList<CategoryResult>>(categories);
            return Ok(categoryResults);
        }

    }
}
