using SMEcommerce.Repositories.Abstractions;
using SMECommerce.Services.Abstractions;
using System.Collections.Generic;

namespace SMECommerce.Services
{
    public abstract class Service<T> : IService<T> where T : class
    {
        IRepositories<T> _repository;
        public Service(IRepositories<T> repository)
        {
            _repository = repository;
        }
        public virtual bool Add(T entity)
        {
            return _repository.Add(entity);
        }

        public virtual ICollection<T> GetAll()
        {
            return _repository.GetAll();
        }

        public virtual T GetById(int id)
        {
            return _repository.GetById(id);
        }

        public virtual bool Remove(T entity)
        {
            return _repository.Remove(entity);
        }

        public virtual bool Update(T entity)
        {
            return _repository.Update(entity);
        }
    }
}
