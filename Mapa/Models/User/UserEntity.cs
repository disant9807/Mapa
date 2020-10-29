using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Linq;
using System.Threading.Tasks;
using Mapa.Models.Children;

namespace Mapa.Models.User
{
    public class UserEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<UserChildrenEntity> Childrens { get; set; }

        public List<UserPermissionEntity> Permissions { get; set; }
    }

}
