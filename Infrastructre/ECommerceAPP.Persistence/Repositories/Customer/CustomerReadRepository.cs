using ECommerceAPP.Application.Repositories;
using ECommerceAPP.Domain.Entities;
using ECommerceAPP.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceAPP.Persistence.Repositories
{
    public class CustomerReadRepository : ReadRepository<Customer>,ICustomerReadRepository
    {
        public CustomerReadRepository(ECommerceAPIDbContext context) : base(context)
        {
        }
    }
}
