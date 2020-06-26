using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace <NAMESPACE>
{
    public class ExampleService
    {
        private UnitOfWork uow = new UnitOfWork();
        private GenericRepository<TABLE> repo;

        public ExampleService() {
            pageRepo = uow.GenericRepository<TABLE>();
        }

        public List<TABLE> GetAll()
        {
            return repo.GetAll().ToList();
        }

        public TABLE GetById(int id
        {
            return repo.GetById(id);
        }
    }
}
