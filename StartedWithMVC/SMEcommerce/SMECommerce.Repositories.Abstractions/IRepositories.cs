using System;
using System.Collections.Generic;
using System.Text;

namespace SMEcommerce.Repositories.Abstractions
{
    public interface IRepositories<T> where T:class
    {
        public bool Add(T entity);
        public bool Update(T entity);
        public bool Remove(T entity);
        public ICollection<T> GetAll();
        T GetById(int id);
    }
}
