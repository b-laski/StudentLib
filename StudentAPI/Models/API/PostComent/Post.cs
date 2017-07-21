using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;

namespace StudentAPI.Models.API.PostComent
{
    public class Post 
    {
        private int _id;
        private string _content;
        private DateTime? _createDate;
        private DateTime? _modifyDate;
        private User _creator;
        public List<Comment> _comments;

        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }
        public string Content
        {
            get { return _content; }
            set { _content = value;}
        }
        public DateTime? CreateDate
        {
            get { return _createDate; }
            set { _createDate = value; }
        }
        public DateTime? ModifyDate
        {
            get { return _modifyDate; }
            set { _modifyDate = value; }
        }
        public User Creator
        {
            get => _creator;
            set => _creator = value;
        }
        public List<Comment> Comments
        {
            get { return _comments; }
            set { _comments = value; }
        }

        public Post(JToken json)
        {
            Comments = new List<Comment>();

            if (int.TryParse(json.SelectToken("id").ToString(), out int id)) ID = id;

            if (double.TryParse(json.SelectToken("createDate").ToString(), out double createDate))
                CreateDate = Libs.DataConverter.UnixTimeStampToDateTime(createDate);
            else
                CreateDate = null;


            if (double.TryParse(json.SelectToken("modifyDate").ToString(), out double modifyDate))
                ModifyDate = Libs.DataConverter.UnixTimeStampToDateTime(modifyDate);
            else
                ModifyDate = null;


            if (json.SelectToken("creator").HasValues)
                Creator = new User(json.SelectToken("creator"));
            else
                Creator = null;

            Content = json.SelectToken("content")?.ToString();

            if (json.SelectToken("lastComments") != null)
                foreach (var item in json.SelectToken("lastComments"))
                    Comments.Add(new Comment(item));
        }

        public override string ToString()
        {
            return  $"{ID}, {Content} {CreateDate} ||";
        }
    }
}
