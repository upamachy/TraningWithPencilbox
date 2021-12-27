using Day_7.Database;
using Day_7.Models.EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_7.Repositories
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
