using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LIA.Data.Services
{
    public interface IDbReader
    {
        IQueryable<TEntity> Get<TEntity>() where TEntity : class;
		Task<TEntity> Get<TEntity>(int id) where TEntity : class;

	}
}
