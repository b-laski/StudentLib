using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAPI.Models.API.Courses
{
    public class Course : Utilities.ViewModelBase
    {
        private int _id;
        private string _name;
        private string _description;
        private string _photo;
        private string _cover;
        private int? _endDate;
        private int _createDate;
        private bool _opened;

        public int ID
        {
            get { return _id; }
            set { _id = value; OnPropertyChanged("ID"); }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; OnPropertyChanged("Name"); }
        }
        public string Description
        {
            get { return _description; }
            set { _description = value; OnPropertyChanged("Description"); }
        }
        public string Photo
        {
            get { return _photo; }
            set { _photo = value; OnPropertyChanged("Photo"); }
        }
        public string Cover
        {
            get { return _cover; }
            set { _cover = value; OnPropertyChanged("Cover"); }
        }
        public int? EndDate
        {
            get { return _endDate; }
            set { _endDate = value; OnPropertyChanged("EndDate"); }
        }
        public int CreateDate
        {
            get { return _createDate; }
            set { _createDate = value; OnPropertyChanged("CreateDate"); }
        }
        public bool Opened
        {
            get { return _opened; }
            set { _opened = value; OnPropertyChanged("Opened"); }
        }

        public Course(JToken json)
        {
            bool opened;
            int id, endDate, createDate;
            if (bool.TryParse(json.SelectToken("opened").ToString(), out opened) && opened) Opened = true;

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
            return $"{ID} {Name} {Description}";
        }
    }
}
