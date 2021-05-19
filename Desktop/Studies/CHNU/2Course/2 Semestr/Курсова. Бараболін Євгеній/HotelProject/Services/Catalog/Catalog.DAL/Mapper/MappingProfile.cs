using AutoMapper;
using Catalog.DAL.DTO;
using Catalog.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Catalog.API.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Rooms, MappingProfile>().ReverseMap();
            CreateMap<RoomImages, RoomImagesDTO>().ReverseMap();

            //CreateMap<Delivery, DeliveryDTO>()
            //        .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
            //        .ForMember(dest => dest.DeliveryTime, opt => opt.MapFrom(src => src.DeliveryTime))
            //        .ForMember(dest => dest.DeliveryType, opt => opt.MapFrom(src => src.DeliveryType))
            //        .ForMember(dest => dest.Price, opt => opt.MapFrom(src => src.Price)).ReverseMap();
        }

    }
}