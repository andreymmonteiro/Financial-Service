using Financial.Domain.Dtos.PaymentTerms;
using System;
using System.Threading.Tasks;

namespace Financial.Data.Repositories
{
    public interface IPaymentTermsImplementations
    {
        Task<PaymentTermsDto> GetByParams(Guid? id, string description, DateTime? creatAt);
    }
}
