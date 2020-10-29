using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mapa.Models.Children;
using Mapa.Models.Events;

namespace Mapa.Models
{
    public class TagsEntity
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int? WithAge { get; set; }

        public int? UnitAge { get; set; }

        public bool? Sex { get; set; }

        public List<ChildrenTagEntity> ChildrenTags { get; set; }

        public List<EventsTagEntity> EventTags { get; set; }

    }
}
