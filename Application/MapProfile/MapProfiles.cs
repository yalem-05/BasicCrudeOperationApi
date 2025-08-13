using Application.Dto;
using AutoMapper;
using Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.MapProfile
{
    public class MapProfiles :Profile
    {
        public MapProfiles()
        {
           // CreateMap<User, UserDto>().ReverseMap();
            CreateMap<ProductUpdate, ProductDto>().ReverseMap();
        }
    }
}
