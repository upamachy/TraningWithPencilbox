using Microsoft.EntityFrameworkCore;
using RepoPractice.Database;
using RepoPractice.Model.EntityModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepoPractice.Repositories
{
    public class BrandsRepository
    {
        ClassPractice5DbContext db;
        public BrandsRepository()
        {
            db = new ClassPractice5DbContext();
        }

        public Brand GetId(int id)
        {
            return db.Brands.FirstOrDefault(c => c.Id == id);
        }

        public ICollection<Brand> GetAll()
        {
            return db.Brands.Include(c => c.Items).ToList();
        }

        public bool Add(Brand brand)
        {
            db.Brands.Add(brand);
            int succesCount = db.SaveChanges();
            return succesCount > 0;
        }

        public bool Add(List<Brand> brandList)
        {
            db.Brands.AddRange(brandList);
            return db.SaveChanges() > 0;
        }

        public bool Update(Brand brand)
        {
            db.Brands.Update(brand);
            return db.SaveChanges() > 0;
        }

        public bool Remove(Brand brand)
        {
            db.Brands.Remove(brand);
            return db.SaveChanges() > 0;
        }
    }
}
