using Newtonsoft.Json.Linq;

namespace StudentAPI.Models.API
{
    public class User
    {
        //Variable
        private int _userID;
        private string _email;
        private string _name;
        private int _registerTime;
        private string _gender;
        private int _birthday;
        private string _photo;
        private string _lastName;
        private string _middleName;
        private string _firstName;

        //Property
        public int UserID
        {
            get { return _userID; }
            set { _userID = value; }
        }
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public int RegisterTime
        {
            get { return _registerTime; }
            set { _registerTime = value; }
        }
        public string Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }
        public int Birthday
        {
            get { return _birthday; }
            set { _birthday = value; }
        }
        public string Photo
        {
            get { return _photo; }
            set { _photo = value; }
        }
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }
        public string MiddleName
        {
            get { return _middleName; }
            set { _middleName = value; }
        }
        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        //ctor
        public User(JToken json)
        {
            int userid, registertime,brithday;

            if (int.TryParse(json.SelectToken("userID").ToString(), out userid)) UserID = userid;
            if (int.TryParse(json.SelectToken("registerTime").ToString(), out registertime)) RegisterTime = registertime;
            if (int.TryParse(json.SelectToken("birthday").ToString(), out brithday)) Birthday = brithday;

            Email = json.SelectToken("email").ToString();
            Name = json.SelectToken("name").ToString();
            Gender = json.SelectToken("gender").ToString();
            Photo = json.SelectToken("photo").ToString();
            LastName = json.SelectToken("lastName").ToString();
            MiddleName = json.SelectToken("middleName").ToString();
            FirstName = json.SelectToken("firstName").ToString();
        }

        public override string ToString()
        {
            return $"{UserID} | {FirstName} {MiddleName} {LastName} | {Email}";
        }
    }
}
