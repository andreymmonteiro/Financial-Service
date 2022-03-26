using AutoMapper;
using Financial.Domain.Dtos.PaymentTerms;
using Financial.Domain.Entities.PaymentTerms;
using Financial.Domain.Interfaces;
using Financial.Domain.Mapper.Interface;
using Financial.Domain.Services;
using System;
using System.Threading.Tasks;

namespace Financial.Service
{
    //Not used yet
    public class PaymentTermsItemsService : IPaymentTermsItemsService
    {
        private readonly IRepository<PaymentTermsItemsEntity> _repository;
        private readonly IMapper _mapper;

        public PaymentTermsItemsService(IRepository<PaymentTermsItemsEntity> repository, IMapperService mapper)
        {
            _repository = repository;
            _mapper = mapper.GetMapper();
        }

        public async Task<PaymentTermsItemsDto> CreateAsync(PaymentTermsItemsDto model)
        {
            var entity = _mapper.Map<PaymentTermsItemsEntity>(model);
            return _mapper.Map<PaymentTermsItemsDto>( await _repository.InsertASync(entity));
        }

        public Task<bool> DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<PaymentTermsItemsDto> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<PaymentTermsItemsDto> GetAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<PaymentTermsItemsDto> UpdateAsync(PaymentTermsItemsDto model)
        {
            throw new NotImplementedException();
        }
    }
}
