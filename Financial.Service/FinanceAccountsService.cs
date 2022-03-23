using AutoMapper;
using Financial.Domain.Dtos.FinanceAccounts;
using Financial.Domain.Entities.FinanceAccounts;
using Financial.Domain.Interfaces;
using Financial.Domain.Mapper.Interface;
using Financial.Domain.Services;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Financial.Service
{
    public class FinanceAccountsService : IFinanceAccountsService
    {
        private readonly IRepository<FinanceAccountsEntity> _repository;
        private readonly IMapper _mapper;

        public FinanceAccountsService(IRepository<FinanceAccountsEntity> repository, IMapperService mapper)
        {
            _repository = repository;
            _mapper = mapper.GetMapper();
        }

        public async Task<FinanceAccountsDto> CreateAsync(FinanceAccountsCreateDto model)
        {
            var entity = _mapper.Map<FinanceAccountsEntity>(model);
            var resultEntity = await _repository.InsertASync(entity);
            return _mapper.Map<FinanceAccountsDto>(resultEntity);
        }

        public async Task<bool> DeleteAsync(Guid id)
        {
            return await _repository.DeleteAsync(id);
        }

        public async Task<IEnumerable<FinanceAccountsDto>> GetAllAsync()
        {
            var resultEntity = await _repository.SelectAsync();
            return _mapper.Map<IEnumerable<FinanceAccountsDto>>(resultEntity);
        }

        public async Task<FinanceAccountsDto> GetAsync(Guid id)
        {
            var resultEntity = await _repository.SelectAsync(id);
            return _mapper.Map<FinanceAccountsDto>(resultEntity);
        }

        public async Task<FinanceAccountsDto> UpdateAsync(FinanceAccountsUpdateDto model)
        {
            var entity = _mapper.Map<FinanceAccountsEntity>(model);
            var resultEntity = await _repository.UpdateAsync(entity);
            return _mapper.Map<FinanceAccountsDto>(resultEntity); ;
        }
    }
}
