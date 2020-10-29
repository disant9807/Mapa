using System.Globalization;


namespace Mapa.Models.Singles
{
    public class Location
    {
        /// <summary>
        /// Широта.
        /// </summary>
        public double? Latitude { get; set; }

        /// <summary>
        /// Долгота.
        /// </summary>
        public double? Longitude { get; set; }

        /// <summary>
        /// Какая-то дополнительная информация: Адрес или описание местоположения.
        /// </summary>
        public string Info { get; set; }

        public override string ToString()
        {
            var nfi = CultureInfo.InvariantCulture.NumberFormat;
            return $"[{Latitude?.ToString(nfi)}, {Longitude?.ToString(nfi)}] {Info}";
        }

        public static Location Empty => new Location();
    }
}
