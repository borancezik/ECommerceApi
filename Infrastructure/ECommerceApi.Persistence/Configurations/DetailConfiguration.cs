using Bogus;
using ECommerceApi.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ECommerceApi.Persistence.Configurations;

public class DetailConfiguration : IEntityTypeConfiguration<DetailEntity>
{
    public void Configure(EntityTypeBuilder<DetailEntity> builder)
    {
        Faker faker = new ("tr");

        DetailEntity detail1 = new()
        {
            Id = 1,
            Title = faker.Lorem.Sentence(1),
            Description = faker.Lorem.Sentence(5),
            CategoryId = 1,
            CreatedDate = DateTime.Now,
            IsDeleted = false,
        };

        DetailEntity detail2 = new()
        {
            Id = 2,
            Title = faker.Lorem.Sentence(2),
            Description = faker.Lorem.Sentence(5),
            CategoryId = 3,
            CreatedDate = DateTime.Now,
            IsDeleted = true,
        };

        DetailEntity detail3 = new()
        {
            Id = 3,
            Title = faker.Lorem.Sentence(1),
            Description = faker.Lorem.Sentence(5),
            CategoryId = 4,
            CreatedDate = DateTime.Now,
            IsDeleted = false,
        };

        builder.HasData(detail1, detail2, detail3);
    }
}
