using Financial.Domain.Models.ModelTypes;

namespace Financial.Domain.Entities.FinanceAccounts
{
    public sealed class FinanceAccount : BaseEntity
    {
        public FinanceAccountType FinanceAccountType { get; set; }

        public int PaymentTermsId { get; set; }

        public int FinanceAccountItemId { get; set; }
    }
}
