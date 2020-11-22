using System;
using Deniz.StaffTaskManager.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Deniz.StaffTaskManager.DataAccess.Concrete.EntityFramework.Mapping
{
    public class TaskMap : IEntityTypeConfiguration<Task>
    {
        public void Configure(EntityTypeBuilder<Task> builder)
        {
            builder.HasKey(i => i.Id);
            builder.Property(i => i.Id).UseIdentityColumn();
            builder.Property(i => i.Name).HasMaxLength(200);
            builder.Property(i => i.Description).HasColumnType("ntext");


            builder.HasOne(i => i.Urgency).WithMany(i => i.Tasks).HasForeignKey(i => i.UrgencyId);
        }
    }
}
