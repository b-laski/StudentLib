using Newtonsoft.Json.Linq;
using System;

namespace StudentAPI.Models.API.Threads
{
    public class Thread
    {
        private int _id;
        private string _title;
        private bool _isPinned;
        private DateTime? _createDate;
        private User _creator;

        public int ID
        {
            get => _id;
            set => _id = value;
        }
        public string Title
        {
            get => _title;
            set => _title = value;
        }
        public bool isPinned
        {
            get => _isPinned;
            set => _isPinned = value;
        }
        public DateTime? CreateDate
        {
            get => _createDate;
            set => _createDate = value;
        }

        public User Creator
        {
            get => _creator;
            set
            {
                if (_creator == value)
                    return;

                _creator = value;

            }
        }



        public Thread(JToken json)
        {
            //THREADID
            if (int.TryParse(json.SelectToken("id")?.ToString(), out int id)) ID = id;

            //DATA
            if (double.TryParse(json.SelectToken("createDate").ToString(), out double createDate))
                CreateDate = Libs.DataConverter.UnixTimeStampToDateTime(createDate);
            else
                CreateDate = null;
            
            //PINNED?
            if (bool.TryParse(json.SelectToken("isPinned").ToString(), out bool pinned) && pinned) isPinned = true;

            if (json.SelectToken("creator").HasValues)
                Creator = new User(json.SelectToken("creator"));
            else
                Creator = null;

            Title = json.SelectToken("title")?.ToString();
        }

        public override string ToString()
        {
            return $" {ID} {Title} {isPinned.ToString()} || {Creator}";
        }
    }
}
