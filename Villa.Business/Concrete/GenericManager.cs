﻿using MongoDB.Bson;
using System.Linq.Expressions;
using Villa.Business.Abstract;
using Villa.DataAccess.Abstract;

namespace Villa.Business.Concrete
{
    public class GenericManager<T> : IGenericService<T> where T : class
    {
        private readonly IGenericDal<T> _genericDal;

        public GenericManager(IGenericDal<T> genericDal)
        {
            _genericDal = genericDal;
        }

        public async Task<int> TCountAsync()
        {
            return await _genericDal.CountAsync();
        }

        public async Task TCreateAsync(T entity)
        {
            await _genericDal.CreateAsync(entity);
        }

        public async Task TDeleteAsync(ObjectId id)
        {
            await _genericDal.DeleteAsync(id);
        }

        public async Task<List<T>> TGelFilteredListAsync(Expression<Func<T, bool>> predicate)
        {
            return await _genericDal.GelFilteredListAsync(predicate);
        }

        public async Task<T> TGetByIdAsync(ObjectId id)
        {
            return await _genericDal.GetByIdAsync(id);
        }

        public async Task<List<T>> TGetListAsync()
        {
            return await _genericDal.GetListAsync();
        }

        public async Task TUpdateAsync(T entity)
        {
            await _genericDal.UpdateAsync(entity);
        }
    }
}
