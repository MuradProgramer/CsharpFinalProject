using CsharpFinaProject.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CsharpFinaProject.JSON_Control
{
    public class JsonEditor
    {
        public static void JsonSerializeEmployers(object? collection)
        {
            var str = JsonConvert.SerializeObject(collection, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText("employers.json", str);
        }
        public static object? JsonDeSerializeEmployers()
        {
            var jsonStr = File.ReadAllText("employers.json");
            return JsonConvert.DeserializeObject<List<Employer>>(jsonStr);
        }

        public static void JsonSerializeWorker(object? collection)
        {
            var str = JsonConvert.SerializeObject(collection, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText("workers.json", str);
        }
        public static object? JsonDeSerializeWorker()
        {
            var jsonStr = File.ReadAllText("workers.json");
            return JsonConvert.DeserializeObject<List<Worker>>(jsonStr);
        }
    }
}
