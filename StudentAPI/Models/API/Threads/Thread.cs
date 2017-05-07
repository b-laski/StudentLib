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
        private string _creatorName;
        private string _creatorFirstName;
        private string _creatorMiddleName;
        private string _creatorLastName;
        private string _creatorGender;
        private string _creatorPhoto;
        private string _creatorCover;
        private int? _creatorId;

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
        public string CreatorName
        {
            get => _creatorName;
            set => _creatorName = value;
        }
        public string CreatorFirstName
        {
            get => _creatorFirstName;
            set => _creatorFirstName = value;
        }
        public string CreatorMiddleName
        {
            get => _creatorMiddleName;
            set => _creatorMiddleName = value;
        }
        public string CreatorLastName
        {
            get => _creatorLastName;
            set => _creatorLastName = value;
        }
        public string CreatorGender
        {
            get => _creatorGender;
            set => _creatorGender = value;
        }
        public string CreatorPhoto
        {
            get => _creatorPhoto;
            set => _creatorPhoto = value;
        }
        public string CreatorCover
        {
            get => _creatorCover;
            set => _creatorCover = value;
        }
        public int? CreatorID
        {
            get => _creatorId;
            set => _creatorId = value;
        }




        public Thread(JToken json)
        {
            //THREADID
            if (int.TryParse(json.SelectToken("id")?.ToString(), out int id)) ID = id;

            //CREATORID
            if (int.TryParse(json.SelectToken("creatorId")?.ToString(), out int creatorId))
                CreatorID = creatorId;
            else
                CreatorID = null;

            //DATA
            if (double.TryParse(json.SelectToken("createDate").ToString(), out double createDate))
                CreateDate = Libs.DataConverter.UnixTimeStampToDateTime(createDate);
            else
                CreateDate = null;
            
            //PINNED?
            if (bool.TryParse(json.SelectToken("isPinned").ToString(), out bool pinned) && pinned) isPinned = true;

            CreatorName = json.SelectToken("creatorName")?.ToString();
            CreatorFirstName = json.SelectToken("creatorFirstName")?.ToString();
            CreatorMiddleName = json.SelectToken("creatorMiddleName")?.ToString();
            CreatorLastName = json.SelectToken("creatorLastName")?.ToString();
            CreatorGender = json.SelectToken("creatorGender")?.ToString();
            CreatorPhoto = json.SelectToken("creatorPhoto")?.ToString();
            CreatorCover = json.SelectToken("creatorCover")?.ToString();
            Title = json.SelectToken("title")?.ToString();
        }

        public override string ToString()
        {
            return $"{ID} {Title} {isPinned} {CreatorID} {CreatorName}";
        }
    }
}
