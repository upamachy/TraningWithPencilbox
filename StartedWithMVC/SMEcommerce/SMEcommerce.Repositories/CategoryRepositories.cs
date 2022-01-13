using Microsoft.EntityFrameworkCore;
using SMEcommerce.Databases.DbContexts;
using SMEcommerce.Models.EntityModels;
using SMEcommerce.Repositories.Abstractions;
using System.Collections.Generic;
using System.Linq;

namespace SMEcommerce.Repositories
{
    public class CategoryRepositories:ICategoryRepository
    {

        SMEcommerceDbcontext db;
        public CategoryRepositories(SMEcommerceDbcontext db)
        {
            this.db = db;
        }

        public Category GetId(int id)
        {
            return db.Categories.FirstOrDefault(c => c.Id == id);
        }

        public ICollection<Category> GetAll()
        {
            return db.Categories.Include(c => c.Items).ToList();
        }

        public bool Add(Category category)
        {
            db.Categories.Add(category);
            int successCount = db.SaveChanges();
            return successCount > 0;
        }

        public bool Update(Category category)
        {
            db.Categories.Update(category);
            return db.SaveChanges() > 0;
        }

        public bool Remove(Category category)
        {
            db.Categories.Remove(category);
            return db.SaveChanges() > 0;
        }

        public Category CategoryName(int id)
        {
            return db.Categories.FirstOrDefault(c => c.Id == id);

        }
    }
}
