using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace <NAMESPACE>
{
    public interface IGenericRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        T GetById(int id);
        IEnumerable<T> Search(Expression<System.Func<T, bool>> exp);
        void Insert(T obj);
        void Update(T obj);
        void Delete(int id);
        void Save();
    }
}
