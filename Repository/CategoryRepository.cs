using efcore2.Models;

namespace efcore2.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        private ApplicationDbContext _dbcontext;
        public CategoryRepository(ApplicationDbContext dbContext)
        {
            _dbcontext = dbContext;
        }

        public List<CategoryModel> GetAll(){
            return _dbcontext.Categories.ToList();
        }
        public CategoryModel Get(int id){
            return _dbcontext.Categories.FirstOrDefault(c => c.CategoryId == id);
        }
        public void Create(CategoryModel category){
            var transaction = _dbcontext.Database.BeginTransaction();
            try {
                _dbcontext.Categories.Add(category);
                _dbcontext.SaveChanges();
                transaction.Commit();
            } catch (Exception e) {
                
            }
        }
        public void Update(int id, CategoryModel category){
            var transaction = _dbcontext.Database.BeginTransaction();
            try {
                var ctg = _dbcontext.Categories.FirstOrDefault(c => c.CategoryId == id);
                if(ctg != null){
                    ctg.CategoryName = category.CategoryName;
                }
                _dbcontext.SaveChanges();
                transaction.Commit();
            } catch (Exception e) {
                
            }
        }
        public void Delete(int id){
            var transaction = _dbcontext.Database.BeginTransaction();
            try {
                var ctg = _dbcontext.Categories.FirstOrDefault(c => c.CategoryId == id);
                if(ctg != null){
                    _dbcontext.Categories.Remove(ctg);
                    _dbcontext.SaveChanges();
                }
                transaction.Commit();
            } catch (Exception e) {
                
            }
        }
    }
}