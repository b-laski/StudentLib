using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace StudentAPI.Models.API.Deparment
{
    public class Department
    {
        //Variable
        [JsonProperty("id")]
        private int _id;
        [JsonProperty("name")]
        private string _name;
        [JsonProperty("description")]
        private string _description;
        [JsonProperty("photo")]
        private string _photo;
        [JsonProperty("cover")]
        private string _cover;
        [JsonProperty("endDate")]
        private int? _endDate;
        [JsonProperty("createDate")]
        private int _createDate;

        //Property
        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }
        public string Photo
        {
            get { return _photo; }
            set { _photo = value; }
        }
        public string Cover
        {
            get { return _cover; }
            set { _cover = value; }
        }
        public int? EndDate
        {
            get { return _endDate; }
            set { _endDate = value; }
        }
        public int CreateDate
        {
            get { return _createDate; }
            set { _createDate = value; }
        }

        //Ctor
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

        public override string ToString()
        {
            return $"{ID}, {Name} {Description}";
        }
    }
}
