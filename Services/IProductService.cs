using efcore2.Models;

namespace efcore2.Services
{
    public interface IProductService
    {
        List<ProductModel> GetAll();

        ProductModel Get(int id);

        void Create(ProductModel product);

        void Update(int id, ProductModel product);

        void Delete(int id);
    }
}