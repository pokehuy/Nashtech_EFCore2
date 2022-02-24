using efcore2.Repository;
using efcore2.Models;

namespace efcore2.Services
{
    public class CategoryService : ICategoryService
    {
        private ICategoryRepository _icategoryrepo;
        public CategoryService(ICategoryRepository icategoryrepo)
        {
            _icategoryrepo = icategoryrepo;
        }

        public List<CategoryModel> GetAll(){
            return _icategoryrepo.GetAll();
        }

        public CategoryModel Get(int id){
            return _icategoryrepo.Get(id);
        }

        public void Create(CategoryModel category){
            _icategoryrepo.Create(category);
        }

        public void Update(int id, CategoryModel category){
            _icategoryrepo.Update(id, category);
        }

        public void Delete(int id){
            _icategoryrepo.Delete(id);
        }
    }
}