using Financial.Domain.Dtos.PaymentTerms;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Financial.Domain.Services
{
    public interface IPaymentTermsService
    {
        Task<IEnumerable<PaymentTermsDto>> GetAllAsync();
        
        Task<PaymentTermsDto> GetAsync(Guid id);

        Task<PaymentTermsDto> CreateAsync(PaymentTermsCreateDto model);

        Task<PaymentTermsDto> UpdateAsync(PaymentTermsUpdateDto model);

        Task<bool> DeleteAsync(Guid id);
    }
}
