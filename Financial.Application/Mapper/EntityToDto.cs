using AutoMapper;
using Financial.Application.Protos;
using Financial.Domain.Entities.FinanceAccounts;

namespace Financial.Application.Mapper
{
    public class EntityToDto : Profile
    {
        public EntityToDto()
        {
            CreateMap<FinanceAccountsEntity, FinanceAccountsProtoDto>().ReverseMap();
            CreateMap<FinanceAccountsEntity, FinanceAccountsCreateRequest>().ReverseMap();
            CreateMap<FinanceAccountsEntity, FinanceAccountsUpdateRequest>().ReverseMap();
        }
    }
}
