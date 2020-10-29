using System;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Mapa.Models.User;
using Mapa.Models.Events;
using Mapa.Models.Media;
using Mapa.Models.Organization;

namespace Mapa.Models
{
    public class Context : IdentityDbContext<IdentityUser<Guid>, IdentityRole<Guid>, Guid>
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

            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);

            modelBuilder.Entity<IdentityRoleClaim<Guid>>(e => e.ToTable("ERoleClaims", "identity"));
            modelBuilder.Entity<IdentityRole<Guid>>(e => e.ToTable("ERoles", "identity"));
            modelBuilder.Entity<IdentityUserClaim<Guid>>(e => e.ToTable("EUserClaims", "identity"));
            modelBuilder.Entity<IdentityRoleClaim<Guid>>(e => e.ToTable("ERoleClaims", "identity"));
            modelBuilder.Entity<IdentityUserLogin<Guid>>(e => e.ToTable("EUserLogins", "identity"));
            modelBuilder.Entity<IdentityUserRole<Guid>>(e => e.ToTable("EUserRoles", "identity"));
            modelBuilder.Entity<IdentityUserToken<Guid>>(e => e.ToTable("EUserTokens", "identity"));
            modelBuilder.Entity<IdentityUser<Guid>>(e => e.ToTable("EUsers", "identity"));

        }
    }
}
