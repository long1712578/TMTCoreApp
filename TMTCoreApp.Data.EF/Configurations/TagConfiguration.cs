using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using TMTCoreApp.Data.EF.Extensions;
using TMTCoreApp.Data.Entities;

namespace TMTCoreApp.Data.EF.Configurations
{
    public class TagConfiguration : DbEntityConfiguration<Tag>
    {
        public override void Configure(EntityTypeBuilder<Tag> entity)
        {
            entity.Property(c => c.Id).HasMaxLength(50)
                .IsRequired().IsUnicode(false).HasMaxLength(50);
        }
    }
}
