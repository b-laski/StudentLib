using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAPI.Models.API.Collage
{
    public class College
    {
        //[JsonProperty("id")]
        public static int ID { get; set; }
        //[JsonProperty("name")]
        public static string Name { get; set; }
        //[JsonProperty("description")]
        public static string Description { get; set; }
        //[JsonProperty("photo")]
        public static string Photo { get; set; }
        //[JsonProperty("cover")]
        public static string Cover { get; set; }
        //[JsonProperty("endDate")]
        public static int? EndDate { get; set; }
        //[JsonProperty("createDate")]
        public static int CreateDate { get; set; }

        public College(string jsonStr)
        {
            JObject json = JObject.Parse(jsonStr);
            int id, endDate, createDate;

            if (int.TryParse(json.SelectToken("userID")?.ToString(), out id)) ID = id;
            if (int.TryParse(json.SelectToken("registerTime")?.ToString(), out endDate)) EndDate = endDate;
            if (int.TryParse(json.SelectToken("birthday")?.ToString(), out createDate)) CreateDate = createDate;

            Name = json.SelectToken("name")?.ToString();
            Description = json.SelectToken("description")?.ToString();
            Photo = json.SelectToken("photo")?.ToString();
            Cover = json.SelectToken("cover")?.ToString();
        }

        public override string ToString()
        {
            return $"{ID}, {Name}, {Description}";
        }
    }
}
