using AutoMapper;
using Model;

namespace Web
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "DomainToViewModelMappings"; }
        }
        protected override void Configure()
        {
            Mapper.CreateMap<City, CityViewModel>();
            Mapper.CreateMap<Hero, HeroViewModel>();
        }
    }
}