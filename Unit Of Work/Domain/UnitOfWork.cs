using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace <NAMEPACE>
{
    public class UnitOfWork : IDisposable
    {
        private readonly <ENTITIES> context;
        private Dictionary<string, object> repositories;

        public UnitOfWork()
        {
            context = new <ENTITIES>();
        }

        public UnitOfWork(<ENTITIES> ctx)
        {
            context = ctx;
        }

        public void Dispose()
        {
            context.Dispose();
        }

        public void Save()
        {
            context.SaveChanges();
        }

        public GenericRepository<T> GenericRepository<T>() where T : class
        {
            if (repositories == null)
                repositories = new Dictionary<string, object>();

            var type = typeof(T).Name;

            if (!repositories.ContainsKey(type))
            {
                var repoType = typeof(GenericRepository<>);
                var repoInst = Activator.CreateInstance(repoType.MakeGenericType(typeof(T)), context);
                repositories.Add(type, repoInst);
            }
            return (GenericRepository<T>)repositories[type];
        }
    }
}
