using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mapa.Models.Organization
{
    public class OrganizationEntity
    {
        public DateTimeOffset? DeletedAt { get; set; }

        public DateTimeOffset CreatedAt { get; set; }

        public string Name { get; set; }

        public int Id { get; set; }

        public Guid? Cover { get; set; }

        public string Description { get; set; }

        public string Annotation { get; set; }

        public List<OrganizationEventEntity> Events { get; set; }
    }
}
