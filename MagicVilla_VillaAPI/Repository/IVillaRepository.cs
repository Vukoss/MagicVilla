using System;
using System.Linq.Expressions;
using MagicVilla_VillaAPI.Models;

namespace MagicVilla_VillaAPI.Repository
{
	public interface IVillaRepository
	{
		Task<List<Villa>> GetAll(Expression<Func<Villa, bool>> filter = null);
        Task<Villa> Get(Expression<Func<Villa, bool>> filter = null, bool tracked = true);
        Task Create(Villa entity);
		Task Remove(Villa entity);
		Task Save();
	}
}

