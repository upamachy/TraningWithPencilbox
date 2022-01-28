using Microsoft.EntityFrameworkCore;
using SMEcommerce.Databases.DbContexts;
using SMEcommerce.Models.EntityModels;
using SMEcommerce.Repositories;
using SMEcommerce.Repositories.Abstractions;
using System.Collections.Generic;
using System.Linq;

namespace SMECommerce.Repositories
{
    public class ProductRepository:Repository<Item>, IProductRepository
    {
        SMEcommerceDbcontext db;
        public ProductRepository(SMEcommerceDbcontext db):base(db)
        {
            this.db = db;
        }

      
        public override Item GetById(int id)
        {
            var item = db.Products.FirstOrDefault(c => c.Id == id);
            return item;
        }

        public override ICollection<Item> GetAll()
        {
            var items = db.Products.Include(c => c.Category).ToList();
            return items;
        }




        public bool Save()
        {
            return db.SaveChanges() > 0;
        }




    }
}