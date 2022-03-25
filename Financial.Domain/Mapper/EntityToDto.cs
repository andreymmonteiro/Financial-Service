using AutoMapper;
using Financial.Domain.Dtos.FinanceAccounts;
using Financial.Domain.Dtos.FinanceAccounts.Items;
using Financial.Domain.Dtos.PaymentTerms;
using Financial.Domain.Entities.FinanceAccounts;
using Financial.Domain.Entities.PaymentTerms;

namespace Financial.Domain.Mapper
{
    public class EntityToDto : Profile
    {
        public EntityToDto() 
        {
            FinanceDtoToEntity();
            PaymentTermsDtoToEntity();
        }

        private void FinanceDtoToEntity() 
        {
            CreateMap<FinanceAccountsDto, FinanceAccountsEntity>().ReverseMap();
            CreateMap<FinanceAccountsCreateDto, FinanceAccountsEntity>().ReverseMap();
            CreateMap<FinanceAccountsUpdateDto, FinanceAccountsEntity>().ReverseMap();
            CreateMap<FinanceAccountsItemsDto, FinanceAccountsItemsEntity>().ReverseMap();
        }

        private void PaymentTermsDtoToEntity() 
        {
            CreateMap<PaymentTermsDto, PaymentTermsEntity>().ReverseMap();
            CreateMap<PaymentTermsCreateDto, PaymentTermsEntity>().ReverseMap();
            CreateMap<PaymentTermsUpdateDto, PaymentTermsEntity>().ReverseMap();
            CreateMap<PaymentTermsItemsDto, PaymentTermsItemsEntity>().ReverseMap();
        }
    }
}
