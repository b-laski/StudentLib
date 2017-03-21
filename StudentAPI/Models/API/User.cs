using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace StudentAPI.Models.API
{
    public class User
    {
        public static int UserID { get; set; }
        public static string Email { get; set; }
        public static string Name { get; set; }
        public static int RegisterTime { get; set; }
        public static string Gender { get; set; }
        public static int Birthday { get; set; }
        public static string Photo { get; set; }
        public static string LastName { get; set; }
        public static string MiddleName { get; set; }
        public static string FirstName { get; set; }

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
            return $"{UserID} {FirstName} {Email}";
        }
    }
}
