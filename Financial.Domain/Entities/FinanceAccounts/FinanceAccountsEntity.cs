using Financial.Domain.Models.ModelTypes;
using System;
using System.Collections.Generic;

namespace Financial.Domain.Entities.FinanceAccounts
{
    public sealed class FinanceAccountsEntity : BaseEntity
    {
        public FinanceAccountType FinanceAccountType { get; set; }

        public Guid PaymentTermsId { get; set; }

        public IEnumerable<FinanceAccountsItemsEntity> FinanceAccountsItems { get; set; }

        public Guid PersonId { get; set; }
    }
}
