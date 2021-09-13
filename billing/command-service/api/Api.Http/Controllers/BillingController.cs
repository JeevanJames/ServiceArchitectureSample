using System;
using System.Threading.Tasks;

using JeevanInc.Billing.CommandService.Contract;
using JeevanInc.Billing.CommandService.Contract.Models;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JeevanInc.Billing.CommandService.Api.Http.Controllers
{
    [ApiController]
    [Route("billing")]
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
            BillCustomerOutput output = await _service.BillCustomers(input);
            return Ok(output);
        }

        [HttpPost("single")]
        [ProducesResponseType(typeof(string), StatusCodes.Status200OK)]
        public async Task<ActionResult<string>> BillSingleCustomer(CustomerBill bill)
        {
            BillCustomerInput input = new() { Bills = new[] { bill } };
            BillCustomerOutput output = await _service.BillCustomers(input);
            return Ok(output.Ids[0]);
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public async Task<ActionResult> DeleteBill(string id)
        {
            DeleteBillsInput input = new() { BillIds = new[] { id } };
            await _service.DeleteBills(input);
            return NoContent();
        }
    }
}
