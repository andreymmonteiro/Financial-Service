using Financial.Domain.Entities.FinanceAccounts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Financial.Data.Mapping.FinanceAccounts
{
    public class FinanceAccountMap : IEntityTypeConfiguration<FinanceAccount>
    {
        public void Configure(EntityTypeBuilder<FinanceAccount> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(prop => prop.FinanceAccountType).IsRequired();
            builder.Property(prop => prop.PaymentTermsId).IsRequired();
            builder.Property(prop => prop.FinanceAccountItemId).IsRequired();
        }
    }
}
