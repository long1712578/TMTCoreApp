using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using TMTCoreApp.Data.EF.Extensions;
using TMTCoreApp.Data.Entities;

namespace TMTCoreApp.Data.EF.Configurations
{
    public class ProductConfiguration: DbEntityConfiguration<Product>
    {
        public override void Configure(EntityTypeBuilder<Product> entity)
        {
            entity.Property(b => b.SeoAlias).HasColumnType("varchar");
            // etc.
        }
    }
}
