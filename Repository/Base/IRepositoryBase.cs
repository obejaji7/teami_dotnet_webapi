using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Repository.Base
{
    public interface IRepositoryBase<Entity>
    {
        IEnumerable<Entity> GetAll();
        IEnumerable<Entity> GetBy(Expression<Func<Entity, bool>> expression);
        void Add(Entity entity);
        void Edit(Entity entity);
        void Delete(Entity entity);
    }
}
