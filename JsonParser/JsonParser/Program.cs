using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using JsonParser.Models;
using JsonParser.Parsers;
using Newtonsoft.Json;

namespace JsonParser
{
    internal static class Program
    {
        private const string Filepath = @"../../generated.json";

        private static void Main(string[] args)
        {
            string json = File.ReadAllText(Filepath);

            IParser<List<Person>> parser = new ParserNewtonsoft<List<Person>>();
//            IParser<Person> parser = new ParserDataContractSerializer<Person>();
//            IParser<Person> parser = new ParserJavaScriptSerializer<Person>();

            List<Person> persons = parser.Parse(json);

            var averageAge = 0;
            foreach (var person in persons)
            {
                averageAge += person.Age;
                Console.WriteLine("Age: {0}", person.Age);
                Console.WriteLine("Greeting: {0}", person.Greeting);
            }

            Console.WriteLine("Average age: {0}", averageAge / persons.Count);
        }
    }
}