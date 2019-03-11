using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Repository.Base
{
     abstract class RepositoryBase<Entity> : IRepositoryBase<Entity> where Entity : class
    {
        private readonly RepositoryContext _context;

        public RepositoryBase(RepositoryContext context)
        {
            this._context = context;
        }

        public void Add(Entity entity)
        {
            this._context.Set<Entity>().Add(entity);
        }

        public void Delete(Entity entity)
        {
            this._context.Set<Entity>().Remove(entity);
        }

        public void Edit(Entity entity)
        {
            this._context.Set<Entity>().Update(entity);
        }

        public IEnumerable<Entity> GetBy(Expression<Func<Entity, bool>> expression)
        {
            return this._context.Set<Entity>().Where(expression);
        }

        public IEnumerable<Entity> GetAll()
        {
            return this._context.Set<Entity>();
        }
    }
}
