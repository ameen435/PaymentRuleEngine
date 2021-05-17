using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace PaymentRuleEngine.Controllers
{
    [ApiController]
    [Route("Order")]
    public class OrderController : ControllerBase
    {
        private readonly ILogger<OrderController> _logger;

        public OrderController(ILogger<OrderController> logger)
        {
            _logger = logger;
        }

        [Route("addOrder"), HttpPost]
        public IActionResult AddOrder()
        {
            throw new NotImplementedException();

        }
    }
}