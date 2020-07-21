using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RiotAPI.Learning.Models;
using RiotAPI.Learning.Services;

namespace RiotAPI.Learning.Controllers {
    [Route("[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase {
        public JsonFileProductService ProductService { get; }

        public ProductsController(JsonFileProductService productService) {
            ProductService = productService;
        }

        
        [HttpGet]
        public IEnumerable<Product> Get() {
            return ProductService.GetProducts();
        }

    }
}
