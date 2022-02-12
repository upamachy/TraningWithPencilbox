using SMEcommerce.Models.EntityModels;
using SMEcommerce.Repositories.Abstractions;
using SMECommerce.Services.Abstractions;

namespace SMECommerce.Services
{
    public class BrandService:Service<Brand>,IBrandService
    {
        IBrandRepository _brandRepository;
        public BrandService(IBrandRepository brandRepository):base(brandRepository)
        {
            _brandRepository = brandRepository;
        }
    }
}
