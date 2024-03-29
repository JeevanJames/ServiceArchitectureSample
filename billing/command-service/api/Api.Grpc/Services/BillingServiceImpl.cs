using System;
using System.Threading.Tasks;

using Grpc.Core;

using JeevanInc.Billing.CommandService.Contract;

namespace JeevanInc.Billing.CommandService.Api.Grpc.Services
{
    public partial class BillingServiceImpl : BillingService.BillingServiceBase
    {
        private readonly IBillingService _service;

        public BillingServiceImpl(IBillingService service)
        {
            _service = service ?? throw new ArgumentNullException(nameof(service));
        }

        public override async Task<BillCustomerOutput> BillCustomer(BillCustomerInput request, ServerCallContext context)
        {
            return await _service.BillCustomers(request);
        }

        public override async Task<DeleteBillsOutput> DeleteBills(DeleteBillsInput request, ServerCallContext context)
        {
            return await _service.DeleteBills(request);
        }
    }
}
