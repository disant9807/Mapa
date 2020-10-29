using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Mapa.Models.Media;

namespace Mapa.Models.Events
{
    public class EventFilesEntity
    {
        public int EventId { get; set; }
        public EventEntity Event { get; set; }

        public Guid FileId { get; set; }
        public FileEntity File { get; set; }
    }

    public class EventsFilesEntityConfiguration : IEntityTypeConfiguration<EventFilesEntity>
    {
        public void Configure(EntityTypeBuilder<EventFilesEntity> builder)
        {
            builder.HasKey(e => new { e.EventId, e.FileId });
            builder.HasOne(e => e.Event).WithMany(e => e.Files).HasForeignKey(e => e.EventId).IsRequired(false).OnDelete(DeleteBehavior.Cascade);
        }
    }
}
