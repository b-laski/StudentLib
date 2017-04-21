using Newtonsoft.Json.Linq;
using System;

namespace StudentAPI.Models.API.PostComent
{
    public class CommentList : Comment
    {
        private DateTime? _modifyDate;

        public DateTime? ModifyDate
        {
            get { return _modifyDate; }
            set { _modifyDate = value; OnPropertyChanged("ModifyDate"); }
        }

        public CommentList(JToken json) : base(json)
        {
            double modifyDate;

            if (double.TryParse(json.SelectToken("modifyDate").ToString(), out modifyDate))
                ModifyDate = Libs.DataConverter.UnixTimeStampToDateTime(modifyDate);
            else
                ModifyDate = null;
        }

        public override string ToString()
        {
            return base.ToString() +  $"{ModifyDate}";
        }
    }
}
