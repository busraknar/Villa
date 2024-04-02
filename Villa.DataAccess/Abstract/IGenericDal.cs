using MongoDB.Bson;
using System.Linq.Expressions;

namespace Villa.DataAccess.Abstract
{
    public interface IGenericDal<T> where T : class
    {
        Task CreateAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(ObjectId id);   //MongoDb.json dan 
        Task<List<T>> GetListAsync();
        Task<T> GetByIdAsync(ObjectId id);
        Task<int> CountAsync();
        Task<List<T>> GelFilteredListAsync(
            Expression<Func<T, bool>> predicate);  //T türünde sorgu, true false dönecek
    }
}
