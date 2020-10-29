using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;


namespace Mapa.Models.Media
{
    public class DeletedFileEntity : BaseFileEntity
    {
        /// <summary>
        /// Дата помещения файла в корзину.
        /// </summary>
        public DateTimeOffset DeletionDate { get; set; }
    }

    public class DeletedFileEntityConfiguration : IEntityTypeConfiguration<DeletedFileEntity>
    {
        public void Configure(EntityTypeBuilder<DeletedFileEntity> builder)
        {
            builder.ToTable("DeletedFiles", "media");

            builder.Property(e => e.FullName).IsRequired();
            builder.Property(e => e.Extension).IsRequired();
            builder.Property(e => e.DisplayName).IsRequired();
        }
    }
}
