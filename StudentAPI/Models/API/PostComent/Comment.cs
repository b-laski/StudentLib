using Newtonsoft.Json.Linq;
using System;

namespace StudentAPI.Models.API.PostComent
{
    public class Comment : Utilities.ViewModelBase
    {
        private int _id;
        private string _content;
        private int _userID;
        private DateTime _createDate;

        public int ID
        {
            get { return _id; }
            set
            {
                _id = value;
                OnPropertyChanged("ID");
            }
        }
        public string Content
        {
            get { return _content; }
            set
            {
                _content = value;
                OnPropertyChanged("Content");
            }
        }
        public int UserID
        {
            get { return _userID; }
            set
            {
                _userID = value;
                OnPropertyChanged("UserID");
            }
        }
        public DateTime CreateDate
        {
            get { return _createDate; }
            set
            {
                _createDate = value;
                OnPropertyChanged("CreateDate");
            }
        }

        public Comment(JToken json)
        {
            int id, userID;
            if (int.TryParse(json.SelectToken("id").ToString(), out id)) ID = id;
            if (int.TryParse(json.SelectToken("userID").ToString(), out userID)) UserID = userID;
            
            Content = json.SelectToken("content").ToString();
            CreateDate = Libs.Helper.UnixTimeStampToDateTime((double)json.SelectToken("createDate"));
        }

        public override string ToString()
        {
            return $" {UserID} {Content}";
        }
    }
}
