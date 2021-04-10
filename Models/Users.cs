using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace LabourZillaZone.Models
{
    public partial class Users
    {
        public string UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CityAddress { get; set; }
        public string StateC { get; set; }
        public string Lcontact { get; set; }
        public string PasswordC { get; set; }
        public string ConfirmPassword { get; set; }
        public string RoleL { get; set; }
    }
}
