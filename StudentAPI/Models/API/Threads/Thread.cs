using Newtonsoft.Json.Linq;

namespace StudentAPI.Models.API.Threads
{
    public class Thread : Utilities.ViewModelBase
    {
        private int _id;
        private string _title;
        private bool _isPinned;
        private int _createDate;
        private string _creatorId;

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
        public int CreateDate
        {
            get { return _createDate; }
            set { _createDate = value; OnPropertyChanged("CreatedDate"); }
        }
        public string CreatorID
        {
            get { return _creatorId; }
            set { _creatorId = value; OnPropertyChanged("CreatordID"); }
        }

        public Thread(JToken json)
        {
            int id, createDate;
            bool pinned;

            if (int.TryParse(json.SelectToken("id").ToString(), out id)) ID = id;
            if (int.TryParse(json.SelectToken("createDate").ToString(), out createDate)) CreateDate = createDate;

            if (bool.TryParse(json.SelectToken("creatorId").ToString(), out pinned) && pinned) isPinned = true;

            CreatorID = json.SelectToken("creatorId").ToString();
            Title = json.SelectToken("title").ToString();
        }

        public override string ToString()
        {
            return $"{ID} {Title} {isPinned}";
        }
    }
}
