using Financial.Domain.Entities.PaymentTerms;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Financial.Data.Mapping.PaymentTerms
{
    public class PaymentTermsItemsMap : IEntityTypeConfiguration<PaymentTermsItemsEntity>
    {
        private const string TABLE = "PaymentTermsItems";
        public void Configure(EntityTypeBuilder<PaymentTermsItemsEntity> builder)
        {
            builder.ToTable(TABLE);
            builder.HasKey(pk => pk.Id);
            builder.HasOne(fk => fk.PaymentTerms).WithMany(fk => fk.PaymentTermsItems);
        }
    }
}
