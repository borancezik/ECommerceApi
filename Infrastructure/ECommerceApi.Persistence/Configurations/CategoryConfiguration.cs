using ECommerceApi.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ECommerceApi.Persistence.Configurations;

public class CategoryConfiguration : IEntityTypeConfiguration<CategoryEntity>
{
    public void Configure(EntityTypeBuilder<CategoryEntity> builder)
    {
        CategoryEntity category1 = new()
        {
            Id = 1,
            Name = "Elektronik",
            ParentId = 0,
            Priorty = 1,
            IsDeleted = false,
            CreatedDate = DateTime.Now,
        };

        CategoryEntity category2 = new()
        {
            Id = 2,
            Name = "Moda",
            ParentId = 0,
            Priorty = 2,
            IsDeleted = false,
            CreatedDate = DateTime.Now,
        };

        CategoryEntity parent1 = new()
        {
            Id = 3,
            Name = "Bilgisayar",
            ParentId = 1,
            Priorty = 1,
            IsDeleted = false,
            CreatedDate = DateTime.Now,
        };

        CategoryEntity parent2 = new()
        {
            Id = 4,
            Name = "Kadın",
            ParentId = 2,
            Priorty = 1,
            IsDeleted = false,
            CreatedDate = DateTime.Now,
        };

        builder.HasData(category1, category2, parent1, parent2);
    }
}
