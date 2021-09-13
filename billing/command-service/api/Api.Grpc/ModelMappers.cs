using CM = JeevanInc.Billing.CommandService.Contract.Models;

namespace JeevanInc.Billing.CommandService.Api.Grpc
{
    public partial class BillCustomerInput
    {
        public static implicit operator CM.BillCustomerInput(BillCustomerInput input)
        {
            return new CM.BillCustomerInput();
        }
    }

    public partial class BillCustomerOutput
    {
        public static implicit operator CM.BillCustomerOutput(BillCustomerOutput output)
        {
            return new CM.BillCustomerOutput();
        }

        public static implicit operator BillCustomerOutput(CM.BillCustomerOutput output)
        {
            return new BillCustomerOutput();
        }
    }
}
