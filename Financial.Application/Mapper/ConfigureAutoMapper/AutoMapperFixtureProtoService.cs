using AutoMapper;
using Financial.Aplpication.Mapper.ConfigureAutoMapper.Interface;

namespace Financial.Application.Mapper.ConfigureAutoMapper
{
    public class AutoMapperFixtureProtoService : IMapperProtoService
    {

        public AutoMapperFixtureProtoService() 
        {
            GetMapper();
        }

        public IMapper GetMapper()
        {
            var config = new AutoMapper.MapperConfiguration(mapper =>
            mapper.AddProfile(new EntityToDto()));

            return config.CreateMapper();
        }
    }
}
