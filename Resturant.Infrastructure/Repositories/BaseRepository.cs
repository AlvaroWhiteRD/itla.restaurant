namespace Resturant.Infrastructure.Repositories;

using Microsoft.EntityFrameworkCore;
using Resturant.Domain.Interfaces;
using Resturant.Infrastructure.Context;
using System.Linq.Expressions;


public  class BaseRepository<T> : IBaseRepository<T> where T : class
{
    protected readonly DbSet<T> dbSet;
    private readonly RestaurantContext Context;

    public BaseRepository(RestaurantContext Context)
    {
        dbSet = Context.Set<T>();
        this.Context = Context;
    }
    public async Task Add(T entity)
    {
        await dbSet.AddAsync(entity);
    }

    public async Task Delete(int id)
    {
        T entity = await GetById(id);
        dbSet.Remove(entity);
    }

    public IQueryable<T> GetAll()
    {
        return dbSet.AsNoTracking().AsQueryable();
    }

    public async Task<T> GetById(int id)
    {
        return await dbSet.FindAsync(id);
    }

    public IQueryable<T> Search(Expression<Func<T, bool>> query)
    {
        return dbSet.AsNoTracking().AsQueryable().Where(query);
    }

    public async Task Update(T entity)
    {
        dbSet.Update(entity);
    }

    public async Task MarkDeleted(int id, string UpdatedUser = "default")
    {
        T entity = await GetById(id);

        if (entity is null)
        {
            return;
        }

        dynamic dynamicEntity = entity;
        dynamicEntity.Active = false;
        dynamicEntity.Deleted = true;
        dynamicEntity.UpdatedUser = UpdatedUser;
        dynamicEntity.UpdatedDate = DateTime.Now;

        await Update(entity);
    }


    public async Task SaveChangesAsync()
    {
        await Context.SaveChangesAsync();
    }
}
