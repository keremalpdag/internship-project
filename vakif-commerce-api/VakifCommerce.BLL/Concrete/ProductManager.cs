using VakifCommerce.BLL.Abstract;
using VakifCommerce.DAL.Abstract;
using VakifCommerce.Entities.Concrete;

namespace VakifCommerce.BLL.Concrete
{
    public class ProductManager : IProductService
    {

        private readonly IProductDAL _productDal;

        public ProductManager(IProductDAL productDal)
        {
            _productDal = productDal;
        }

        public void Add(Product product)
        {
            _productDal.Add(product);
        }

        public void Delete(Product product)
        {
            _productDal.Delete(product);
        }

        public Product GetById(int productId)
        {
            return _productDal.Get(p => p.ProductId == productId);
        }

        public List<Product> GetList()
        {
            return _productDal.GetList();
        }

        public List<Product> GetListByCategory(int categoryId)
        {
            return _productDal.GetList(p => p.Category_CategoryId == categoryId);
        }

        public void Update(Product product)
        {
            _productDal.Update(product);
        }
    }
}
