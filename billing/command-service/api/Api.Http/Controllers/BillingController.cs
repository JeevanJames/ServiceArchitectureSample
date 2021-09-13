using System;
using System.Threading.Tasks;

using JeevanInc.Billing.CommandService.Contract;
using JeevanInc.Billing.CommandService.Contract.Models;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JeevanInc.Billing.CommandService.Api.Http.Controllers
{
    [ApiController]
    [Route("")]
    public sealed class BillingController : ControllerBase
    {
        private readonly IBillingService _service;

        public BillingController(IBillingService service)
        {
            _service = service ?? throw new ArgumentNullException(nameof(service));
        }

        [HttpPost]
        [ProducesResponseType(typeof(BillCustomerOutput), StatusCodes.Status200OK)]
        public async Task<ActionResult<BillCustomerOutput>> BillCustomer(BillCustomerInput input)
        {
            BillCustomerOutput output = await _service.BillCustomer(input);
            return Ok(output);
        }
    }
}
