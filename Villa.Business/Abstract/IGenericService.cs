﻿using MongoDB.Bson;
using System.Linq.Expressions;

namespace Villa.Business.Abstract
{
    public interface IGenericService<T> where T : class
    {
        Task TCreateAsync(T entity);
        Task TUpdateAsync(T entity);
        Task TDeleteAsync(ObjectId id);   //MongoDb.json dan 
        Task<List<T>> TGetListAsync();
        Task<T> TGetByIdAsync(ObjectId id);
        Task<int> TCountAsync();
        Task<List<T>> TGelFilteredListAsync(
            Expression<Func<T, bool>> predicate);
    }
}
