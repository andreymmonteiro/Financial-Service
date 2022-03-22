using System;
using System.Collections.Generic;

namespace Financial.Domain.Entities.FinanceAccounts
{
    public class FinanceAccountsItemsEntity : BaseEntity
    {
        public Guid FinanceAccountId { get; set; }
        
        public FinanceAccountsEntity FinanceAccount { get; set; }

        public IEnumerable<FinanceAccountsPaymentItemsEntity> PaymentItems { get; set; }

        public decimal GrossTotal { get; set; }

        public decimal Total { get; set; }

        public decimal Discount { get; set; }

        public decimal Addition { get; set; }

        public DateTime DueDate { get; set; }
    }
}
