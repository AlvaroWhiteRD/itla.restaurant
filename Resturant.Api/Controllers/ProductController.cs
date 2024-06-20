using Microsoft.AspNetCore.Mvc;
using Resturant.Domain.DTO.Response;
using Resturant.Domain.Interfaces.Products;
using Resturant.Domain.Models;
using Resturant.Domain.Services.Productos;

namespace Resturant.Api.Controllers;

public class ProductController : Controller
{
    private readonly ProductServices _services;
    public ProductController(IProduct product)
    {
        _services = new ProductServices(product);
    }
    [HttpGet]
    public ActionResult Index()
    {
        var products = _services.Get().ToList();
        return View(products);
    }

    [HttpPost]
    public async Task<ActionResult> Create(ProductoAddModel product)
    {
        if (product is null) 
            return NoContent();

        var viewModel = new ResponseDTO();

        viewModel.Success = await _services.Create(product);

        viewModel.Message = viewModel.Success ? "Datos creados" : null;

        TempData["Message"] = viewModel.Message;
        TempData["Error"] = viewModel.Success ? null : "Ocurrio un error";

        return Redirect(nameof(Index));
    }


    [HttpPost]
    public async Task<ActionResult> Update(ProductoAddModel product)
    {
        var viewModel = new ResponseDTO();

        viewModel.Success = await _services.Update(product);

        viewModel.Message = viewModel.Success ? "Datos Actualizados" : null;

        TempData["Message"] = viewModel.Message;
        TempData["Error"] = viewModel.Success ? null : "Ocurrio un error";

        return Redirect(nameof(Index));
    }

    [HttpGet]
    public async Task<ActionResult> Edit(int id)
    {
        ProductoAddModel product = await _services.Get(id);
        return View(product);
    }


    [HttpGet]
    public async Task<ActionResult> Delete(int id)
    {
        await _services.Delete(id);
        return RedirectToAction(nameof(Index));
    }

    [HttpGet]
    public ActionResult New()
    {
        return View();
    }
}
