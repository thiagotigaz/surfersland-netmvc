using AutoMapper;
using SurfersLand.Dtos;
using SurfersLand.Models;

namespace SurfersLand.App_Data
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Customer, CustomerDto>();
            CreateMap<CustomerDto, Customer>().ForMember(c => c.Id, opt => opt.Ignore());
            CreateMap<Board, BoardDto>();
            CreateMap<BoardDto, Board>().ForMember(b => b.Id, opt => opt.Ignore());
        }
    }
}