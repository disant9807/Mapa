using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Mapa.Models;

namespace Mapa.Models.User
{
    public class UserPermissionEntity
    {
        public int UserId { get; set; }
        public UserEntity User { get; set; }

        public int PermissionId { get; set; }
        public PermissionEntity Permission { get; set; }
    }

    public class EventTagEntityConfiguration : IEntityTypeConfiguration<UserPermissionEntity>
    {
        public void Configure(EntityTypeBuilder<UserPermissionEntity> builder)
        {
            builder.HasKey(e => new { e.UserId, e.PermissionId });
            builder.HasOne(e => e.User).WithMany(e => e.Permissions).HasForeignKey(e => e.UserId).IsRequired(false).OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(e => e.Permission).WithMany(e => e.Users).HasForeignKey(e => e.PermissionId).IsRequired(false);
        }
    }
}
