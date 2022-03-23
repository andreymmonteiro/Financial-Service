using AutoMapper;
using Financial.Domain.Mapper;
using Financial.Domain.Mapper.Interface;

namespace Financial.Service.AutoMapperConfigure
{
    public class AutoMapperFixtureService : IMapperService
    {
        public IMapper GetMapper()
        {
            var config = new AutoMapper.MapperConfiguration(mapper =>
                mapper.AddProfile(new EntityToDto()));
            return config.CreateMapper();
        }
    }
}
