using Microsoft.Extensions.Primitives;

namespace AuthenticationWithoutIdentityNet8.Models.Enities
{
    public class User
    {
        public Guid Id { get; set; }
        public string?  UserName { get; set; } 
        public string?  Password { get; set;} 
        public string?  Fullname { get; set;} 
        public string?  Email { get; set;} 
    }
}
