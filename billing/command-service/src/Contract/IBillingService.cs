using System.Threading.Tasks;

using JeevanInc.Billing.CommandService.Contract.Models;

namespace JeevanInc.Billing.CommandService.Contract
{
    public interface IBillingService
    {
        Task<BillCustomerOutput> BillCustomer(BillCustomerInput input);
    }
}
