using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Mapa.Models.Media
{
    public class FilePreviewEntity
    {
        public Guid Id { get; set; }
        /// <summary>
        /// Превью файла.
        /// </summary>
        public byte[] Preview { get; set; }
    }

    public class FilePreviewEntityConfiguration : IEntityTypeConfiguration<FilePreviewEntity>
    {
        public void Configure(EntityTypeBuilder<FilePreviewEntity> builder)
        {
            builder.ToTable("FileDatas", "media");
        }
    }
}
