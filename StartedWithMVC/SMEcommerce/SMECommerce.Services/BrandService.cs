using SMEcommerce.Models.EntityModels;
using SMEcommerce.Repositories.Abstractions;
using SMECommerce.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

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
