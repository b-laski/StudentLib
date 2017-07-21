using Newtonsoft.Json.Linq;
using System;

namespace StudentAPI.Models.API.Courses
{
    public class Course
    {
        private int _id;
        private string _name;
        private string _description;
        private string _photo;
        private string _cover;
        private DateTime? _endDate;
        private DateTime? _createDate;
        private string _type;
        private bool _opened;

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
        public DateTime? EndDate
        {
            get { return _endDate; }
            set { _endDate = value; }
        }
        public DateTime? CreateDate
        {
            get { return _createDate; }
            set { _createDate = value; }
        }
        public bool Opened
        {
            get { return _opened; }
            set { _opened = value; }
        }

        public Course(JToken json)
        {
            bool opened;
            int id;
            double endDate, createDate;
            if (bool.TryParse(json.SelectToken("opened").ToString(), out opened) && opened) Opened = true;

            if (int.TryParse(json.SelectToken("id").ToString(), out id)) ID = id;
            if (double.TryParse(json.SelectToken("endDate").ToString(), out endDate))
                EndDate = Libs.DataConverter.UnixTimeStampToDateTime(endDate);
            else
                EndDate = null;

            if (double.TryParse(json.SelectToken("createDate").ToString(), out createDate))
                CreateDate = Libs.DataConverter.UnixTimeStampToDateTime(createDate);
            else
                CreateDate = null;

            Name = json.SelectToken("name").ToString();
            Description = json.SelectToken("description").ToString();
            Photo = json.SelectToken("photo").ToString();
            Cover = json.SelectToken("cover").ToString();

        }

        public override string ToString()
        {
            return $"{ID} {Name} {Description} || {CreateDate}";
        }
    }
}
