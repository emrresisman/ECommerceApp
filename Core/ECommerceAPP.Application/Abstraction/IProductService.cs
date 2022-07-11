using ECommerceAPP.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceAPP.Application.Abstraction
{
    public interface IProductService
    {
        List<Product> GetProducts();

    }
}
