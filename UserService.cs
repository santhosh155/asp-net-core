using DotNetCoreAPI.Model;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace DotNetCoreAPI
{
    public class UserService
    {
        private readonly APIDbContext _context;

        public UserService(APIDbContext context)
        {
            _context = context;
        }

        public async Task<List<Users>> GetUserListAsync(RequestOption requestOption)
        {
            var record = _context.Users.AsQueryable();

            if (requestOption.SortElement != null)
            {
                var propertyName = requestOption.SortElement.PropertyName;
                var property = typeof(Users).GetProperty(propertyName);

                if (property != null)
                {
                    if (requestOption.SortElement.SortOrder == SortOrder.Ascending)
                    {
                        record = record.OrderBy(r => EF.Property<object>(r, propertyName));
                    }
                    else if (requestOption.SortElement.SortOrder == SortOrder.Descending)
                    {
                        record = record.OrderByDescending(r => EF.Property<object>(r, propertyName));
                    }
                }
            }

            return await record.ToListAsync();
        }


    }
}
