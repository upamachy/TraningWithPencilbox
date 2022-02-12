using SMEcommerce.Models.EntityModels;
using SMEcommerce.Repositories.Abstractions;
using SMECommerce.Services.Abstractions;

namespace SMECommerce.Services
{
    public class CategoryService : Service<Category>, ICategoryService
    {
       ICategoryRepository _categoryRepository;


        public CategoryService(ICategoryRepository categoryRepository):base(categoryRepository)
        {
            _categoryRepository = categoryRepository;
            
            //_categoryRepository = new CategoryRepositories();
        }


        public Category CategoryName(int id)
        {
            return _categoryRepository.CategoryName(id);
        }

        
    }
}
