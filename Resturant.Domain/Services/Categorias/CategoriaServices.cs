using Resturant.Domain.Entities;
using Resturant.Domain.Interfaces.Categorys;
using Resturant.Domain.Models;
using Resturant.Domain.Extentions;

namespace Resturant.Domain.Services.Categorias;

public class CategoriaServices
{
    private readonly ICategory _repository;

    public CategoriaServices(ICategory repository)
    {
        _repository = repository;
    }

    public IQueryable<Categoria> Get()
    {
        var category = _repository.Search(u=>u.Active);
        return category;
    }

    public async Task<CategoryAddModel> Get(int id)
    {
        Categoria category = await _repository.GetById(id);

        CategoryAddModel cateryRevert = category.ToRevert();
        return cateryRevert;
    }

    public async Task<bool> Create(CategoryAddModel category)
    {
        try
        {
            Categoria categoria = category.ToCategory();
            await _repository.Add(categoria);
            await _repository.SaveChangesAsync();
            return true;
        }
        catch
        {
            return false;
        }
    }
    public async Task<bool> Delete(int id)
    {
        try
        {
            await _repository.MarkDeleted(id);
            await _repository.SaveChangesAsync();
            return true;
        }
        catch
        {
            return false;
        }
    }
    public async Task<bool> Update(CategoryAddModel category)
    {
        try
        {
            Categoria categoria = category.ToCategory();

            await _repository.Update(categoria);

            await _repository.SaveChangesAsync();
            return true;
        }
        catch
        {
            return false;
        }
    }


}
