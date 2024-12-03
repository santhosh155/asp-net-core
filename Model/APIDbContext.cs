using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace DotNetCoreAPI.Model
{
    public class APIDbContext : DbContext
    {
        public APIDbContext(DbContextOptions option) : base(option)
        { }


        public DbSet<Users> Users { get; set; }
    }
}
