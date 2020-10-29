using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mapa.Models.User;

namespace Mapa.Models.Children
{
    public class ChildrenEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int? WithAge { get; set; }

        public int? UnitAge { get; set; }

        public DateTimeOffset? BirthDate { get; set; }

        public bool? Sex { get; set; }

        public List<UserChildrenEntity> Users { get; set; }

        public List<ChildrenTagEntity> Tags { get; set; }
    }
}
