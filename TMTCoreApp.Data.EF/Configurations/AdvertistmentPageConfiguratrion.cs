using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using TMTCoreApp.Data.EF.Extensions;
using TMTCoreApp.Data.Entities;

namespace TMTCoreApp.Data.EF.Configurations
{
    class AdvertistmentPageConfiguratrion : DbEntityConfiguration<AdvertistmentPage>
    {
        public override void Configure(EntityTypeBuilder<AdvertistmentPage> entity)
        {
            entity.HasKey(x=>x.Id);
            entity.Property(c => c.Id).HasMaxLength(20).IsRequired();
            // etc.
        }
    }
}
