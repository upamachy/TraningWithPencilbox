using System;
using System.Collections.Generic;
using System.Text;

namespace SMECommerce.Services.Abstractions
{
    public interface IService<T> where T:class
    {
        bool Add(T entity);
        bool Update(T entity);
        bool Remove(T entity);
        T GetById(int id);
        ICollection<T> GetAll();
        
    }
}
