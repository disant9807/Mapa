using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Mapa.Models.User;
using Mapa.Models.Events;
using Mapa.Models.Media;
using Mapa.Models.Organization;

namespace Mapa.Models
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {

        }

        public virtual DbSet<UserEntity> User { get; set; }
        public virtual DbSet<UserPermissionEntity> UserPermissions { get; set; }

        public virtual DbSet<UserChildrenEntity> UserChildren { get; set; }

        public virtual DbSet<EventEntity> Event { get; set; }

        public virtual DbSet<EventFilesEntity> EventFiles { get; set; }

        public virtual DbSet<EventsTagEntity> EventsTags { get; set; }

        public virtual DbSet<Models.Media.FileEntity> MediaFiles { get; set; }
        public virtual DbSet<Models.Media.DeletedFileEntity> MediaDeletedFiles { get; set; }
        public virtual DbSet<Models.Media.FileDataEntity> MediaFileDatas { get; set; }
        public virtual DbSet<Models.Media.FilePreviewEntity> MediaFileDataPreviews { get; set; }

        public virtual DbSet<OrganizationEntity> Organizations { get; set; }

        public virtual DbSet<OrganizationEventEntity> OrganizationEvents { get; set; }

        public virtual DbSet<PermissionEntity> Permissions { get; set; }

        public virtual DbSet<TagsEntity> Tags { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<IdentityRoleClaim<Guid>>(e => e.ToTable("RoleClaims", "identity"));
            modelBuilder.Entity<IdentityRole<Guid>>(e => e.ToTable("Roles", "identity"));
            modelBuilder.Entity<IdentityUserClaim<Guid>>(e => e.ToTable("UserClaims", "identity"));
            modelBuilder.Entity<IdentityRoleClaim<Guid>>(e => e.ToTable("RoleClaims", "identity"));
            modelBuilder.Entity<IdentityUserLogin<Guid>>(e => e.ToTable("UserLogins", "identity"));
            modelBuilder.Entity<IdentityUserRole<Guid>>(e => e.ToTable("UserRoles", "identity"));
            modelBuilder.Entity<IdentityUserToken<Guid>>(e => e.ToTable("UserTokens", "identity"));
            modelBuilder.Entity<IdentityUser<Guid>>(e => e.ToTable("Users", "identity"));

        }
    }
}
