﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LIA.Data.Services
{
    public interface IDbWriter
    {
		  Task<bool> AddAsync<TEntity>(TEntity item) where TEntity : class;

	}
}