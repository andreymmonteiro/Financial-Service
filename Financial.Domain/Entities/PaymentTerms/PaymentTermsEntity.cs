using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Financial.Domain.Entities.PaymentTerms
{
    public class PaymentTermsEntity : BaseEntity
    {
        [Required]
        public string Description { get; set; }

        [MaxLength(10)]
        public int ForceExpiration { get; set; }

        public IEnumerable<PaymentTermsItemsEntity> PaymentTermsItems { get; set; }
    }
}
