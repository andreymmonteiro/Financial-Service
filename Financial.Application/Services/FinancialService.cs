using AutoMapper;
using Financial.Application.Protos;
using Financial.Domain.Entities.FinanceAccounts;
using Financial.Domain.Interfaces;
using Grpc.Core;
using System;
using System.Threading.Tasks;
using static Financial.Application.Protos.Finance;

namespace Financial.Application.Services
{
    public class FinancialService : FinanceBase
    {
        private readonly IRepository<FinanceAccount> _repository;
        private readonly IMapper _mapper;

        public FinancialService(IRepository<FinanceAccount> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public override async Task<FinanceAccountsProtoDto> GetAllFinanceAccounts(FinanceAccountsRequest request, ServerCallContext context)
        {
            var financeAccountsEntity = await _repository.SelectAsync();
            return _mapper.Map<FinanceAccountsProtoDto>(financeAccountsEntity);
        }

        public override async Task<FinanceAccountsProtoDto> GetFinanceAccounts(FinanceAccountsSingleRequest request, ServerCallContext context)
        {
            var financeAccountsEntity = await _repository.SelectAsync(new Guid(request.Id));
            return _mapper.Map<FinanceAccountsProtoDto>(financeAccountsEntity);
        }

        public override async Task<FinanceAccountsProtoDto> CreateFinanceAccounts(FinanceAccountsCreateRequest request, ServerCallContext context)
        {
            var financeAccountEntity = await _repository.InsertASync(_mapper.Map<FinanceAccount>(request));
            return _mapper.Map<FinanceAccountsProtoDto>(financeAccountEntity);
        }
    }
}
