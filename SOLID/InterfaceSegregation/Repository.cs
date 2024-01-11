using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregation
{
    public interface IRepository<T>
    {
        T Get(int id);
        IList<T> GetAll();
        void Create(T entity);


    }

    public interface ISearchable<T>
    {
        IList<T> SearchByName(string name);
    }

    public class OrderRepository : IRepository<object>
    {
        public void Create(object entity)
        {
            throw new NotImplementedException();
        }

        public object Get(int id)
        {
            throw new NotImplementedException();
        }

        public IList<object> GetAll()
        {
            throw new NotImplementedException();
        }


    }

    public class ProductRepository : IRepository<object>, ISearchable<object>
    {
        public void Create(object entity)
        {
            throw new NotImplementedException();
        }

        public object Get(int id)
        {
            throw new NotImplementedException();
        }

        public IList<object> GetAll()
        {
            throw new NotImplementedException();
        }

        public IList<object> SearchByName(string name)
        {
            throw new NotImplementedException();
        }
    }
}
