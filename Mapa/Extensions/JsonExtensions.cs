using Newtonsoft.Json;

namespace Mapa.Extensions
{
    public static class JsonExtension
    {
        /// <summary>
        /// Сериализовать объект в JSON.
        /// </summary>
        /// <returns>Сериализация объекта в виде строки формата JSON.</returns>
        public static string ToJson(this object obj)
        {
            if (obj != null)
            {
                try
                {
                    return JsonConvert.SerializeObject(obj, new JsonSerializerSettings
                    {
                        NullValueHandling = NullValueHandling.Ignore
                    });
                }
                catch { }
            }
            return string.Empty;
        }

        /// <summary>
        /// Десериализовать объект из JSON.
        /// </summary>
        /// <param name="json">Сериализация объекта в виде строки формата JSON</param>
        public static T JsonTo<T>(this string json)
        {
            if (!string.IsNullOrEmpty(json))
            {
                try
                {
                    return JsonConvert.DeserializeObject<T>(json);
                }
                catch { }
            }
            return default;
        }
    }
}
