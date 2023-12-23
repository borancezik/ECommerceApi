using ECommerceApi.Domain.Common;

namespace ECommerceApi.Domain.Entities;

public class BrandEntity : BaseEntity
{
    public BrandEntity()
    {
        
    }

    public BrandEntity(string name)
    {
        Name = name;
    }
    public required string Name { get; set; }
}
