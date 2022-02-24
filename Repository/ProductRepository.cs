using efcore2.Models;

namespace efcore2.Repository
{
    public class ProductRepository : IProductRepository
    {
        private ApplicationDbContext _dbcontext;
        public ProductRepository(ApplicationDbContext dbContext)
        {
            _dbcontext = dbContext;
        }

        public List<ProductModel> GetAll(){
            return _dbcontext.Products.ToList();
        }
        public ProductModel Get(int id){
            return _dbcontext.Products.FirstOrDefault(p => p.ProductId == id);
        }
        public void Create(ProductModel product){
            _dbcontext.Products.Add(product);
            _dbcontext.SaveChanges();
        }
        public void Update(int id, ProductModel product){
            var transaction = _dbcontext.Database.BeginTransaction();
            try {
                var pro = _dbcontext.Products.FirstOrDefault(p => p.ProductId == id);
                if(pro != null){
                    pro.ProductName = product.ProductName;
                    pro.Manufacture = product.Manufacture;
                    pro.CategoryId = product.CategoryId;
                }
                _dbcontext.SaveChanges();
                transaction.Commit();
            } catch (Exception e) {
                
            }
        }
        public void Delete(int id){
            var pro = _dbcontext.Products.FirstOrDefault(p => p.ProductId == id);
            if(pro != null){
                _dbcontext.Products.Remove(pro);
                _dbcontext.SaveChanges();
            }
        }
    }
}