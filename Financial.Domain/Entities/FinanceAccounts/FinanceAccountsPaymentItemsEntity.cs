using System;

namespace Financial.Domain.Entities.FinanceAccounts
{
    public class FinanceAccountsPaymentItemsEntity : BaseEntity
    {
        public Guid FinanceAccountsItemsId { get; set; }

        public FinanceAccountsItemsEntity FinanceAccountsItems { get; set; }

        public DateTime Payday { get; set; }

        public decimal Total { get; set; }
    }
}
