using Rattis.Investments.Domain.Interfaces.Repositories.Base;
using System;
using System.Collections.Generic;

namespace Rattis.Investments.Infra.Data.Repositories.Base
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class, new()
    {
        public void Add(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntity> GetAll()
        {
            throw new NotImplementedException();
        }

        public TEntity GetById(int id)
        {
            return new TEntity();
        }

        public void Update(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
