using Newtonsoft.Json.Linq;
using System;

namespace StudentAPI.Models.API.Threads
{
    public class Thread : Utilities.ViewModelBase
    {
        private int _id;
        private string _title;
        private bool _isPinned;
        private DateTime? _createDate;
        private int? _creatorId;

        public int ID
        {
            get { return _id; }
            set { _id = value; OnPropertyChanged("ID"); }
        }
        public string Title
        {
            get { return _title; }
            set { _title = value; OnPropertyChanged("Title"); }
        }
        public bool isPinned
        {
            get { return _isPinned; }
            set { _isPinned = value; OnPropertyChanged("Pinned"); }
        }
        public DateTime? CreateDate
        {
            get { return _createDate; }
            set { _createDate = value; OnPropertyChanged("CreatedDate"); }
        }
        public int? CreatorID
        {
            get { return _creatorId; }
            set { _creatorId = value; OnPropertyChanged("CreatordID"); }
        }

        public Thread(JToken json)
        {
            int id, creatorID;
            double createDate;
            bool pinned;

            if (int.TryParse(json.SelectToken("id").ToString(), out id)) ID = id;
            if (double.TryParse(json.SelectToken("createDate").ToString(), out createDate))
                CreateDate = Libs.DataConverter.UnixTimeStampToDateTime(createDate);
            else
                CreateDate = null;

            if (bool.TryParse(json.SelectToken("isPinned").ToString(), out pinned) && pinned) isPinned = true;
            if (int.TryParse(json.SelectToken("creatorId").ToString(), out creatorID))
                CreatorID = creatorID;
            else
                CreatorID = null;

            Title = json.SelectToken("title").ToString();
        }

        public override string ToString()
        {
            return $"{ID} {Title} {isPinned}";
        }
    }
}
