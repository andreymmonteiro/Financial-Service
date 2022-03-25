using System;
using System.ComponentModel.DataAnnotations;

namespace Financial.Domain.Entities.FinanceAccounts
{
    public class FinanceAccountsPaymentItemsEntity : BaseEntity
    {
        [Required]
        public Guid FinanceAccountsItemsId { get; set; }

        public FinanceAccountsItemsEntity FinanceAccountsItems { get; set; }

        [Required]
        public DateTime Payday { get; set; }

        [Required]
        public decimal Total { get; set; }
    }
}
