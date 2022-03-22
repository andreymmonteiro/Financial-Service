using Financial.Domain.Entities.FinanceAccounts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Financial.Data.Mapping.FinanceAccounts
{
    public class FinanceAccountMap : IEntityTypeConfiguration<FinanceAccountsEntity>
    {
        private const string TABLE = "FinanceAccounts";
        public void Configure(EntityTypeBuilder<FinanceAccountsEntity> builder)
        {
            builder.ToTable(TABLE);
            builder.HasKey(x => x.Id);
            builder.Property(prop => prop.FinanceAccountType).IsRequired();
            builder.Property(prop => prop.PaymentTermsId).IsRequired();
        }
    }
}
