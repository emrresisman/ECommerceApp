using ECommerceAPP.Application.Repositories;
using ECommerceAPP.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceAPP.Application.Repositories
{
    public interface ICustomerReadRepository:IReadRepository<Customer>
    {
    }
}
