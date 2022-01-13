using Microsoft.EntityFrameworkCore;
using SMEcommerce.Databases.DbContexts;
using SMEcommerce.Models.EntityModels;
using SMEcommerce.Repositories.Abstractions;
using System.Collections.Generic;
using System.Linq;

namespace SMECommerce.Repositories
{
    public class ProductRepository:IProductRepository
    {
        SMEcommerceDbcontext db;
        public ProductRepository(SMEcommerceDbcontext db)
        {
            this.db = db;
        }

        public bool Add(Item item)
        {
            db.Products.Add(item);
            return Save();

        }

        public bool Update(Item item)
        {
            db.Products.Update(item);
            return Save();
        }

        public bool Remove(Item item)
        {
            db.Products.Remove(item);
            return Save();
        }

        public Item GetById(int id)
        {
            var item = db.Products.FirstOrDefault(c => c.Id == id);
            return item;
        }

        public ICollection<Item> GetAll()
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