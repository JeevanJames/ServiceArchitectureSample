using System.Collections.Generic;

namespace JeevanInc.Billing.CommandService.Contract.Models
{
    public sealed class DeleteBillsOutput
    {
        private IList<string>? _billIds;

        public IList<string> BillIds
        {
            get => _billIds ??= new List<string>();
            set => _billIds = value;
        }
    }
}
