using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Mapa.Models.Media
{
    public class FileEntity : BaseFileEntity
    {
    }

    public class FileEntityConfiguration : IEntityTypeConfiguration<FileEntity>
    {
        public void Configure(EntityTypeBuilder<FileEntity> builder)
        {
            builder.ToTable("Files", "media");

            builder.Property(e => e.FullName).IsRequired();
            builder.Property(e => e.Extension).IsRequired();
            builder.Property(e => e.DisplayName).IsRequired();
        }
    }
}
