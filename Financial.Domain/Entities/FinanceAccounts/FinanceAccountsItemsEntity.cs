using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Financial.Domain.Entities.FinanceAccounts
{
    public class FinanceAccountsItemsEntity : BaseEntity
    {
        [Required]
        public Guid FinanceAccountId { get; set; }
        
        public FinanceAccountsEntity FinanceAccount { get; set; }

        public IEnumerable<FinanceAccountsPaymentItemsEntity> PaymentItems { get; set; }

        public decimal GrossTotal { get; set; }

        [Required]
        public decimal Total { get; set; }

        public decimal Discount { get; set; }

        public decimal Addition { get; set; }

        [Required]
        public DateTime DueDate { get; set; }
    }
}
