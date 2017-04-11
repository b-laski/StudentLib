using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAPI.Libs
{
    /// <summary>Static class with functionality for StudentAPI calls.</summary>
    internal static class StudentAPI
    {
        //URL to server
        readonly static string URL = "http://193.239.80.171:3100";

        #region GetObjects
        
        /// <summary>
        /// Giving user object signed on this moment.
        /// </summary>
        /// <returns></returns>
        internal static async Task<Models.API.User> GetUserObject()
        {
            return new Models.API.User(JObject.Parse(await Request.MakeGetRequest($"{URL}/user/me")).SelectToken("user"));
        }
            
        /// <summary>
        /// Giving college list, can be use to search college.
        /// </summary>
        /// <param name="pattern">Part of College`s name</param>
        /// <returns></returns>
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
 
        /// <summary>
        /// Giving deparment list of college
        /// </summary>
        /// <param name="id">College`s ID</param>
        /// <returns></returns>
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

        /// <summary>
        /// Giving categories list of department
        /// </summary>
        /// <param name="id">Department`s ID</param>
        /// <returns></returns>
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


            //JObject json = JObject.Parse(await Request.MakeGetRequest($"{URL}/group/college/department/categories?department_id={id}"));
            //List<Models.API.Categorie.Categorie> categories = JsonConvert.DeserializeObject<List<Models.API.Categorie.Categorie>>(json.SelectToken("categories").ToString());
            //return categories;
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

        internal static async Task<List<Models.API.PostComent.Post>> GetPostList(int id, int older_then=0)
        {
            List<Models.API.PostComent.Post> posts = new List<Models.API.PostComent.Post>();
            var json = JObject.Parse(await Request.MakeGetRequest($"{URL}/group/thread/posts?thread_id={id}&older_than={older_then}"));
            foreach(var item in json.SelectToken("ThreadPosts"))
            {
                posts.Add(new Models.API.PostComent.Post(item));
            }
            return posts;
        }

        #endregion

        #region CreateMethods

        /// <summary>
        /// Creating new collega.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="alias"></param>
        /// <param name="description"></param>
        /// <param name="cover"></param>
        /// <param name="photo"></param>
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

        /// <summary>
        /// Creating new department in selected college.
        /// </summary>
        /// <param name="name">Deprtment`s name</param>
        /// <param name="college_id">College`s ID</param>
        /// <param name="description">Department`s description</param>
        /// <param name="cover">Cover image</param>
        /// <param name="photo">Department`s photo</param>
        internal static async void CreateDepartment(string name, int college_id, string description, string cover = "null", string photo = "null")
        {
            var data= "{\"name\": \"" + name + "\", \"college_id\": \"" + college_id + "\", \"cover\": null, \"photo\": null, \"description\": \"" + description + "\"}";
            JObject.Parse(await Request.MakeRestRequest($"{URL}/group/college/department", "PUT", data));
        }

        /// <summary>
        /// Creating new categorie in selected department.
        /// </summary>
        /// <param name="name">Categorie`s name</param>
        /// <param name="department_id">Department`s ID</param>
        internal static async void CreateCategories(string name, int department_id)
        {
            var data = "{\"name\": \"" + name + "\", \"department_id\": \""+ department_id +"\"}";
            JObject.Parse(await Request.MakeRestRequest($"{URL}/group/college/department/category", "PUT", data));
        }

        /// <summary>
        /// Creating new course in selected categorie.
        /// </summary>
        /// <param name="name">Course`s name </param>
        /// <param name="category_id">Categorie`s ID</param>
        internal static async void CreateCourse(string name, int category_id)
        {
            var data = "{\"name\": \"" + name + "\", \"category_id\": " + category_id + "}";
            JObject.Parse(await Request.MakeRestRequest($"{URL}/group/college/department/category/course", "PUT", data));
        }

        /// <summary>
        /// Creating new thread in course.
        /// </summary>
        /// <param name="group_id"></param>
        /// <param name="title"></param>
        /// <param name="isPinned"></param>
        internal static async void CreateThread(int group_id, string title, bool isPinned)
        {
            var data = "{\"group_id\": " + group_id + ", \"title\": \"" + title + "\", \"isPinned\": " + isPinned.ToString().ToLower() + "}";
            JObject.Parse(await Request.MakeRestRequest($"{URL}/group/threads", "PUT", data));
        }

        /// <summary>
        /// Creating new post in thread.
        /// </summary>
        /// <param name="thread_id"></param>
        /// <param name="message"></param>
        internal static async void CreatePost(int thread_id, string message)
        {
            var data = "{\"thread_id\": " + thread_id + ", \"content\": \"" + message + "\"}";
            JObject.Parse(await Request.MakeRestRequest($"{URL}/group/thread/posts", "PUT", data));
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

        /// <summary>
        /// Login by provider!
        /// </summary>
        /// <param name="auth_provider">Provider like a "facebook"</param>
        /// <param name="accessToken">Access to provider</param>
        /// <returns>true/false</returns>
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

        /// <summary>
        /// Give information about first login to KotStudent
        /// </summary>
        /// <returns>true/false</returns>
        internal static bool isNew()
        {
            if (Models.API.Session.New == true)
                return true;

            return false;
        }

        /// <summary>
        /// Giving SessionID
        /// </summary>
        /// <returns></returns>
        internal static string GetSessionID()
        {
            if (!string.IsNullOrEmpty(Models.API.Session.SesionID))
                return Models.API.Session.SesionID;

            return null;
        }

        /// <summary>
        /// Giving SessionToken
        /// </summary>
        /// <returns></returns>
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
