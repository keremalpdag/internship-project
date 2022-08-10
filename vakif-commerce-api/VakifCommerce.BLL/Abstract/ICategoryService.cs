using VakifCommerce.Entities.Concrete;

namespace VakifCommerce.BLL.Abstract
{
    public interface ICategoryService
    {
        Category GetById(int categoryId);
        List<Category> GetList();
        void Add(Category category);
        void Update(Category category);
        void Delete(Category category);
    }
}
