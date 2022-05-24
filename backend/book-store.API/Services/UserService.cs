using book_store.API.Data.Context;
using book_store.API.Models;
using book_store.API.Services.Interfaces;
using FluentResults;

namespace book_store.API.Services
{
    public class UserService : IUserService
    {
        private DataContext _context;
        public UserService(DataContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }
        public async Task<Result> CreateUser(User user)
        {
            _context.Users.Add(user);
            await _context.SaveChangesAsync();
            return Result.Ok().WithSuccess("User was saved with success!");
        }
    }
}
