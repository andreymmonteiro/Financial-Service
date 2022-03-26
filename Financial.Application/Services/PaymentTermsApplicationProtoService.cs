using AutoMapper;
using Financial.Aplpication.Mapper.ConfigureAutoMapper.Interface;
using Financial.Application.Protos;
using Financial.Data.Repositories;
using Financial.Domain.Services;
using Grpc.Core;
using System;
using System.Threading.Tasks;
using static Financial.Application.Protos.PaymentTermsProtoService;

namespace Financial.Application.Services
{
    public class PaymentTermsApplicationProtoService : PaymentTermsProtoServiceBase
    {
        private readonly IPaymentTermsService _service;
        private readonly IPaymentTermsImplementations _serviceImplementations;
        private readonly IMapper _mapper;

        public PaymentTermsApplicationProtoService(IPaymentTermsService service, IPaymentTermsImplementations serviceImplementations, IMapperProtoService mapper)
        {
            _service = service;
            _serviceImplementations = serviceImplementations;
            _mapper = mapper.GetMapper();
        }

        public override async Task<PaymentTermsProtoDto> Get(PaymentTermsSingleRequest request, ServerCallContext context)
        {
            return _mapper.Map<PaymentTermsProtoDto>(await _serviceImplementations.GetByParams(Guid.Parse(request.Id),null,null));
        }

        public override async Task<ListPaymentTermsProtoDto> GetAll(PaymentTermsRequest request, ServerCallContext context)
        {
            return _mapper.Map<ListPaymentTermsProtoDto>(await _service.GetAllAsync());
        }
    }
}
