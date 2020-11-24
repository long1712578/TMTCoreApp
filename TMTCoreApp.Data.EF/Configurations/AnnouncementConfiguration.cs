using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using TMTCoreApp.Data.EF.Extensions;
using TMTCoreApp.Data.Entities;

namespace TMTCoreApp.Data.EF.Configurations
{
    class AnnouncementConfiguration : DbEntityConfiguration<Announcement>
    {
        public override void Configure(EntityTypeBuilder<Announcement> entity)
        {
            entity.HasKey(x => x.Id);
            entity.Property(c => c.Id).HasMaxLength(128).IsRequired();
            // etc.
        }
    }

}
