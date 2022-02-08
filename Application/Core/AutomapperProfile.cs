using AutoMapper;
using Domain;

namespace Application.Core
{
    public class AutomapperProfile : Profile
    {
        public AutomapperProfile()
        {
            CreateMap<Activity,Activity>();
        }
    }
}