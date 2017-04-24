using Newtonsoft.Json.Linq;
using Utilities;

namespace StudentAPI.Models.API
{
    public class User : Utilities.ViewModelBase
    {
        //Variable
        private int _userID;
        private string _email;
        private string _name;
        private int _registerTime;
        private string _gender;
        private int _birthday;
        private string _photo;
        private string _cover;
        private string _lastName;
        private string _middleName;
        private string _firstName;

        //Property
        public int UserID
        {
            get { return _userID; }
            set
            {
                _userID = value;
                OnPropertyChanged("UserID");
            }
        }
        public string Email
        {
            get { return _email; }
            set
            {
                _email = value;
                OnPropertyChanged("Email");
            }
        }
        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                OnPropertyChanged("Name");
            }
        }
        public int RegisterTime
        {
            get { return _registerTime; }
            set
            {
                _registerTime = value;
                OnPropertyChanged("RegisterTime");
            }
        }
        public string Gender
        {
            get { return _gender; }
            set
            {
                _gender = value;
                OnPropertyChanged("Gender");
            }
        }
        public int Birthday
        {
            get { return _birthday; }
            set
            {
                _birthday = value;
                OnPropertyChanged("Birthday");
            }
        }
        public string Photo
        {
            get { return _photo; }
            set
            {
                _photo = value;
                OnPropertyChanged("Photo");
            }
        }
        public string Cover
        {
            get { return _cover; }
            set
            {
                _cover = value;
                OnPropertyChanged("Cover");
            }
        }
        public string LastName
        {
            get { return _lastName; }
            set
            {
                _lastName = value;
                OnPropertyChanged("LastName");
            }
        }
        public string MiddleName
        {
            get { return _middleName; }
            set
            {
                _middleName = value;
                OnPropertyChanged("MiddleName");
            }
        }
        public string FirstName
        {
            get { return _firstName; }
            set
            {
                _firstName = value;
                OnPropertyChanged("FirstName");
            }
        }

        //ctor
        public User(JToken json)
        {
            int userid, registertime,brithday;

            if (int.TryParse(json.SelectToken("userID").ToString(), out userid)) UserID = userid;
            if (int.TryParse(json.SelectToken("registerTime").ToString(), out registertime)) RegisterTime = registertime;
            if (int.TryParse(json.SelectToken("birthday").ToString(), out brithday)) Birthday = brithday;

            Email = json.SelectToken("email")?.ToString();
            Name = json.SelectToken("name")?.ToString();
            Gender = json.SelectToken("gender")?.ToString();
            Photo = json.SelectToken("photo")?.ToString();
            Cover = json.SelectToken("cover")?.ToString();
            LastName = json.SelectToken("lastName")?.ToString();
            MiddleName = json.SelectToken("middleName")?.ToString();
            FirstName = json.SelectToken("firstName")?.ToString();
        }

        public override string ToString()
        {
            return $"{Birthday}";
        }
    }
}
