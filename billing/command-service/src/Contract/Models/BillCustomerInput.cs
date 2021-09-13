using System;
using System.Collections.Generic;

namespace JeevanInc.Billing.CommandService.Contract.Models
{
    public sealed class BillCustomerInput
    {
        private IList<CustomerBill>? _bills;

        public IList<CustomerBill> Bills
        {
            get => _bills ??= new List<CustomerBill>();
            set => _bills = value;
        }
    }

    public sealed class CustomerBill
    {
        public string Id { get; set; } = null!;

        public DateTime Timestamp { get; set; }

        public double TotalAmount { get; set; }
    }
}
