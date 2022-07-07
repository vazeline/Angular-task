using AutoMapper;
using WebAPI.Entity;
using WebAPI.Models;

namespace WebAPI
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<IBackery, BackeryItem>().ForMember(m => m.InitPrice, opt => opt.MapFrom(m => m.InitialPrice))
                .ForMember(m => m.CurrentPrice, opt => opt.MapFrom(m => m.Price))
                .ForMember(m => m.NextPrice, opt => opt.MapFrom(m => m.NextPrice))
                .ForMember(m => m.NextPriceTime, opt => opt.MapFrom(m => m.NextPriceTime))
                .ForMember(m => m.ItemType, opt => opt.MapFrom(m => m.GetType().Name));
        }
    }
}
