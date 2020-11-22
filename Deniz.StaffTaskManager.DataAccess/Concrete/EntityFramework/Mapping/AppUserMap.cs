using System;
using Deniz.StaffTaskManager.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Deniz.StaffTaskManager.DataAccess.Concrete.EntityFramework.Mapping
{
   public class AppUserMap : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> builder)
        {
            builder.Property(i => i.Name).HasMaxLength(100);
            builder.Property(i => i.Surname).HasMaxLength(100);

            /// Tabloda iliski kurmak icin 
            /// suan app userda oldugumuz icin bu acidan bakinca
            /// cok olan ne appuser in gorevleri, tek olan appuser,ikisi arasindaki foreign key appuserid, silinmesi duurmunda da null olarak ayarla kullaniciyi.
            builder.HasMany(i => i.Tasks).WithOne(i => i.AppUser).HasForeignKey(i => i.AppUserId).OnDelete(DeleteBehavior.SetNull);
        }
    }
}
