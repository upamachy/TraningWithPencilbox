using Microsoft.EntityFrameworkCore;
using SMEcommerce.Databases.DbContexts;
using SMEcommerce.Models.EntityModels;
using SMEcommerce.Repositories.Abstractions;
using System.Collections.Generic;
using System.Linq;

namespace SMEcommerce.Repositories
{
    public class CategoryRepositories:Repository<Category>, ICategoryRepository
    {

        SMEcommerceDbcontext db;
        public CategoryRepositories(SMEcommerceDbcontext db) : base(db)
        {
            this.db = db;
        }

        public override Category GetById(int id)
        {
            return db.Categories.FirstOrDefault(c => c.Id == id);
        }

        public override ICollection<Category> GetAll()
        {
            return db.Categories.Include(c => c.Items).ToList();
        }

        public Category CategoryName(int id)
        {
            return db.Categories.FirstOrDefault(c => c.Id == id);

        }

        public ICollection<Category> GetTopCategory()
        {
            throw new System.NotImplementedException();
        }

        
    }
}
