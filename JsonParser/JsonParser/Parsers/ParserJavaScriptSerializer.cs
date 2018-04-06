using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace JsonParser.Parsers
{
    class ParserJavaScriptSerializer<T> : IParser<T>
    {
        public override T Parse(string json)
        {
            return new JavaScriptSerializer().Deserialize<T>(json);
        }
    }
}
