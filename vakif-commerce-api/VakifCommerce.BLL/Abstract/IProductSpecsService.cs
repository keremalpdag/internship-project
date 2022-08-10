using VakifCommerce.Entities.Concrete;

namespace VakifCommerce.BLL.Abstract
{
    public interface IProductSpecsService
    {
        ProductSpecs GetById(int productId);
        List<ProductSpecs> GetList();
        void Add(ProductSpecs product);
        void Update(ProductSpecs product);
        void Delete(ProductSpecs product);
    }
}
