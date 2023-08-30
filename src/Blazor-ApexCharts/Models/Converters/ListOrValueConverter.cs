using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ApexCharts.Models
{
    internal class ListOrValueConverter<T> : JsonConverter<IList<T>>
    {
        public override IList<T> Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            throw new NotImplementedException();
        }

        public override void Write(Utf8JsonWriter writer, IList<T> value, JsonSerializerOptions options)
        {
            if (value == null || value.Count == 0)
            {
                JsonSerializer.Serialize(writer, null, options);
            }
            else if (value.Count == 1)
            {
                JsonSerializer.Serialize(writer, value[0], typeof(T), options);
            }
            else
            {
                JsonSerializer.Serialize(writer, value, options);
            }
        }
    }
}
