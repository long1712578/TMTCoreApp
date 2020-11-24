using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using TMTCoreApp.Infrastructure.ShareKenel;

namespace TMTCoreApp.Data.Entities
{
    [Table("AdvertistmentPositions")]
    public class AdvertistmentPosition : DomainEntity<string>
    {
        [StringLength(20)]
        [ForeignKey("PageId")]
        public string PageId { get; set; }

        [StringLength(250)]
        public string Name { get; set; }
        
        public virtual AdvertistmentPage AdvertistmentPage { get; set; }

        public virtual ICollection<Advertistment> Advertistments { get; set; }
    }
}
