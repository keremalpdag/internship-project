using VakifCommerce.BLL.Abstract;
using VakifCommerce.DAL.Abstract;
using VakifCommerce.Entities.Concrete;

namespace VakifCommerce.BLL.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private readonly ICategoryDAL _categoryDAL; 

        public CategoryManager(ICategoryDAL categoryDAL) 
        {
            _categoryDAL = categoryDAL;
        }

        public void Add(Category category)
        {
            _categoryDAL.Add(category);
        }

        public void Delete(Category category)
        {
            _categoryDAL?.Delete(category);
        }

        public Category GetById(int categoryId)
        {
            return _categoryDAL.Get(c => c.CategoryId == categoryId);
        }

        public List<Category> GetList()
        {
            return _categoryDAL.GetList();
        }

        public void Update(Category category)
        {
            _categoryDAL.Update(category);
        }
    }
}
