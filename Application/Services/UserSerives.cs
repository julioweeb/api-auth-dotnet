using api_auth.Data;
using api_auth.Domain.Entities;

namespace api_auth.Application.Services
{
    public class UserSerives
    {

        private readonly AppDbContext _context;

        public UserSerives(AppDbContext context)
        {
            _context = context;
        }

        public async Task<User?> GetByIdAsync(Guid Id)
        {
            return await _context.Users.FindAsync(Id);
        }
    }
}
