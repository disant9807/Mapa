using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
}
