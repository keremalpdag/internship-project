using Core.Entities;

namespace VakifCommerce.Entities.Concrete
{
    public  class Product : IEntity
    {
        public int ProductId { get; set; }
        public int Category_CategoryId { get; set; }
        public string? ProductName { get; set; }
        public string? ProductDescription { get; set; }
        public string? ProductImgPath { get; set; }
        public int? ProductPrice { get; set; }
        public bool? ProductInStock { get; set; }
    }
}
