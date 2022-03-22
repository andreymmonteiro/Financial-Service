using System;
using System.ComponentModel.DataAnnotations;

namespace Financial.Domain.Entities.PaymentTerms
{
    public class PaymentTermsItemsEntity : BaseEntity
    {
        [Required]
        [MaxLength(10)]
        public int Days { get; set; }

        public decimal Addition { get; set; }

        public decimal Discount { get; set; }

        [Required]
        public Guid PaymentTermsId { get; set; }

        public PaymentTermsEntity PaymentTerms { get; set; }
    }
}
