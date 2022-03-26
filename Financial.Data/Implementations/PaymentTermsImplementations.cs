using AutoMapper;
using Financial.Data.Context;
using Financial.Data.Repositories;
using Financial.Domain.Dtos.PaymentTerms;
using Financial.Domain.Entities.PaymentTerms;
using Financial.Domain.Mapper.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace Financial.Data.Implementations
{
    public class PaymentTermsImplementations : BaseRepository<PaymentTermsEntity>, IPaymentTermsImplementations
    {
        private readonly DbSet<PaymentTermsEntity> _db;
        private readonly IMapper _mapper;
        public PaymentTermsImplementations(MyContext context, IMapperService mapper) : base(context)
        {
            _db = context.Set<PaymentTermsEntity>();
            _mapper = mapper.GetMapper();
        }

        public async Task<PaymentTermsDto> GetByParams(Guid? id, string description, DateTime? creatAt)
        {
            return _mapper.Map<PaymentTermsDto>(await _db.Include(i => i.PaymentTermsItems).FirstOrDefaultAsync(f => 
                (id.HasValue && id.Value.Equals(f.Id)) || 
                (!string.IsNullOrWhiteSpace(description) && f.Description.Contains(description)) ||
                (creatAt.HasValue && creatAt.Value.Date.Equals(f.CreateAt.Date))
            ));
        }
    }
}
