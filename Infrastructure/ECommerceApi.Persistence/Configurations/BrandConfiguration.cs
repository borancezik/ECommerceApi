using Bogus;
using ECommerceApi.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ECommerceApi.Persistence.Configurations;

public class BrandConfiguration : IEntityTypeConfiguration<BrandEntity>
{
    public void Configure(EntityTypeBuilder<BrandEntity> builder)
    {
        builder.Property(x => x.Name).HasMaxLength(256);

        Faker faker = new("tr");

        BrandEntity brand1 = new()
        {
            Id = 1,
            Name = faker.Commerce.Department(),
            CreatedDate = DateTime.Now,
            IsDeleted = false,
        };

        BrandEntity brand2 = new()
        {
            Id = 2,
            Name = faker.Commerce.Department(),
            CreatedDate = DateTime.Now,
            IsDeleted = false,
        };

        BrandEntity brand3 = new()
        {
            Id = 3,
            Name = faker.Commerce.Department(),
            CreatedDate = DateTime.Now,
            IsDeleted = true,
        };

        builder.HasData(brand1, brand2, brand3);
    }
}
