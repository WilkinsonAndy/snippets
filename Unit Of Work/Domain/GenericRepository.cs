using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace <NAMESPACE>
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private <ENTITIES> _context;
        private IDbSet<T> _dbSet;

        public GenericRepository<ENTITIES> context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }

        public void Delete(int id)
        {
            T existing = _dbSet.Find(id);
            _dbSet.Remove(existing);
        }

        public IEnumerable<T> GetAll()
        {
            return _dbSet.AsEnumerable();
        }

        public T GetById(int id)
        {
            return _dbSet.Find(id);
        }

        public void Insert(T obj)
        {
            _dbSet.Add(obj);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public IEnumerable<T> Search(Expression<System.Func<T, bool>> exp)
        {
            return _dbSet.Where(exp);
        }

        public void Update(T obj)
        {
            _dbSet.Attach(obj);
            _context.Entry(obj).State = EntityState.Modified;
        }
    }
}
