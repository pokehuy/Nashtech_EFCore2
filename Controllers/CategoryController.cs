using Microsoft.AspNetCore.Mvc;
using efcore2.Models;
using efcore2.Services;

namespace efcore2.Controllers;

[ApiController]
[Route("[controller]")]
public class CategoryController : ControllerBase
{
    private ICategoryService _icategoryservice;
    private readonly ILogger<CategoryController> _logger;

    public CategoryController(ILogger<CategoryController> logger, ICategoryService icategoryservice)
    {
        _logger = logger;
        _icategoryservice = icategoryservice;
    }

    [HttpGet("Categories")]
    public List<CategoryModel> GetAll(){
        return _icategoryservice.GetAll();
    }

    [HttpGet]
    public CategoryModel Get(int id){
        return _icategoryservice.Get(id);
    }

    [HttpPost]
    public void Create(CategoryModel category){
        _icategoryservice.Create(category);
    }

    [HttpPut]
    public void Update(int id, CategoryModel category){
        _icategoryservice.Update(id, category);
    }

    [HttpDelete]
    public void Delete(int id){
        _icategoryservice.Delete(id);
    }

}
