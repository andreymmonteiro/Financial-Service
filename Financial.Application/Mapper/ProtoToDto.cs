using AutoMapper;
using Financial.Application.Protos;
using Financial.Domain.Dtos.FinanceAccounts;

namespace Financial.Application.Mapper
{
    public class ProtoToDto : Profile
    {
        public ProtoToDto()
        {
            CreateMap<FinanceAccountsCreateRequest, FinanceAccountsCreateDto>().ReverseMap();
            CreateMap<FinanceAccountsUpdateRequest, FinanceAccountsUpdateDto>().ReverseMap();
            CreateMap<FinanceAccountsProtoDto, FinanceAccountsDto>().ReverseMap();
        }
    }
}
