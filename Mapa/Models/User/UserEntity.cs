using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mapa.Models.Children;

namespace Mapa.Models.User
{
    public class UserEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public string Login { get; set; }

        public string Password { get; set; }

        public DateTimeOffset? CreatedAt { get; set; }

        public DateTimeOffset? DeletedAt { get; set; }

        public bool? Sex { get; set; }

        public List<UserChildrenEntity> Childrens { get; set; }

        public List<UserPermissionEntity> Permissions { get; set; }
    }
}
