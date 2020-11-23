using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using TMTCoreApp.Data.Enums;
using TMTCoreApp.Data.Interfaces;
using TMTCoreApp.Infrastructure.ShareKenel;

namespace TMTCoreApp.Data.Entities
{
    [Table("Products")]
    public class Product : DomainEntity<int>, ISWitchable, IdateTracking, IHasSeoMeteData
    {
        
        [StringLength(255)]
        [Required]
        public string Name { get; set; }
        [Required]
        public int CategoryId { get; set; }
        [StringLength(255)]
        public string Image { get; set; }
        [Required]
        [DefaultValue(0)]
        public decimal Price { get; set; }
        public decimal PromotionPrice { get; set; }
        [Required]
        public decimal OriginalPrice { get; set; }
        [StringLength(255)]
        public string Decription { get; set; }
        [StringLength(255)]
        public string Content { get; set; }
        public bool? HomeFlat { get; set; }
        public bool HotFlag { get; set; }
        public int? ViewCount { get; set; }
        [StringLength(255)]
        public string Tags { get; set; }
        public string Unit { get; set; }
        [ForeignKey("CategoryId")]
        public virtual ProductCategory ProductCategory { set; get; }
        public Status Status { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public string SeoPageTitle { get; set; }
        [Column(TypeName ="varchar")]
        [StringLength(255)]
        public string SeoAlias { get; set; }
        [StringLength(255)]
        public string SeoKeywords { get; set; }
        [StringLength(255)]
        public string SeoDescription { get; set; }
        
    }
}
