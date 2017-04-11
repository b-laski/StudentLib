using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAPI.Models.API.PostComent
{
    public class Post : Utilities.ViewModelBase
    {
        private int _id;
        private string _content;
        private int _userid;
        private int? _createDate;
        private int? _modifyDate;

        public int ID
        {
            get { return _id; }
            set { _id = value; OnPropertyChanged("ID"); }
        }
        public string Content
        {
            get { return _content; }
            set { _content = value; OnPropertyChanged("Content"); }
        }
        public int UserID
        {
            get { return _userid; }
            set { _userid = value; OnPropertyChanged("UserID"); }
        }
        public int? CreateDate
        {
            get { return _createDate; }
            set { _createDate = value; OnPropertyChanged("CreateDate"); }
        }
        public int? ModifyDate
        {
            get { return _modifyDate; }
            set { _modifyDate = value; OnPropertyChanged("ModifyDate"); }
        }

        public Post(JToken json)
        {
            int id, userid, createDate, modifyDate;
            if (int.TryParse(json.SelectToken("id").ToString(), out id)) ID = id;
            if (int.TryParse(json.SelectToken("userID").ToString(), out userid)) UserID = userid;
            if (int.TryParse(json.SelectToken("createDate").ToString(), out createDate)) CreateDate = createDate;
            if (int.TryParse(json.SelectToken("modifyDate").ToString(), out modifyDate)) ModifyDate = modifyDate;

            Content = json.SelectToken("content").ToString();
        }

        public override string ToString()
        {
            return $"{ID}, {Content} {UserID}";
        }
    }
}
