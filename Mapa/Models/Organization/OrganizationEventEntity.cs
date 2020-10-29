using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using Mapa.Models.Events;

namespace Mapa.Models.Organization
{
    public class OrganizationEventEntity
    {
        public int OrganizationId { get; set; }
        public OrganizationEntity Organization { get; set; }

        public int EventId { get; set; }
        public EventEntity Event { get; set; }
    }

    public class EventsTagEntityConfiguration : IEntityTypeConfiguration<OrganizationEventEntity>
    {
        public void Configure(EntityTypeBuilder<OrganizationEventEntity> builder)
        {
            builder.HasKey(e => new { e.OrganizationId, e.EventId });
            builder.HasOne(e => e.Organization).WithMany(e => e.Events).HasForeignKey(e => e.EventId).IsRequired(false).OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(e => e.Event).WithMany(e => e.Organizations).HasForeignKey(e => e.OrganizationId).IsRequired(false);
        }
    }
}
