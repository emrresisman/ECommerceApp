﻿using ECommerceAPP.Application.Repositories;
using ECommerceAPP.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ECommerceAPP.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductWriteRepository _productWriteRepository;
        private readonly IProductReadRepository _productReadRepository;

        public ProductController(IProductWriteRepository productWriteRepository, IProductReadRepository productReadRepository)
        {
            _productWriteRepository = productWriteRepository;
            _productReadRepository = productReadRepository;
        }
        [HttpGet]
        public async Task Get()
        {
            await _productWriteRepository.AddRangeAsync(new()
            {
                new(){Id=Guid.NewGuid(),Name="Product 1",CreatedDate=DateTime.UtcNow,Price=100,Stock=10},
                new(){Id=Guid.NewGuid(),Name="Product 2",CreatedDate=DateTime.UtcNow,Price=200,Stock=20},
                new(){Id=Guid.NewGuid(),Name="Product 3",CreatedDate=DateTime.UtcNow,Price=300,Stock=30},
            });
            await _productWriteRepository.SaveAsync();
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(string id)
        {
            Product product = await _productReadRepository.GetByIdAsync(id);
           
            return Ok(product);
        }
    }
}
