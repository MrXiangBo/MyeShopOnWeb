using ApplicationCore.Entities.BasketAggregate;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Data
{
    /// <summary>
    /// 
    /// </summary>
    public class CatalogContext : DbContext
    {
        public CatalogContext(DbContextOptions<CatalogContext> options) : base(options)
        {

        }
        /// <summary>
        /// 模型创建时
        /// </summary>
        /// <param name="builder"></param>
        protected override void OnModelCreating(ModelBuilder builder)
        {
            //Intentionally rolling back this change to fix issue: https://github.com/dotnet-architecture/eShopOnWeb/issues/292
            //Will follow up after issue has been resolved.
            //base.OnModelCreating(builder);
            //builder.ApplyAllConfigurationsFromCurrentAssembly();

            // alternately this is built-in to EF Core 2.2
            //builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            //builder.Entity<Basket>(ConfigureBasket);
            //builder.Entity<CatalogBrand>(ConfigureCatalogBrand);
            //builder.Entity<CatalogType>(ConfigureCatalogType);
            //builder.Entity<CatalogItem>(ConfigureCatalogItem);
            //builder.Entity<Order>(ConfigureOrder);
            //builder.Entity<OrderItem>(ConfigureOrderItem);
            //builder.Entity<Address>(ConfigureAddress);
            //builder.Entity<CatalogItemOrdered>(ConfigureCatalogItemOrdered);
            //builder.Entity<BasketItem>(ConfigureBasketItem);
        }
    }
}
