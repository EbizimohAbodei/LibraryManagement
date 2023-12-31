using AutoMapper;
using WebApi.Business.src.Dto;
using WebApi.Domain.src.Entities;

namespace WebApi.Infrastructure.src.Configuration
{
    public class MapperProfile : Profile
    {
      public MapperProfile()
      {
        CreateMap<Book, BookDto>()
          .ForMember(destinationMember: dest => dest.Genre, memberOptions: opt => opt.MapFrom(src => $"{src.Genre}")).ReverseMap();
        CreateMap<Book, BookReadDto>()
          .ForMember(destinationMember: dest => dest.Genre, memberOptions: opt => opt.MapFrom(src => $"{src.Genre}")).ReverseMap();
        CreateMap<User, UserReadDto>()
          .ForMember(dest => dest.FirstName, opt => opt.MapFrom(src => $"{src.FirstName}"))
          .ForMember(dest => dest.LastName, opt => opt.MapFrom(src => $"{src.LastName}"))
          .ForMember(dest => dest.Avatar, opt => opt.MapFrom(src => $"{src.Image}"))
          .ForMember(dest => dest.Role, opt => opt.MapFrom(src => $"{src.Role}"))
          .ForMember(dest => dest.Gender, opt => opt.MapFrom(src => $"{src.Gender.ToString()}"))
          .ReverseMap();
        CreateMap<UserUpdateDto, User>()
          .ForMember(dest => dest.FirstName, opt => opt.MapFrom(src => $"{src.FirstName}"))
          .ForMember(dest => dest.LastName, opt => opt.MapFrom(src => $"{src.LastName}"))
          .ForMember(dest => dest.Image, opt => opt.MapFrom(src => $"{src.Image}"))
          .ReverseMap();
        CreateMap<UserCreateDto, User>()
          .ForMember(dest => dest.FirstName, opt => opt.MapFrom(src => $"{src.FirstName}"))
          .ForMember(dest => dest.LastName, opt => opt.MapFrom(src => $"{src.LastName}"))
          .ForMember(dest => dest.Image, opt => opt.MapFrom(src => $"{src.Avatar}"))
          .ForMember(dest => dest.Gender, opt => opt.MapFrom(src => $"{src.Gender}"))
          .ReverseMap();
        CreateMap<Review, ReviewDto>()
          .ForMember(destinationMember: dest => dest.Firstname, opt => opt.MapFrom(src => $"{src.User.FirstName}"))
          .ForMember(destinationMember: dest => dest.Lastname, opt => opt.MapFrom(src => $"{src.User.LastName}"))
        .ReverseMap();
        }
    }
}