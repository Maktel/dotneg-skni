using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace JsonParser.Parsers
{
    class ParserDataContractSerializer<T> : IParser<T>
    {
        public override T Parse(string json)
        {
            using (var ms = new MemoryStream(Encoding.Unicode.GetBytes(json)))
            {
                DataContractJsonSerializer deserializer = new DataContractJsonSerializer(typeof(T));
                return (T) deserializer.ReadObject(ms);
            }
        }
    }
}