﻿using MagicVilla_VillaAPI.Models;
using System.Linq.Expressions;

namespace MagicVilla_VillaAPI.Repository.IRepository
{
    public interface IVillaRepository
    {
        Task<Villa> Get(Expression<Func<Villa, bool>> filter = null, bool tracked = true);
        Task<List<Villa>> GetAll(Expression<Func<Villa, bool>> filter = null);
        Task Create(Villa entity);
        Task Remove(Villa entity);
        Task Save();
    }
}
