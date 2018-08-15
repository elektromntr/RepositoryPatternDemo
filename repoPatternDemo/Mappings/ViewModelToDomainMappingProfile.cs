using AutoMapper;
using Model;
using repoPatternDemo.ViewModels;

namespace Web
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "ViewModelToDomainMappings"; }
        }
        public override void Configure()
        {
            Mapper.CreateMap<HeroFormViewModel, Hero>()
                .ForMember(h => h.Name, map => map.MapFrom(vm => vm.HeroName))
                .ForMember(h => h.Age, map => map.MapFrom(vm => vm.HeroAge))
                .ForMember(h => h.Fitness, map => map.MapFrom(vm => vm.HeroFitness))
                .ForMember(h => h.Mind, map => map.MapFrom(vm => vm.HeroMind))
                .ForMember(h => h.Empathy, map => map.MapFrom(vm => vm.HeroEmpathy))
                .ForMember(h => h.City, map => map.MapFrom(vm => vm.HeroCity));
        }
    }
}