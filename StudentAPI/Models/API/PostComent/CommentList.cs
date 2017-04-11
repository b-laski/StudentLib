using Newtonsoft.Json.Linq;

namespace StudentAPI.Models.API.PostComent
{
    public class CommentList : Comment
    {
        private string _modifyDate;

        public string ModifyDate
        {
            get { return _modifyDate; }
            set { _modifyDate = value; OnPropertyChanged("ModifyDate"); }
        }

        public CommentList(JToken json) : base(json)
        {
            ModifyDate = json.SelectToken("modifyDate").ToString();
        }
    }
}
