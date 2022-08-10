using Core.Entities;

namespace VakifCommerce.Entities.Concrete
{
    public class Category : IEntity
    {
        public int CategoryId { get; set; }
        public string? CategoryName { get; set; }
        public string? CategoryImgPath { get; set; }
    }
}
