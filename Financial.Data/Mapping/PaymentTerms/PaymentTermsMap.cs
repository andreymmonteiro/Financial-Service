using Financial.Domain.Entities.PaymentTerms;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Financial.Data.Mapping.PaymentTerms
{
    public class PaymentTermsMap : IEntityTypeConfiguration<PaymentTermsEntity>
    {
        private const string TABLE = "PaymentTerms";
        public void Configure(EntityTypeBuilder<PaymentTermsEntity> builder)
        {
            builder.ToTable(TABLE);
            builder.HasKey(pk => pk.Id);
        }
    }
}
