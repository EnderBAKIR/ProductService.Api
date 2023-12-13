using CoreLayer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using CoreLayer;

namespace RepositoryLayer.Seeds
{
    internal class CategorySeed : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {


            builder.HasData(
                new Category { Id = 1, Name = "Taşıtlar" },
                new Category { Id = 2, Name = "Yapılar" },
                new Category { Id = 3, Name = "İş Makineleri" });
        }
    }
}
