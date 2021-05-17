using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace PaymentRuleEngine.Controllers
{
    [ApiController]
    [Route("Product")]
    public class ProductController : ControllerBase
    {
        private readonly ILogger<ProductController> _logger;

        public ProductController(ILogger<ProductController> logger)
        {
            _logger = logger;
        }

        [Route("product/addProduct"),HttpPost]
        public IActionResult AddProduct()
        {
            throw new NotImplementedException();
        }


        [Route("search"), HttpPost]
        public IActionResult Search()
        {
            throw new NotImplementedException();
        }
    }
}