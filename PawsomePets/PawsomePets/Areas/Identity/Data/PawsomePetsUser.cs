using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace PawsomePets.Areas.Identity.Data;

// Add profile data for application users by adding properties to the PawsomePetsUser class
public class PawsomePetsUser : IdentityUser
{
    public string FullName { get; set; }
    public string Address { get; set; }
}

