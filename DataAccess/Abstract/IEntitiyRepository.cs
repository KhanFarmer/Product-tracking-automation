using Entities.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IEntitiyRepository<T> where T : class,IEntitiy,new()
    {
        T Get(int id);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        List<T> GetAll();
        List<T> GetAllByCategories(int categoryId);
       
    }
}
    