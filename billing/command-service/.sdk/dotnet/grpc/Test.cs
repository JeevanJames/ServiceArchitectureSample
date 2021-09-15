using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Grpc.Net.Client;

namespace JeevanInc.Billing.CommandService.Client.Grpc
{
    public class Test
    {
        public async Task DoSomething()
        {
            using var channel = new GrpcChannel("https://localhost:5001");
            var client = new BillingService.BillingServiceClient(channel);
            await client.BillCustomerAsync()
        }
    }
}
