using System;
using System.Collections.Generic;
using System.Text;

namespace Rattis.Investments.Domain.Interfaces.Repositories.Base
{
    public interface IBaseRepository<TEntity> where TEntity : class
    {
        void Add(TEntity entity);
        void Update(TEntity entity);
        TEntity GetById(object id);
        IEnumerable<TEntity> GetAll();
    }
}
