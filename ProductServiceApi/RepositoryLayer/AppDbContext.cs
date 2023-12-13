﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CoreLayer;
using CoreLayer.Models;

namespace RepositoryLayer
{
    
        public class AppDbContext : DbContext
        {

		public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
		{
		}

		public DbSet<Category> Categories { get; set; }
		public DbSet<Product> Products { get; set; }
		public DbSet<ProductFeature> ProductFeatures { get; set; }

		public override int SaveChanges()
		{
			foreach (var item in ChangeTracker.Entries())
			{
				if (item.Entity is BaseEntity entityReference)
				{
					switch (item.Entity)
					{
						case EntityState.Added:
							{
								entityReference.CreatedDate = DateTime.Now;
								break;
							}
						case EntityState.Modified:
							{
								entityReference.UpdatedDate = DateTime.Now;
								break;
							}


					}
				}


			}


			return base.SaveChanges();
		}
		public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
		{

			foreach (var item in ChangeTracker.Entries())
			{
				if (item.Entity is BaseEntity entityReference)
				{
					switch (item.State)
					{
						case EntityState.Added:
							{
								entityReference.CreatedDate = DateTime.Now;
								break;
							}
						case EntityState.Modified:
							{
								Entry(entityReference).Property(x => x.CreatedDate).IsModified = false;

								entityReference.UpdatedDate = DateTime.Now;
								break;
							}


					}
				}


			}









			return base.SaveChangesAsync(cancellationToken);
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());


			modelBuilder.Entity<ProductFeature>().HasData(new ProductFeature()
			{
				Id = 1,
				Color = "Kırmızı",
				Height = 100,
				Width = 200,
				ProductId = 1


			},
			new ProductFeature()
			{
				Id = 2,
				Color = "Mavi",
				Height = 300,
				Width = 500,
				ProductId = 2


			}


			);




			base.OnModelCreating(modelBuilder);
		}
        }
    }

