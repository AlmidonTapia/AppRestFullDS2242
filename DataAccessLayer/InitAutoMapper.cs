using AutoMapper;
using DataAccessLayer.Entity;
using DataTransferLayer.Objects;

namespace DataAccessLayer
{
    public static class InitAutoMapper
    {
        private static bool _initMapper = true;
        public static IMapper mapper;

        public static void Start()
        {
            if (_initMapper)
            {
                MapperConfiguration configuration = new MapperConfiguration(cfg =>
                {
                    cfg.CreateMap<TPerson, PersonDto>().MaxDepth(3);
                    cfg.CreateMap<PersonDto, TPerson>().MaxDepth(3);
                });
                mapper = configuration.CreateMapper();
                _initMapper = false;
            }
        }
    }
}
