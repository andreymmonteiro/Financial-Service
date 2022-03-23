using Financial.Domain.Dtos.FinanceAccounts;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Financial.Domain.Services
{
    public interface IFinanceAccountsService
    {
        Task<IEnumerable<FinanceAccountsDto>> GetAllAsync();
        
        Task<FinanceAccountsDto> GetAsync(Guid id);

        Task<FinanceAccountsDto> CreateAsync(FinanceAccountsCreateDto model);

        Task<FinanceAccountsDto> UpdateAsync(FinanceAccountsUpdateDto model);

        Task<bool> DeleteAsync(Guid id);

    }
}
