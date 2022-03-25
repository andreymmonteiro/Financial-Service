using AutoMapper;
using Financial.Application.Protos;
using Financial.Domain.Dtos.FinanceAccounts;
using Financial.Domain.Dtos.FinanceAccounts.Items;
using Financial.Domain.Dtos.PaymentTerms;

namespace Financial.Application.Mapper
{
    public class ProtoToDto : Profile
    {
        public ProtoToDto()
        {
            FinanceAccountsDtoToProto();
            PaymentTermsDtoToProto();
        }

        private void FinanceAccountsDtoToProto() 
        {
            CreateMap<FinanceAccountsCreateRequest, FinanceAccountsCreateDto>().ReverseMap();
            CreateMap<FinanceAccountsUpdateRequest, FinanceAccountsUpdateDto>().ReverseMap();
            CreateMap<FinanceAccountsProtoDto, FinanceAccountsDto>().ReverseMap();
            CreateMap<FinanceAccountsItemsRequest, FinanceAccountsItemsDto>().ReverseMap();
        }

        private void PaymentTermsDtoToProto()
        {
            CreateMap<PaymentTermsProtoDto, PaymentTermsDto>();
            CreateMap<PaymentTermsCreate, PaymentTermsCreateDto>();
            CreateMap<PaymentTermsUpdate, PaymentTermsUpdateDto>();
            CreateMap<PaymentTermsItemsRequest, PaymentTermsItemsDto>();
        }
    }
}
