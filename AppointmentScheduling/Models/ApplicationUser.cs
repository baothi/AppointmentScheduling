using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppointmentScheduling.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }
       /* public string UserName { get; private set; }
        public string Email { get; private set; }*/
    }
}
