using Bogus;
using ECommerceApi.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ECommerceApi.Persistence.Configurations;

public class ProductConfiguration : IEntityTypeConfiguration<ProductEntity>
{
    public void Configure(EntityTypeBuilder<ProductEntity> builder)
    {
        Faker faker = new ("tr");

        ProductEntity product1 = new()
        {
            Id = 1,
            Title = faker.Commerce.ProductName(),
            Description = faker.Commerce.ProductDescription(),
            BrandId = 1,
            Discount = faker.Random.Decimal(0, 10),
            Price = faker.Finance.Amount(10, 1000),
            CreatedDate = DateTime.Now,
            IsDeleted = false,  
        };

        ProductEntity product2 = new()
        {
            Id = 2,
            Title = faker.Commerce.ProductName(),
            Description = faker.Commerce.ProductDescription(),
            BrandId = 1,
            Discount = faker.Random.Decimal(0, 10),
            Price = faker.Finance.Amount(10, 1000),
            CreatedDate = DateTime.Now,
            IsDeleted = false,
        };

        builder.HasData(product1, product2);    
    }
}
