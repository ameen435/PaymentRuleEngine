using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace PaymentRuleEngine.Controllers
{
    [ApiController]
    [Route("Payment")]
    public class PaymentController : ControllerBase
    {
        private readonly ILogger<PaymentController> _logger;

        public PaymentController(ILogger<PaymentController> logger)
        {
            _logger = logger;
        }

        [Route("product/addOrder"), HttpPost]
        public IActionResult AddOrder()
        {
            throw new NotImplementedException();

        }

        [Route("product/linkOrderAndPayment"), HttpPost]
        public IActionResult LinkOrderAndPayment()
        {
            throw new NotImplementedException();

        }

        [Route("product/add"), HttpPost]
        
        public IActionResult DeactivatePaymentLink()
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