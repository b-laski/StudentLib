using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentAPI.Models.API.Categorie;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace StudentAPI.Models.API.Categorie
{
    public class Categorie
    {
        public static int ID { get; set; }
        public static string Name { get; set; }
        public static List<string> GroupList { get; set; }

        public Categorie(JObject json)
        {
            int id;
            
            if (int.TryParse(json.SelectToken("id").ToString(), out id)) ID = id;

            Name = json.SelectToken("name").ToString();
            GroupList = JsonConvert.DeserializeObject<List<string>>(json.SelectToken("dependencies").ToString());
        }

        private string MakeString()
        {
            string result = string.Empty;
            foreach(var item in GroupList)
            {
                result += $" {item}";
            }
            return result;
        }

        public override string ToString()
        {
            return $"{ID}, {Name}, Group: {MakeString()}";
        }
    }
}
