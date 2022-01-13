using SMEcommerce.Models.EntityModels;
using SMEcommerce.Repositories.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace SMEcommerce.Repositories
{
    // usually we mainly send the data in database. But the information of this class will be stored or maintained in the cloud.
    public class PremiumCategoryRepository : IPremiumCategoryRepository
    {
        public bool Add(Category category)
        {
            return true;
        }

        public ICollection<Category> GetAll()
        {
            return null;
        }

        public Category GetId(int id)
        {
            return null;
        }

        public bool Remove(Category category)
        {
            return true;
        }

        public bool Update(Category category)
        {
            return true;
        }
    }
}
