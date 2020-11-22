using System;
using Deniz.StaffTaskManager.Entities.Concrete;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Deniz.StaffTaskManager.DataAccess.Concrete.EntityFramework.Mapping
{
    public class UrgencyMap : Microsoft.EntityFrameworkCore.IEntityTypeConfiguration<Urgency>
    {
        public void Configure(EntityTypeBuilder<Urgency> builder)
        {
            builder.Property(i => i.UrgencyLevel).HasMaxLength(50);
        }
    }
}
