using Core.Entities;

namespace VakifCommerce.Entities.Concrete
{
    public class ProductSpecs : IEntity
    {
        public int ProductSpecsId { get; set; }
        public int Product_ProductId { get; set; }
        public string? Cpu { get; set; }
        public string? Gpu { get; set; }
        public string? Ram { get; set; }
        public string? Storage { get; set; }
        public string? ProductSize { get; set; }
        public int? ProductWeight { get; set; }
        public string? ProductColor { get; set; }
    }
}
