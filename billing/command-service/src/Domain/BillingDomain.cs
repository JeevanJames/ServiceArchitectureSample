using System.Threading.Tasks;

using JeevanInc.Billing.CommandService.Contract;
using JeevanInc.Billing.CommandService.Contract.Models;

namespace JeevanInc.Billing.CommandService.Domain
{
    public sealed class BillingDomain : IBillingService
    {
        public Task<BillCustomerOutput> BillCustomer(BillCustomerInput input)
        {
            return Task.FromResult(new BillCustomerOutput());
        }
    }
}
