using System.Collections.Generic;

namespace JeevanInc.Billing.CommandService.Contract.Models
{
    public sealed class BillCustomerOutput
    {
        private IList<string>? _ids;

        public IList<string> Ids
        {
            get => _ids ??= new List<string>();
            set => _ids = value;
        }
    }
}
