using Newtonsoft.Json.Linq;
using System.Collections.Generic;

namespace StudentAPI.Models.API
{
    public class Search
    {
        private List<Models.API.Courses.Course> _courses = null;
        private List<Models.API.Collage.College> _colleges = null;
        private List<Models.API.Deparment.Department> _departments = null;
        private List<Models.API.User> _users = null;

        public List<Models.API.Courses.Course> Groups
        {
            get => _courses;
            set => _courses = value;
        }

        public List<Models.API.Collage.College> Colleges
        {
            get => _colleges;
            set => _colleges = value;
        }

        public List<Models.API.Deparment.Department> Deparments
        {
            get => _departments;
            set => _departments = value;
        }

        public List<Models.API.User> Users
        {
            get => _users;
            set => _users = value;
        }

        public Search(JToken json)
        {
            if (json.SelectToken("coursesGroups").HasValues)
            {
                Groups = new List<Models.API.Courses.Course>();
                foreach (var item in json.SelectToken("coursesGroups"))
                {
                    Groups.Add(new API.Courses.Course(item));
                }
            }

            if (json.SelectToken("collegeGroups").HasValues)
            {
                Colleges = new List<Collage.College>();
                foreach (var item in json.SelectToken("collegeGroups"))
                {
                    Colleges.Add(new API.Collage.College(item));
                }
            }

            if (json.SelectToken("departmentGroups").HasValues)
            {
                Deparments = new List<Deparment.Department>();
                foreach(var item in json.SelectToken("departmentGroups"))
                {
                    Deparments.Add(new Deparment.Department(item));
                }
            }

            if (json.SelectToken("users").HasValues)
            {
                Users = new List<User>();
                foreach (var item in json.SelectToken("users"))
                {
                    Users.Add(new User(item));
                }
            }
        }
    }
}
