using book_store.API.Models;
using FluentResults;

namespace book_store.API.Services.Interfaces
{
    public interface IUserService
    {
        Task<Result> CreateUser(User user);
    }
}
