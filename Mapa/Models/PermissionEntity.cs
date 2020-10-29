using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mapa.Models.User;

namespace Mapa.Models
{
    public class PermissionEntity
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public List<UserPermissionEntity> Users { get; set; }
    }
}
