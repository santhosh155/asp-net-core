using DotNetCoreAPI.Model;
using Microsoft.EntityFrameworkCore;

namespace DotNetCoreAPI
{
    public class UserService
    {
        private readonly APIDbContext _context;

        public UserService(APIDbContext context)
        {
            _context = context;
        }

        public async Task<List<Users>> GetUserListAsync()
        {
            return await _context.Users.OrderBy(r => r.FullName).ToListAsync();
        }

    }
}
