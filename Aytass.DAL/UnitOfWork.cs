using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aytass.DAL.Repository;
using Aytass.Entity;

namespace Aytass.DAL
{
    public class UnitOfWork : IDisposable
    {

        private CategoryRepository _categoryRepository;

        private readonly AytassCMSEntities _entities;

        public UnitOfWork()
        {
            _entities = new AytassCMSEntities();;
        }

        public CategoryRepository CategoryRepository
        {
            get
            {
                if(_categoryRepository == null)
                    _categoryRepository = new CategoryRepository(_entities);

                return _categoryRepository;
            }
        }


        public int Save()
        {
           return  _entities.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _entities.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

    }
}
