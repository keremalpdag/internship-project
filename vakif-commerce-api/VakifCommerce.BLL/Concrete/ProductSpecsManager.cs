using VakifCommerce.BLL.Abstract;
using VakifCommerce.DAL.Abstract;
using VakifCommerce.Entities.Concrete;

namespace VakifCommerce.BLL.Concrete
{
    public class ProductSpecsManager : IProductSpecsService
    {
        private readonly IProductSpecsDAL _productServiceDAL;

        public ProductSpecsManager(IProductSpecsDAL productServiceDAL)
        {
            _productServiceDAL = productServiceDAL;
        }

        public void Add(ProductSpecs prodSpecs)
        {
            _productServiceDAL.Add(prodSpecs);
        }

        public void Delete(ProductSpecs prodSpecs)
        {
            _productServiceDAL?.Delete(prodSpecs);
        }

        public ProductSpecs GetById(int productSpecsId)
        {
            return _productServiceDAL.Get(p => p.ProductSpecsId == productSpecsId);
        }

        public List<ProductSpecs> GetList()
        {
            return _productServiceDAL.GetList();
        }

        public void Update(ProductSpecs product)
        {
            _productServiceDAL.Update(product);
        }
    }
}
