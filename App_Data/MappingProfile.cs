using AutoMapper;
using SurfersLand.Dtos;
using SurfersLand.Models;

namespace SurfersLand.App_Data
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<Customer, CustomerDto>();
            CreateMap<CustomerDto, Customer>();
        }
    }
}