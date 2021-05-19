using AutoMapper;
using Payment.Application.DTO;
using Payment.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Payment.Application.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Clients, ClientsDTO>().ReverseMap();

            //CreateMap<Delivery, DeliveryDTO>()
            //        .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
            //        .ForMember(dest => dest.DeliveryTime, opt => opt.MapFrom(src => src.DeliveryTime))
            //        .ForMember(dest => dest.DeliveryType, opt => opt.MapFrom(src => src.DeliveryType))
            //        .ForMember(dest => dest.Price, opt => opt.MapFrom(src => src.Price)).ReverseMap();
        }
    }
}
