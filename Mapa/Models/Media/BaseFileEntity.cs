using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mapa.Models.Media
{
    public abstract class BaseFileEntity
    {
        public Guid Id { get; set; }
        /// <summary>
        /// Полное имя файла с расширением.
        /// </summary>
        public string FullName { get; set; }

        /// <summary>
        /// Расширение файла.
        /// </summary>
        public string Extension { get; set; }

        /// <summary>
        /// Отображаемое имя файла.
        /// </summary>
        public string DisplayName { get; set; }

        /// <summary>
        /// Дополнительные атрибуты файла.
        /// </summary>
        public string Attributes { get; set; }

        /// <summary>
        /// Дата создания.
        /// </summary>
        public DateTimeOffset CreationDate { get; set; }

        /// <summary>
        /// Идентификатор пользователя, загрузившего файл.
        /// </summary>
        public Guid CreatorID { get; set; }

        /// <summary>
        /// Размер файла в байтах.
        /// </summary>
        public int Size { get; set; }

        /// <summary>
        /// Ширина в пикселях. Относится только к изображениям (видео).
        /// </summary>
        public int? Width { get; set; }

        /// <summary>
        /// Высота в пикселях. Относится только к изображениям (видео).
        /// </summary>
        public int? Height { get; set; }

        /// <summary>
        /// Есть ли у файла превью-картинка.
        /// </summary>
        public bool HasPreview { get; set; }
    }
}
