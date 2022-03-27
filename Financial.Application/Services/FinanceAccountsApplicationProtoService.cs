using AutoMapper;
using Financial.Aplpication.Mapper.ConfigureAutoMapper.Interface;
using Financial.Application.Protos;
using Financial.Domain.Dtos.FinanceAccounts;
using Financial.Domain.Services;
using Grpc.Core;
using System;
using System.Threading.Tasks;
using static Financial.Application.Protos.FinanceAccountsProtoService;

namespace Financial.Application.Services
{
    public class FinanceAccountsApplicationProtoService : FinanceAccountsProtoServiceBase
    {
        private readonly IFinanceAccountsService _financeService;
        private readonly IMapper _mapper;
        private const string SUCCESS = "Success";
        private const string ERROR = "Error";

        public FinanceAccountsApplicationProtoService(IFinanceAccountsService service, IMapperProtoService mapper)
        {
            _financeService = service;
            _mapper = mapper.GetMapper();
        }

        public override async Task<ListFinanceAccountsProtoDto> GetAllFinanceAccounts(FinanceAccountsRequest request, ServerCallContext context)
        {
            var financeAccountsEntity = await _financeService.GetAllAsync();
            return _mapper.Map<ListFinanceAccountsProtoDto>(financeAccountsEntity);
        }

        public override async Task<FinanceAccountsProtoDto> GetFinanceAccounts(FinanceAccountsSingleRequest request, ServerCallContext context)
        {
            var financeAccountsEntity = await _financeService.GetAsync(Guid.Parse(request.Id));
            return _mapper.Map<FinanceAccountsProtoDto>(financeAccountsEntity);
        }

        public override async Task<FinanceAccountsProtoDto> CreateFinanceAccounts(FinanceAccountsCreateRequest request, ServerCallContext context)
        {
            var financeAccountDto = await _financeService.CreateAsync(_mapper.Map<FinanceAccountsCreateDto>(request));
            return _mapper.Map<FinanceAccountsProtoDto>(financeAccountDto);
        }

        public override async Task<FinanceAccountsProtoDto> UpdateFinanceAccounts(FinanceAccountsUpdateRequest request, ServerCallContext context)
        {
            var financeAccountsDto = await _financeService.UpdateAsync(_mapper.Map<FinanceAccountsUpdateDto>(request));
            return _mapper.Map<FinanceAccountsProtoDto>(financeAccountsDto);
        }

        public override async Task<FinanceAccountsDeleteResponse> DeleteFinanceAccounts(FinanceAccountsSingleRequest request, ServerCallContext context)
        {
            if (await _financeService.DeleteAsync(Guid.Parse(request.Id)))
            {
                return new FinanceAccountsDeleteResponse() { Result = SUCCESS };
            }
            return new FinanceAccountsDeleteResponse() { Result = ERROR };
        }
    }
}
