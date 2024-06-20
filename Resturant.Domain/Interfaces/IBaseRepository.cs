using System.Linq.Expressions;

namespace Resturant.Domain.Interfaces;

public interface IBaseRepository<T>
{
    IQueryable<T> GetAll();
    Task<T> GetById(int id);
    Task Add(T entity);
    Task Update(T entity);
    Task Delete(int id);
    Task MarkDeleted(int id, string UpdatedUser = "default");

    IQueryable<T> Search(Expression<Func<T, bool>> query);

    Task SaveChangesAsync();
}
