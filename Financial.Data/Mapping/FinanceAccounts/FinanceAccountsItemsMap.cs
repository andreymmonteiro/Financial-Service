using Financial.Domain.Entities.FinanceAccounts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Financial.Data.Mapping.FinanceAccounts
{
    public class FinanceAccountsItemsMap : IEntityTypeConfiguration<FinanceAccountsItemsEntity>
    {
        private const string TABLE = "FinanceAccountsItems";
        public void Configure(EntityTypeBuilder<FinanceAccountsItemsEntity> builder)
        {
            builder.ToTable(TABLE);
            builder.HasKey(pk => pk.Id);
            builder.HasOne(fk => fk.FinanceAccount).WithMany(fk => fk.FinanceAccountsItems);
            builder.HasIndex(index => index.CompanyId).IsUnique();
        }
    }
}
