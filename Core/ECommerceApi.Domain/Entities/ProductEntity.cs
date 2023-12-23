using ECommerceApi.Domain.Common;

namespace ECommerceApi.Domain.Entities;

public class ProductEntity : BaseEntity
{
    public required string Title { get; set; }
    public required string Description { get; set; }
    public required int BrandId { get; set; }
    public required decimal Price { get; set; }
    public required decimal Discount { get; set; }

    public BrandEntity Brand { get; set; }
    public ICollection<CategoryEntity> Categories { get; set; }

    //public required string ImagePath { get; set; }
}
