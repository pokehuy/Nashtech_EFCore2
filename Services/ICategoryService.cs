using efcore2.Models;

namespace efcore2.Services
{
    public interface ICategoryService
    {
        List<CategoryModel> GetAll();

        public CategoryModel Get(int id);

        public void Create(CategoryModel category);

        public void Update(int id, CategoryModel category);

        public void Delete(int id);
    }
}