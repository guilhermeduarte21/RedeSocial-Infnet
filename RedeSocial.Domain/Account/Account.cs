
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;

namespace RedeSocial.Domain.Account
{
    public class Account : IdentityUser
    {
        public Guid Id { get; set; }
        public String Name { get; set; }
        public DateTime DtBirthday { get; set; }
        public String Email { get; set; }       
        public String Password { get; set; }
    }
}
