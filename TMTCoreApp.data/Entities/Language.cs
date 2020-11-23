
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using TMTCoreApp.Infrastructure.ShareKenel;
using TMTCoreApp.Data.Interfaces;
using TMTCoreApp.Data.Enums;

namespace TMTCoreApp.Data.Entities
{
    [Table("Languages")]
    public class Language : DomainEntity<string>, ISWitchable
    {
        [Required]
        [StringLength(128)]
        public string Name { get; set; }

        public bool IsDefault { get; set; }

        public string Resources { get; set; }

        public Status Status { get; set; }
    }
}
