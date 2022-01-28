using SMEcommerce.Models.EntityModels;
using SMEcommerce.Repositories.Abstractions;
using SMECommerce.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SMECommerce.Services
{
    public class ProductService : Service<Item>,IProductService
    {
        IProductRepository _productRepository;
        public ProductService(IProductRepository productRepository):base(productRepository)
        {
            _productRepository = productRepository;
        }
        public bool Add(Item item)
        {
            return _productRepository.Add(item);
        }

        public ICollection<Item> GetAll()
        {
            return _productRepository.GetAll();
        }

        public Item GetById(int id)
        {
            return _productRepository.GetById(id);
        }

        public bool Remove(Item item)
        {
            return _productRepository.Remove(item);
        }

        public bool Save()
        {
            return _productRepository.Save();
        }

        public bool Update(Item item)
        {
            return _productRepository.Update(item);
        }
    }
}
