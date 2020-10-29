using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Mapa.Models.Events
{
    public class EventsTagEntity
    {
        public int EventId { get; set; }
        public EventEntity Event { get; set; }

        public int TagId { get; set; }
        public TagsEntity Tag { get; set; }
    }

    public class EventsTagEntityConfiguration : IEntityTypeConfiguration<EventsTagEntity>
    {
        public void Configure(EntityTypeBuilder<EventsTagEntity> builder)
        {
            builder.HasKey(e => new { e.EventId, e.TagId });
            builder.HasOne(e => e.Event).WithMany(e => e.Tags).HasForeignKey(e => e.EventId).IsRequired(false).OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(e => e.Tag).WithMany(e => e.EventTags).HasForeignKey(e => e.TagId).IsRequired(false);
        }
    }
}
