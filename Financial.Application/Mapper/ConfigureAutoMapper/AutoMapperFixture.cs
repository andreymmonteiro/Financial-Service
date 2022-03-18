using AutoMapper;
using Financial.Aplpication.Mapper.ConfigureAutoMapper.Interface;

namespace Financial.Application.Mapper.ConfigureAutoMapper
{
    public class AutoMapperFixture : IMapperService
    {

        public AutoMapperFixture() 
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
