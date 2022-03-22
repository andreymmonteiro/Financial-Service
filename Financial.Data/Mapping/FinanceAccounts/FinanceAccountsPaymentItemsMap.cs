using Financial.Domain.Entities.FinanceAccounts;
using Microsoft.EntityFrameworkCore;

namespace Financial.Data.Mapping.FinanceAccounts
{
    public class FinanceAccountsPaymentItemsMap : IEntityTypeConfiguration<FinanceAccountsPaymentItemsEntity>
    {
        private const string TABLE = "FinanceAccountsPaymentItems";
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<FinanceAccountsPaymentItemsEntity> builder)
        {
            builder.ToTable(TABLE);
            builder.HasKey(pk => pk.Id);
            builder.HasOne(fk => fk.FinanceAccountsItems).WithMany(fk => fk.PaymentItems);
        }
    }
}
