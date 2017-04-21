using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAPI.Models.API.Group
{
    public class GroupMembers : Utilities.ViewModelBase
    {
        private int? _id;
        private int? _userID;
        private string _username;
        private string _firstname;
        private string _middlename;
        private string _lastName;
        private string _gender;
        private string _photo;

        public int? ID
        {
            get { return _id; }
            set
            {
                _id = value;
                OnPropertyChanged("ID");
            }
        }
        public int? UserID
        {
            get { return _userID; }
            set
            {
                _userID = value;
                OnPropertyChanged("UserID");
            }
        }
        public string Username
        {
            get { return _username; }
            set
            {
                _username = value;
                OnPropertyChanged("Username");
            }
        }
        public string Firstname
        {
            get { return _firstname; }
            set
            {
                _firstname = value;
                OnPropertyChanged("Firstname");
            }
        }
        public string Middlename
        {
            get { return _middlename; }
            set
            {
                _middlename = value;
                OnPropertyChanged("Middlename");
            }
        }
        public string Lastname
        {
            get { return _lastName; }
            set
            {
                _lastName = value;
                OnPropertyChanged("Lastname");
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
        public string Photo
        {
            get { return _photo; }
            set
            {
                _photo = value;
                OnPropertyChanged("Photo");
            }
        }

        public GroupMembers(JToken json)
        {
            int id, userID;

            if (int.TryParse(json.SelectToken("id").ToString(), out id)) ID = id; else ID = null;
            if (int.TryParse(json.SelectToken("userID").ToString(), out userID)) UserID = userID; else UserID = null;

            Username = json.SelectToken("username").ToString();
            Firstname = json.SelectToken("firstName").ToString();
            Middlename = json.SelectToken("middleName").ToString(); 
            Lastname = json.SelectToken("lastName").ToString();
            Gender = json.SelectToken("gender").ToString();
            Photo = json.SelectToken("photo").ToString();
        }

        public override string ToString()
        {
            return $"{ID}, {UserID}, {Username}, {Gender}";
        }
    }
}
