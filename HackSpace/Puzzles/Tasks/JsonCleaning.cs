using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Puzzles.Tasks
{
    public class JsonCleaning
    {
        public void JsonCleaningMain()
        {
            HashSet<int> hy = new HashSet<int>();
            WebRequest request = WebRequest.Create("https://coderbyte.com/api/challenges/json/json-cleaning");
            WebResponse response = request.GetResponse();
            var responseStream = response.GetResponseStream();
            var streamReader = new StreamReader(responseStream);
            var jsonString = streamReader.ReadToEnd();
            streamReader.Close();
            responseStream.Close();
            response.Close();
            var emptyValues = "(\"\"|\"[-]\")";
            var placeholder = "\"empty\"";
            var emptyKeyValuePair = "(\"[a-zA-Z]+\":\"empty\",|,\"[a-zA-Z]+\":\"empty\")";
            var emptyArray = "(\"empty\",|,\"empty\")";
            var result = Regex.Replace(jsonString, emptyValues, placeholder);
            result = result.Replace(@"N\/A", "empty");
            result = Regex.Replace(result, emptyKeyValuePair, string.Empty);
            result = Regex.Replace(result, emptyArray, string.Empty);
            Console.WriteLine(result);
        }
    }
}
