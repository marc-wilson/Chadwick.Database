using System;
using Microsoft.AspNetCore.Identity;

namespace Chadwick.Database.Models
{
    public class ChadwickUser : IdentityUser
    {
        public DateTime Created { get; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public ChadwickUser()
        {
            Created = DateTime.UtcNow;
        }
    }
}