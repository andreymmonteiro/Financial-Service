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
        private readonly IRepository<FinanceAccountsEntity> _repository;
        private readonly IMapper _mapper;
        private const string SUCCESS = "Success";
        private const string ERROR = "Error";

        public FinancialService(IRepository<FinanceAccountsEntity> repository, IMapper mapper)
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
            var financeAccountEntity = await _repository.InsertASync(_mapper.Map<FinanceAccountsEntity>(request));
            return _mapper.Map<FinanceAccountsProtoDto>(financeAccountEntity);
        }

        public override async Task<FinanceAccountsProtoDto> UpdateFinancAccounts(FinanceAccountsUpdateRequest request, ServerCallContext context)
        {
            var financeAccountsRequest = _mapper.Map<FinanceAccountsEntity>(request);
            var financeAccountsEntity = await _repository.UpdateAsync(financeAccountsRequest);
            return _mapper.Map<FinanceAccountsProtoDto>(financeAccountsEntity);
        }

        public override async Task<FinanceAccountsDeleteResponse> DeleteFinanceAccounts(FinanceAccountsSingleRequest request, ServerCallContext context)
        {
            if(await _repository.DeleteAsync(Guid.Parse(request.Id))) 
            {
                return new FinanceAccountsDeleteResponse() { Result = SUCCESS };
            }
            return new FinanceAccountsDeleteResponse() { Result = ERROR };
        }
    }
}
