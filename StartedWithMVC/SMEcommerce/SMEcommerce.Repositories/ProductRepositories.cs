using SMEcommerce.Databases.DbContexts;
using SMEcommerce.Models.EntityModels;
using System.Collections.Generic;
using System.Linq;

namespace SMEcommerce.Repositories
{
    public class ProductRepositories
    {
        SMEcommerceDbcontext db;
        public  ProductRepositories()
        {
            db = new SMEcommerceDbcontext();
        }

        public Item GetId(int id)
        {
            return db.Products.FirstOrDefault(c => c.Id==id);
        }

        public bool Add(Item item)
        {
            db.Products.Add(item);
            int successCount = db.SaveChanges();
            return successCount > 0;
        }

        public bool Update(Item item)
        {
            db.Products.Update(item);
            return db.SaveChanges() > 0;
        }

        public bool Remove(Item item)
        {
            db.Products.Remove(item);
            return db.SaveChanges() > 0;
        }
    }
}
