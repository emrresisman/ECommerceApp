using ECommerceAPP.Application.Abstraction;
using ECommerceAPP.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceAPP.Persistence.Concretes
{
    public class ProductService : IProductService
    {
        public List<Product> GetProducts()
            => new()
            {
                new(){Id=Guid.NewGuid(),Name="Product 1",Stock=20,CreatedDate=DateTime.UtcNow,Price=100},
                 new(){Id=Guid.NewGuid(),Name="Product 2",Stock=20,CreatedDate=DateTime.UtcNow,Price=200},
                 new(){Id=Guid.NewGuid(),Name="Product 3",Stock=20,CreatedDate=DateTime.UtcNow,Price=300},
                 new(){Id=Guid.NewGuid(),Name="Product 4",Stock=20,CreatedDate=DateTime.UtcNow,Price=400},
                new(){Id=Guid.NewGuid(),Name="Product 5",Stock=20,CreatedDate=DateTime.UtcNow,Price=500}


            };
    }
}
