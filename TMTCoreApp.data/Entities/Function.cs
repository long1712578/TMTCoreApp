using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using TMTCoreApp.Data.Enums;
using TMTCoreApp.Data.Interfaces;
using TMTCoreApp.Infrastructure.ShareKenel;

namespace TMTCoreApp.Data.Entities
{
    [Table("Functions")]
    public class Function : DomainEntity<string>, ISWitchable, ISortTable
    {
        public Function()
        {

        }
        public Function(string name, string url, string parentId, string iconCss, int sortOrder)
        {
            Name = name;
            URL = url;
            ParentId = parentId;
            IconCss = iconCss;
            SortOrder = sortOrder;
            Status = Status.Active;
        }
        [Required]
        [StringLength(128)]
        public string Name { set; get; }

        [Required]
        [StringLength(250)]
        public string URL { set; get; }


        [StringLength(128)]
        public string ParentId { set; get; }

        public string IconCss { get; set; }
        public int SortOrder { set; get; }
        public Status Status { set; get; }
    }
}
