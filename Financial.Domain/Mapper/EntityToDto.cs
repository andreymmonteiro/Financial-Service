using AutoMapper;
using Financial.Domain.Dtos.FinanceAccounts;
using Financial.Domain.Entities.FinanceAccounts;

namespace Financial.Domain.Mapper
{
    public class EntityToDto : Profile
    {
        public EntityToDto() 
        {
            FinanceDtoToEntity();
        }

        private void FinanceDtoToEntity() 
        {
            CreateMap<FinanceAccountsDto, FinanceAccountsEntity>().ReverseMap();
            CreateMap<FinanceAccountsCreateDto, FinanceAccountsEntity>().ReverseMap();
            CreateMap<FinanceAccountsUpdateDto, FinanceAccountsEntity>().ReverseMap();
        }
    }
}
