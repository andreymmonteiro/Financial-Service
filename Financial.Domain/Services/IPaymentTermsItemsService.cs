using Financial.Domain.Dtos.PaymentTerms;
using System;
using System.Threading.Tasks;

namespace Financial.Domain.Services
{
    public interface IPaymentTermsItemsService
    {
        Task<PaymentTermsItemsDto> GetAllAsync();

        Task<PaymentTermsItemsDto> GetAsync(Guid id);

        Task<PaymentTermsItemsDto> CreateAsync(PaymentTermsItemsDto model);

        Task<PaymentTermsItemsDto> UpdateAsync(PaymentTermsItemsDto model);

        Task<bool> DeleteAsync(Guid id);
    }
}
