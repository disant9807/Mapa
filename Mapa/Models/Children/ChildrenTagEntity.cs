using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Mapa.Models.Children
{
    public class ChildrenTagEntity
    {
        public int ChildrenId { get; set; }
        public ChildrenEntity Children { get; set; }

        public int TagId { get; set; }
        public TagsEntity Tag { get; set; }
    }

    public class ChildrenTagEntityConfiguration : IEntityTypeConfiguration<ChildrenTagEntity>
    {
        public void Configure(EntityTypeBuilder<ChildrenTagEntity> builder)
        {
            builder.HasKey(e => new { e.ChildrenId, e.TagId });
            builder.HasOne(e => e.Children).WithMany(e => e.Tags).HasForeignKey(e => e.ChildrenId).IsRequired(false).OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(e => e.Tag).WithMany(e => e.ChildrenTags).HasForeignKey(e => e.TagId).IsRequired(false);
        }
    }
}
