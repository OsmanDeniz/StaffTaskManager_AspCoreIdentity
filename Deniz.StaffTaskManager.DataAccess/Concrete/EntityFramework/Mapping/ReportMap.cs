using System;
using Deniz.StaffTaskManager.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Deniz.StaffTaskManager.DataAccess.Concrete.EntityFramework.Mapping
{
    public class ReportMap : IEntityTypeConfiguration<Report>
    {
        public void Configure(EntityTypeBuilder<Report> builder)
        {
            builder.HasKey(i => i.Id);
            builder.Property(i => i.Id).UseIdentityColumn();
            builder.Property(i => i.ReportStatus).HasMaxLength(100).IsRequired();
            builder.Property(i => i.ReportStatus).HasColumnType("ntext");

            builder.HasOne(i => i.Task).WithMany(i => i.Reports).HasForeignKey(i => i.TaskId);
        }
    }
}
