using CoreLayer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using CoreLayer;

namespace RepositoryLayer.Seeds
{
    internal class ProductSeed : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(new Product
            {
                Id = 1,
                CategoryId = 1,
                Name = "Sedan Araba",
                Price = 450,
                Stock = 4,
                CreatedDate = DateTime.Now


            },
            new Product
            {
                Id = 2,
                CategoryId = 1,
                Name = "SUV Araba",
                Price = 600,
                Stock = 15,
                CreatedDate = DateTime.Now


            },
             new Product
             {
                 Id = 3,
                 CategoryId = 1,
                 Name = "HatchBack Araba",
                 Price = 750,
                 Stock = 7,
                 CreatedDate = DateTime.Now


             },
               new Product
               {
                   Id = 4,
                   CategoryId = 2,
                   Name = "Bina",
                   Price = 900,
                   Stock = 2,
                   CreatedDate = DateTime.Now


               },
               new Product
               {
                   Id = 5,
                   CategoryId = 2,
                   Name = "Villa",
                   Price = 8900,
                   Stock = 3,
                   CreatedDate = DateTime.Now


               });

        }
    }
}
