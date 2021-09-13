using System.Linq;

using Google.Protobuf.Collections;

using Microsoft.AspNetCore.Http.Connections;

using CM = JeevanInc.Billing.CommandService.Contract.Models;

namespace JeevanInc.Billing.CommandService.Api.Grpc
{
    public partial class BillCustomerInput
    {
        public static implicit operator CM.BillCustomerInput(BillCustomerInput input)
        {
            return new CM.BillCustomerInput
            {
                Bills = input.Bills.Select(b => (CM.CustomerBill)b).ToList(),
            };
        }
    }

    public partial class CustomerBill
    {
        public static implicit operator CM.CustomerBill(CustomerBill input)
        {
            return new CM.CustomerBill
            {
                Id = input.Id,
                Timestamp = input.Timestamp.ToDateTime(),
                TotalAmount = input.TotalAmount,
            };
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

    public partial class DeleteBillsInput
    {
        public static implicit operator CM.DeleteBillsInput(DeleteBillsInput input)
        {
            return new CM.DeleteBillsInput { BillIds = input.BillIds.Select(b => b).ToList() };
        }
    }

    public partial class DeleteBillsOutput
    {
        public static implicit operator DeleteBillsOutput(CM.DeleteBillsOutput output)
        {
            DeleteBillsOutput finalOutput = new();
            finalOutput.BillIds.AddRange(output.BillIds);
            return finalOutput;
        }
    }
}
