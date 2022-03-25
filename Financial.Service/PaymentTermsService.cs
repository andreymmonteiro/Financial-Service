using AutoMapper;
using Financial.Domain.Dtos.PaymentTerms;
using Financial.Domain.Entities.PaymentTerms;
using Financial.Domain.Interfaces;
using Financial.Domain.Mapper.Interface;
using Financial.Domain.Services;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Financial.Service
{
    public class PaymentTermsService : IPaymentTermsService
    {
        private readonly IRepository<PaymentTermsEntity> _repository;
        private readonly IMapper _mapper;

        public PaymentTermsService(IRepository<PaymentTermsEntity> repository, IMapperService mapper)
        {
            _repository = repository;
            _mapper = mapper.GetMapper();
        }

        public async Task<PaymentTermsDto> CreateAsync(PaymentTermsCreateDto model)
        {
            var paymentTermsEntity = _mapper.Map<PaymentTermsEntity>(model);
            return _mapper.Map<PaymentTermsDto>(await _repository.InsertASync(paymentTermsEntity));
        }

        public async Task<bool> DeleteAsync(Guid id)
        {
            return await _repository.DeleteAsync(id);
        }

        public async Task<IEnumerable<PaymentTermsDto>> GetAllAsync()
        {
            return _mapper.Map<IEnumerable<PaymentTermsDto>>((IEnumerable<PaymentTermsDto>)await _repository.SelectAsync());
        }

        public async Task<PaymentTermsDto> GetAsync(Guid id)
        {
            return _mapper.Map<PaymentTermsDto>(await _repository.SelectAsync(id));
        }

        public async Task<PaymentTermsDto> UpdateAsync(PaymentTermsUpdateDto model)
        {
            var paymentTermsEntity = _mapper.Map<PaymentTermsEntity>(model);
            return _mapper.Map<PaymentTermsDto>(await _repository.UpdateAsync(paymentTermsEntity));
        }
    }
}
