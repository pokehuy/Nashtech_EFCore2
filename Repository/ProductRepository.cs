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
            var transaction = _dbcontext.Database.BeginTransaction();
            try {
                _dbcontext.Products.Add(product);
                _dbcontext.SaveChanges();
                transaction.Commit();
            } catch (Exception e) {
                
            }
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
            var transaction = _dbcontext.Database.BeginTransaction();
            try {
                var pro = _dbcontext.Products.FirstOrDefault(p => p.ProductId == id);
                if(pro != null){
                    _dbcontext.Products.Remove(pro);
                    _dbcontext.SaveChanges();
                }
                transaction.Commit();
            } catch (Exception e) {
                
            }
        }

        public void Add(List<ProductCategoryModel> list){
            var transaction = _dbcontext.Database.BeginTransaction();
            try {
                list.ForEach(pc => {
                    _dbcontext.Categories.Add(pc.Category);
                    _dbcontext.Products.Add(pc.Product);
                    _dbcontext.SaveChanges();
                });
                transaction.Commit();
            } catch (Exception e) {
                
            }
        }
    }
}