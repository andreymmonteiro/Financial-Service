using AutoMapper;
using Financial.Application.Protos;
using Financial.Domain.Entities.FinanceAccounts;

namespace Financial.Application.Mapper
{
    public class EntityToDto : Profile
    {
        public EntityToDto()
        {
            CreateMap<FinanceAccount, FinanceAccountsProtoDto>().ReverseMap();
            CreateMap<FinanceAccount, FinanceAccountsCreateRequest>().ReverseMap();
        }
    }
}
