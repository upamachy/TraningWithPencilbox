using Microsoft.EntityFrameworkCore;
using SMEcommerce.Repositories.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SMEcommerce.Repositories
{
    public abstract class Repository<T> : IRepositories<T> where T : class
    {
        DbContext _db;
        public Repository(DbContext db)
        {
            _db = db;
        }

        public virtual DbSet<T> Table {
            get
            {
                return _db.Set<T>();
            }
        }

        public virtual bool Add(T entity)
        {
            _db.Add(entity);
            return _db.SaveChanges() > 0;
        }

        public virtual ICollection<T> GetAll()
        {
            
            return Table.ToList();
        }

        public abstract T GetById(int id);

        public virtual bool Remove(T entity)
        {
            _db.Remove(entity);
            return _db.SaveChanges() > 0;
        }

        public virtual bool Update(T entity)
        {
            _db.Update(entity);
            return _db.SaveChanges() > 0;
        }
    }
}
