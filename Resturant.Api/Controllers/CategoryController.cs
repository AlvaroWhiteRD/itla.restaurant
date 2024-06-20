using Microsoft.AspNetCore.Mvc;
using Resturant.Domain.DTO.Response;
using Resturant.Domain.Interfaces.Categorys;
using Resturant.Domain.Models;
using Resturant.Domain.Services.Categorias;

namespace Resturant.Api.Controllers;

public class CategoryController : Controller
{

    private readonly CategoriaServices _services;
    public CategoryController(ICategory category)
    {
        _services = new CategoriaServices(category);
    }
    [HttpGet]
    public ActionResult Index()
    {
        var categorys = _services.Get().ToList();
        return View(categorys);
    }

    [HttpPost]
    public async Task<ActionResult> Create(CategoryAddModel category)
    {
        if (category is null)
            return NoContent();

        var viewModel = new ResponseDTO();

        viewModel.Success = await _services.Create(category);

        viewModel.Message = viewModel.Success ? "Datos creados" : null;

        TempData["Message"] = viewModel.Message;
        TempData["Error"] = viewModel.Success ? null : "Ocurrio un error";

        return Redirect(nameof(Index));
    }


    [HttpPost]
    public async Task<ActionResult> Update(CategoryAddModel category)
    {
        var viewModel = new ResponseDTO();

        viewModel.Success = await _services.Update(category);

        viewModel.Message = viewModel.Success ? "Datos Actualizados" : null;

        TempData["Message"] = viewModel.Message;
        TempData["Error"] = viewModel.Success ? null : "Ocurrio un error";

        return Redirect(nameof(Index));
    }

    [HttpGet]
    public async Task<ActionResult> Edit(int id)
    {
        CategoryAddModel category = await _services.Get(id);
        return View(category);
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
