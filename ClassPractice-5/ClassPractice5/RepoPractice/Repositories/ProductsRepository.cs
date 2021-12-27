using RepoPractice.Database;
using RepoPractice.Model.EntityModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepoPractice.Repositories
{
    public class ProductsRepository
    {
        ClassPractice5DbContext db;
        public ProductsRepository()
        {
            db = new ClassPractice5DbContext();
        }

        public Item GetId(int id)
        {
            return db.Products.FirstOrDefault(c => c.Id == id);
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
