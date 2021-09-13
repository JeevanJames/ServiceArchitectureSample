using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using JeevanInc.Billing.CommandService.Contract;
using JeevanInc.Billing.CommandService.Contract.Models;

namespace JeevanInc.Billing.CommandService.Domain
{
    public sealed class BillingDomain : IBillingService
    {
        public Task<BillCustomerOutput> BillCustomers(BillCustomerInput input)
        {
            IEnumerable<string> billIds = input.Bills.Select(b => b.Id);
            BillCustomerOutput output = new() { Ids = billIds.ToList() };
            return Task.FromResult(output);
        }

        public Task<DeleteBillsOutput> DeleteBills(DeleteBillsInput input)
        {
            DeleteBillsOutput output = new() { BillIds = new List<string>(input.BillIds) };
            return Task.FromResult(output);
        }
    }
}
