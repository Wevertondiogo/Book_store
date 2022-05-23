using AutoMapper;
using book_store.API.Data.Dtos.User;
using book_store.API.Models;

namespace book_store.API.Profiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<User, ReadUserDTO>();
        }
    }
}
