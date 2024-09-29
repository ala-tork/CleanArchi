using AutoMapper;
using CleanArchi.Core.DTO;
using CleanArchi.Core.Entities;


namespace CleanArchi.Core
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile() 
        {
            CreateMap<Product , ProductDto>().ReverseMap();
            CreateMap<Category, CategoryDto>().ReverseMap();
        }
    }
}
