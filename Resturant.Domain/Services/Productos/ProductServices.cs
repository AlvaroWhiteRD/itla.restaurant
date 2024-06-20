using Resturant.Domain.Entities;
using Resturant.Domain.Extensions;
using Resturant.Domain.Extentions;
using Resturant.Domain.Interfaces.Products;
using Resturant.Domain.Models;

namespace Resturant.Domain.Services.Productos;

public class ProductServices
{
    private readonly IProduct _repository;

    public ProductServices(IProduct repository)
    {
        _repository = repository;
    }

    public IQueryable<Producto> Get()
    {
        var category = _repository.Search(u => u.Active);
        return category;
    }

    public async Task<ProductoAddModel> Get(int id)
    {
        Producto product = await _repository.GetById(id);

        ProductoAddModel productRevert = product.ToRevert();
        return productRevert;
    }

    public async Task<bool> Create(ProductoAddModel product)
    {
        try
        {
            Producto producto = product.ToProduct();
            await _repository.Add(producto);
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
    public async Task<bool> Update(ProductoAddModel product)
    {
        try
        {
            Producto producto = product.ToProduct();

            await _repository.Update(producto);

            await _repository.SaveChangesAsync();
            return true;
        }
        catch
        {
            return false;
        }
    }
}
