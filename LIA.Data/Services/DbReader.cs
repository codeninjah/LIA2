using LIA.Data.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LIA.Data.Services
{
    public class DbReader : IDbReader
    {
        private VideoContext _db;
        public DbReader(VideoContext db)
        {
            _db = db;
        }

        public IQueryable<TEntity> Get<TEntity>() where TEntity : class
        {
            return _db.Set<TEntity>();
        }

		public async Task<TEntity> Get<TEntity>(int id) where TEntity : class
		{
			return await _db.FindAsync<TEntity>(id);
		}
    }
}
