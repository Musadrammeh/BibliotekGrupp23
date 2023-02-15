using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using Modellager;

namespace Datalager
{
    public class Repository<TEntity>:IRepository<TEntity> where TEntity : class
    {
        private BibliotekContext _context = new BibliotekContext();

        public void Add(TEntity entity) =>_context.Add(entity);
        public TEntity GetById(object ID) => _context.Set<TEntity>().Find(ID);
        public IEnumerable<object> GetALL() => _context.Set<TEntity>().ToList();
       // public void Update(TEntity entity) =>
       public void Remove(TEntity entity) => _context.Remove(entity);

    }
}
