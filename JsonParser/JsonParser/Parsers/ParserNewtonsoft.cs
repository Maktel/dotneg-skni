using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JsonParser.Models;
using Newtonsoft.Json;

namespace JsonParser.Parsers
{
    internal class ParserNewtonsoft<T> : IParser<T>
    {
        public override T Parse(string json)
        {
            return JsonConvert.DeserializeObject<T>(json);
        }
    }
}
