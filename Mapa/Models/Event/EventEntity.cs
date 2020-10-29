using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Mapa.Models.Singles;
using Mapa.Extensions;
using Mapa.Models.Organization;

namespace Mapa.Models.Events
{
    public class EventEntity
    {
        public int Id { get; set; }

        public DateTimeOffset? PublishedAt { get; set; }

        public DateTimeOffset? DeletedAt { get; set; }

        public DateTimeOffset CreatedAt { get; set; }

        public DateTimeOffset? StartAt { get; set; }
        
        public DateTimeOffset? FinishAt { get; set; }

        public string Name { get; set; }

        public string Annotation { get; set; }

        public string Description { get; set; }

        public Location Location { get; set; }
        public string LocationJson { get => Location.ToJson(); set => Location = value.JsonTo<Location>(); }

        public Guid? Cover { get; set; }

        public int? WithAge { get; set; }

        public int? UnitAge { get; set; }

        public bool? Sex { get; set; }

        public List<EventsTagEntity> Tags { get; set; }

        public List<EventFilesEntity> Files { get; set; }

        public List<OrganizationEventEntity> Organizations { get; set; }
    }

    public class EventEntityConfiguration : IEntityTypeConfiguration<EventEntity>
    {
        public void Configure(EntityTypeBuilder<EventEntity> builder)
        {
            builder.ToTable("Events", "content");
            builder.Property(e => e.Name).IsRequired();
            builder.Property(e => e.Annotation).IsRequired();
            builder.Property(e => e.Description).IsRequired();
            builder.Ignore(p => p.Location).Property<string>("LocationJson").IsRequired();
        }
    }
}
