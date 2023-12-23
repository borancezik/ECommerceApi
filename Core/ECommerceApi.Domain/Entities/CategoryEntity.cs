using ECommerceApi.Domain.Common;

namespace ECommerceApi.Domain.Entities;

public class CategoryEntity : BaseEntity
{
    public CategoryEntity()
    {
        
    }

    public CategoryEntity(int parentId, string name, int priorty)
    {
        ParentId = parentId;
        Name = name;
        Priorty = priorty;
    }

    public required int ParentId { get; set; }
    public required string Name { get; set; }
    public required int Priorty { get; set; }
    public ICollection<DetailEntity> Details { get; set; }
    public ICollection<ProductEntity> Products { get; set; }
}
