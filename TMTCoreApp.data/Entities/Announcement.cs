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
    [Table("Announcements")]
    public class Announcement : DomainEntity<string>, ISWitchable, IdateTracking
    {
        public Announcement()
        {
            AnnouncementUsers = new List<AnnouncementUser>();
        }

        public Announcement(string title, string content, Guid userId, Status status)
        {
            Title = title;
            Content = content;
            UserId = userId;
            Status = status;
        }

        [Required]
        [StringLength(250)]
        public string Title { set; get; }

        [StringLength(250)]
        public string Content { set; get; }

        public Guid UserId { set; get; }

        //[ForeignKey("UserId")]
        // public virtual AppUser AppUser { get; set; }

        public virtual ICollection<AnnouncementUser> AnnouncementUsers { get; set; }
        public DateTime DateCreated { set; get; }
        public DateTime DateModified { set; get; }
        public Status Status { set; get; }
    }
}
