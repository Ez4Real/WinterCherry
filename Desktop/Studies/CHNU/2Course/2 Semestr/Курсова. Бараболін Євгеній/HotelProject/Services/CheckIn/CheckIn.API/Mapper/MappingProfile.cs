using AutoMapper;
using Booking.API.DTO;

namespace Booking.API.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Entities.CheckIn, CheckInDTO>().ReverseMap();

            //CreateMap<Delivery, DeliveryDTO>()
            //        .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
            //        .ForMember(dest => dest.DeliveryTime, opt => opt.MapFrom(src => src.DeliveryTime))
            //        .ForMember(dest => dest.DeliveryType, opt => opt.MapFrom(src => src.DeliveryType))
            //        .ForMember(dest => dest.Price, opt => opt.MapFrom(src => src.Price)).ReverseMap();
        }
    }
}
