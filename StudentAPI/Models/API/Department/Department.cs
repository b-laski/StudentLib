using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAPI.Models.API.Deparment
{
    public class Department
    {
        public static int ID { get; set; }
        public static string Name { get; set; }
        public static string Description { get; set; }
        public static string Photo { get; set; }
        public static string Cover { get; set; }
        public static int? EndDate { get; set; }
        public static int CreateDate { get; set; }

        public Department(string jsonStr)
        {
            JObject json = JObject.Parse(jsonStr);

            int id, endDate, createDate;

            if (int.TryParse(json.SelectToken("id").ToString(), out id)) ID = id;
            if (int.TryParse(json.SelectToken("endDate").ToString(), out endDate)) EndDate = endDate;
            if (int.TryParse(json.SelectToken("createDate").ToString(), out createDate)) CreateDate = createDate;

            Name = json.SelectToken("name").ToString();
            Description = json.SelectToken("description").ToString();
            Photo = json.SelectToken("photo").ToString();
            Cover = json.SelectToken("cover").ToString();
        }
    }
}
