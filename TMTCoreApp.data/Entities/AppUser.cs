using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using TMTCoreApp.Data.Enums;
using TMTCoreApp.Data.Interfaces;

namespace TMTCoreApp.Data.Entities
{
    [Table("AppUsers")]
    public class AppUser : IdentityUser<Guid>, IdateTracking, ISWitchable
    {
        public string FullName { get; set; }
        public DateTime? BirthDay { get; set; }
        public decimal Balance { get; set; }
        public string Avatar { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public Status Status { get; set; }
    }
}
