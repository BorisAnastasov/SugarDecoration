﻿using Microsoft.EntityFrameworkCore;

namespace SugarDecoration.Infrastructure.Data.Contracts
{
	public class Repository : IRepository
	{
		private readonly DbContext _context;

        public Repository(SugarDecorationDb context)
        {
            _context = context;
        }
		private DbSet<T> DbSet<T>() where T : class
		{
			return _context.Set<T>();
		}
        public IQueryable<T> All<T>() where T : class
		{
			return DbSet<T>();
		}

		public IQueryable<T> AllReadOnly<T>() where T : class
		{
			return DbSet<T>()
						.AsNoTracking();
		}
	}
}
