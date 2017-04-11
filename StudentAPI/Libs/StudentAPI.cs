using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StudentAPI.Libs
{
    /// <summary>Static class with functionality for StudentAPI calls.</summary>
    internal static class StudentAPI
    {
        //URL to server
        readonly static string URL = "http://193.239.80.171:3100";

        #region GetObjects
        internal static async Task<Models.API.User> GetUserObject()
        {
            return new Models.API.User(JObject.Parse(await Request.MakeGetRequest($"{URL}/user/me")).SelectToken("user"));
        }

        internal static async Task<List<Models.API.Collage.College>> GetCollegeListObject(string pattern = null)
        {
            List<Models.API.Collage.College> colleges = new List<Models.API.Collage.College>();
            JToken json;

            if (string.IsNullOrEmpty(pattern))
                json = JObject.Parse(await Request.MakeGetRequest($"{URL}/group/colleges")).SelectToken("colleges");
            else
                json = JObject.Parse(await Request.MakeGetRequest($"{URL}/group/colleges?by_name={pattern.ToLower()}")).SelectToken("colleges");

            foreach(JToken item in json)
            {
                colleges.Add(new Models.API.Collage.College(item));
            }
            return colleges;
        }
 
        internal static async Task<List<Models.API.Deparment.Department>> GetDepartmentObject(int id)
        {
            try
            {
                List<Models.API.Deparment.Department> departments = new List<Models.API.Deparment.Department>();
                var json = JObject.Parse(await Request.MakeGetRequest($"{URL}/group/college/departments?college_id={id}"));
                foreach(JObject item in json.SelectToken("departments"))
                {
                    departments.Add(new Models.API.Deparment.Department(item.ToString()));
                }
                return departments;
            }
            catch (Exception)
            {
                return null;
            }

        }

        internal static async Task<List<Models.API.Categorie.Categorie>> GetCategorieObject(int id)
        {
            try
            {
                List<Models.API.Categorie.Categorie> categories = new List<Models.API.Categorie.Categorie>();
                var json = JObject.Parse(await Request.MakeGetRequest($"{URL}/group/college/department/categories?department_id={id}"));
                foreach (JObject item in json.SelectToken("categories"))
                {
                    categories.Add(new Models.API.Categorie.Categorie(item));
                }
                return categories;
            }
            catch (Exception)
            {
                return null;
            }
        }

        internal static async Task<List<Models.API.Courses.Course>> GetCursesObject(int id)
        {
            List<Models.API.Courses.Course> curses = new List<Models.API.Courses.Course>();
            var json = JObject.Parse(await Request.MakeGetRequest($"{URL}/group/college/department/category/courses?category_id={id}"));
            foreach(JObject item in json.SelectToken("courses"))
            {
                curses.Add(new Models.API.Courses.Course(item));
            }
            return curses;
        }

        internal static async Task<List<Models.API.Threads.Thread>> GetThreadList(int id)
        {
            List<Models.API.Threads.Thread> threads = new List<Models.API.Threads.Thread>();
            var json = JObject.Parse(await Request.MakeGetRequest($"{URL}/group/threads?group_id={id}"));
            foreach(JObject item in json.SelectToken("GroupThreads"))
            {
                threads.Add(new Models.API.Threads.Thread(item));
            }
            return threads;
        }

        internal static async Task<List<Models.API.PostComent.Post>> GetPostList(int id, int older_than=0)
        {
            List<Models.API.PostComent.Post> posts = new List<Models.API.PostComent.Post>();
            var json = JObject.Parse(await Request.MakeGetRequest($"{URL}/group/thread/posts?thread_id={id}&older_than={older_than}"));
            foreach(var item in json.SelectToken("ThreadPosts"))
            {
                posts.Add(new Models.API.PostComent.Post(item));
            }
            return posts;
        }

        internal static async Task<List<Models.API.PostComent.CommentList>> GetCommentList(int id, int older_than=0)
        {
            List<Models.API.PostComent.CommentList> comments = new List<Models.API.PostComent.CommentList>();
            var json = JObject.Parse(await Request.MakeGetRequest($"{URL}/group/threads/posts/comments?root_id={id}&older_than={older_than}"));
            foreach (var item in json.SelectToken("PostComments"))
            {
                comments.Add(new Models.API.PostComent.CommentList(item));
            }
            return comments;
        }

        #endregion

        #region CreateMethods

        internal static async void CreateCollege(string name, List<string> alias, string description, string cover = "null", string photo = "null")
        {
            var data = "{\"name\":\"" + name + "\", \"alias\": [ ";
            for(int i=0; i< alias.Count; i++)
            {
                if(i+1 == alias.Count)
                {
                    data += $"\"{alias[i]}\" ";
                }
                else
                {
                    data += $"\"{alias[i]}\", ";
                }   
            }
            data += " ], \"cover\": \"" + cover + "\", \"photo\": \"" + photo + "\", \"description\":\"" + description + "\"}";
            JObject.Parse(await Request.MakeRestRequest($"{URL}/group/college", "PUT", data));

        }

        internal static async void CreateDepartment(string name, int college_id, string description, string cover = "null", string photo = "null")
        {
            var data= "{\"name\": \"" + name + "\", \"college_id\": \"" + college_id + "\", \"cover\": null, \"photo\": null, \"description\": \"" + description + "\"}";
            JObject.Parse(await Request.MakeRestRequest($"{URL}/group/college/department", "PUT", data));
        }

        internal static async void CreateCategories(string name, int department_id)
        {
            var data = "{\"name\": \"" + name + "\", \"department_id\": \""+ department_id +"\"}";
            JObject.Parse(await Request.MakeRestRequest($"{URL}/group/college/department/category", "PUT", data));
        }

        internal static async void CreateCourse(string name, int category_id)
        {
            var data = "{\"name\": \"" + name + "\", \"category_id\": " + category_id + "}";
            JObject.Parse(await Request.MakeRestRequest($"{URL}/group/college/department/category/course", "PUT", data));
        }

        internal static async void CreateThread(int group_id, string title, bool isPinned)
        {
            var data = "{\"group_id\": " + group_id + ", \"title\": \"" + title + "\", \"isPinned\": " + isPinned.ToString().ToLower() + "}";
            JObject.Parse(await Request.MakeRestRequest($"{URL}/group/threads", "PUT", data));
        }

        internal static async void CreatePost(int thread_id, string message)
        {
            var data = "{\"thread_id\": " + thread_id + ", \"content\": \"" + message + "\"}";
            JObject.Parse(await Request.MakeRestRequest($"{URL}/group/thread/posts", "PUT", data));
        }

        internal static async void CreateComment(int post_id, string message)
        {
            var data = "{\"root_id\": " + post_id + ", \"content\": \"" + message + "\"}";
            JObject.Parse(await Request.MakeRestRequest($"{URL}/group/thread/posts/comments", "PUT", data));
        }

        #endregion

        #region EditMethods

        internal static async void EditPost(int post_id, string content)
        {
            var data = "{\"post_id\": " + post_id + ", \"content\": \"" + content + "\"}";
            JObject.Parse(await Request.MakeRestRequest($"{URL}/group/threads/posts", "POST", data));
        }

        #endregion

        #region DeleteMetods

        internal static async void DeletePost(int id)
        {
            JObject.Parse(await Request.MakeRestRequest($"{URL}/group/threads/posts?post_id={id}", "DELETE"));
        }

        #endregion

        #region Settings

        internal static async Task<bool> SetSession(string auth_provider, string accessToken)
        {
            try
            {
                new Models.API.Session(JObject.Parse(await Request.MakeGetRequest($"{URL}/auth/connect-with-provider?auth_provider={auth_provider}&access_token={accessToken}")).SelectToken("authResult"));
                return true;
            }
            catch
            {
                return false;
            }
        }

        internal static bool isNew()
        {
            if (Models.API.Session.New == true)
                return true;

            return false;
        }

        internal static string GetSessionID()
        {
            if (!string.IsNullOrEmpty(Models.API.Session.SesionID))
                return Models.API.Session.SesionID;

            return null;
        }

        internal static string GetSessionToken()
        {
            if (!string.IsNullOrEmpty(Models.API.Session.SesionToken))
                return Models.API.Session.SesionToken;

            return null;
        }
        #endregion

        #region TestRegion

        //funkcja do testowania zapytan i zwrotów
        internal static async Task<string> GetCollege()
        {
            var json = await Request.MakeGetRequest($"{URL}/group/colleges");
            return json;
        }

        #endregion

    }
}
