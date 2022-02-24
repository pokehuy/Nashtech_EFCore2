using Microsoft.AspNetCore.Mvc;
using efcore2.Models;
using efcore2.Services;

namespace efcore2.Controllers;

[ApiController]
[Route("[controller]")]
public class ProductController : ControllerBase
{
    private IProductService _iproductservice;
    private readonly ILogger<ProductController> _logger;

    public ProductController(ILogger<ProductController> logger, IProductService iproductservice)
    {
        _logger = logger;
        _iproductservice = iproductservice;
    }

    [HttpGet("Products")]
    public List<ProductModel> GetAll(){
        return _iproductservice.GetAll();
    }
    [HttpGet]
    public ProductModel Get(int id){
        return _iproductservice.Get(id);
    }
    [HttpPost]
    public void Create(ProductModel product){
        _iproductservice.Create(product);
    }
    [HttpPut]
    public void Update(int id, ProductModel product){
        _iproductservice.Update(id, product);
    }
    [HttpDelete]
    public void Delete(int id){
        _iproductservice.Delete(id);
    }

    // id co thuoc tinh key => khong nhap nhung id bi xoa
    [HttpPost("ProductCategory")]
    public void Add(List<ProductCategoryModel> list){
        _iproductservice.Add(list);
    }
}
