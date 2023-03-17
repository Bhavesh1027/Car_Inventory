using AutoMapper;
using Car.Core.Entities;
using Car.Service.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car.Service.AutoMapperProfile
{
    public class AutoMapperProfile: Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<CarInventoryDTO, CarInventory>().ReverseMap();
        }
    }
}
