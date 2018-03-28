﻿using LIA.Data.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LIA.Data.Services
{
	public class DbWriter : IDbWriter
	{
		private VideoContext _db;
		public DbWriter(VideoContext db)
		{
			_db = db;
		}

		
		public async Task<bool> AddAsync<TEntity>(TEntity item) where TEntity : class
		{
			await _db.AddAsync<TEntity>(item);
			return await _db.SaveChangesAsync() > 0;
		}
	}
}
