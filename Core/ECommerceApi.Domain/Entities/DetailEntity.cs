using ECommerceApi.Domain.Common;

namespace ECommerceApi.Domain.Entities;

public class DetailEntity : BaseEntity
{
    public DetailEntity()
    {
        
    }

    public DetailEntity(string title, string description, int categoryId)
    {
        Title = title;
        Description = description;
        CategoryId = categoryId;
    }

    public required string Title { get; set; }
    public required string Description { get; set; }
    public required int CategoryId { get; set; }
    public CategoryEntity Category { get; set; }
}
