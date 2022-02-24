using efcore2.Models;

namespace efcore2.Repository
{
    public interface ICategoryRepository
    {
        List<CategoryModel> GetAll();
        CategoryModel Get(int id);
        void Create(CategoryModel category);
        void Update(int id, CategoryModel category);
        void Delete(int id);
    }
}