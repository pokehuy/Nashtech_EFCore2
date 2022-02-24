using efcore2.Repository;
using efcore2.Models;

namespace efcore2.Services
{
    public class ProductService : IProductService
    {
        private IProductRepository _iproductrepo;
        public ProductService(IProductRepository iproductrepo)
        {
            _iproductrepo = iproductrepo;
        }

        public List<ProductModel> GetAll(){
            return _iproductrepo.GetAll();
        }

        public ProductModel Get(int id){
            return _iproductrepo.Get(id);
        }

        public void Create(ProductModel product){
            _iproductrepo.Create(product);
        }

        public void Update(int id, ProductModel product){
            _iproductrepo.Update(id, product);
        }

        public void Delete(int id){
            _iproductrepo.Delete(id);
        }

        public void Add(List<ProductCategoryModel> list){
            _iproductrepo.Add(list);
        }
    }
}