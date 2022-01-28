using SMEcommerce.Databases.DbContexts;
using SMEcommerce.Models.EntityModels;
using SMEcommerce.Repositories.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMEcommerce.Repositories
{
    public class BrandRepositories : Repository<Brand>, IBrandRepository
    {
        SMEcommerceDbcontext _db;
        public BrandRepositories(SMEcommerceDbcontext db):base(db)
        {
            _db = db;
        }
        public override Brand GetById(int id)
        {
            return _db.Brands.FirstOrDefault(c => c.Id == id);
        }
    }
}
