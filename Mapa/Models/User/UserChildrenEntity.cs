using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Mapa.Models.Children;

namespace Mapa.Models.User
{
    public class UserChildrenEntity
    {
        public int UserId { get; set; }
        public UserEntity User { get; set; }

        public int ChildrenId { get; set; }
        public ChildrenEntity Children { get; set; }
    }
    public class UserChildrensEntityConfiguration : IEntityTypeConfiguration<UserChildrenEntity>
    {
        public void Configure(EntityTypeBuilder<UserChildrenEntity> builder)
        {
            builder.HasKey(e => new { e.UserId, e.ChildrenId });
            builder.HasOne(e => e.User).WithMany(e => e.Childrens).HasForeignKey(e => e.UserId).IsRequired(false).OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(e => e.Children).WithMany(e => e.Users).HasForeignKey(e => e.ChildrenId).IsRequired(false);
        }
    }
}
