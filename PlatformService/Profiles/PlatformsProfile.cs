using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using PlatformService.Dtos;
using PlatformService.Models;

namespace PlatformService.Profiles
{
    public class PlatformsProfile : Profile
    {
        public PlatformsProfile()
        {
            // Source(Data) -> Target(Dto)... GET
            CreateMap<Platform, PlatformReadDto>();
            
            // Source(Dto) -> Target(Data)... POST/PUT/PATCH/DELETE
            CreateMap<PlatformCreateDto, Platform>();
        }
    }
}