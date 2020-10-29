using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Mapa.Models.Media
{
    public class FileDataEntity
    {
        public Guid Id { get; set; }


        /// <summary>
        /// Превью файла.
        /// </summary>
        public FilePreviewEntity Preview { get; set; }

        /// <summary>
        /// Данные файла.
        /// </summary>
        public byte[] Data { get; set; }
    }

    public class FileDataEntityConfiguration : IEntityTypeConfiguration<FileDataEntity>
    {
        public void Configure(EntityTypeBuilder<FileDataEntity> builder)
        {
            builder.ToTable("FileDatas", "media");
            builder.HasOne(e => e.Preview).WithOne().HasForeignKey<FilePreviewEntity>(e => e.Id);
        }
    }
}
