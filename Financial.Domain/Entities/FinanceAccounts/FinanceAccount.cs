using Financial.Domain.Models.ModelTypes;
using System;

namespace Financial.Domain.Entities.FinanceAccounts
{
    public sealed class FinanceAccount : BaseEntity
    {
        public FinanceAccountType FinanceAccountType { get; set; }

        public Guid PaymentTermsId { get; set; }

        public Guid FinanceAccountItemId { get; set; }
    }
}
