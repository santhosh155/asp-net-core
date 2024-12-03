namespace DotNetCoreAPI.Model
{
    public class Users
    {
        public Guid Id { get; set; }
        public required string FullName { get; set; }

        public required string UserName { get; set; }

        public required string Password { get; set; }
    }
}
