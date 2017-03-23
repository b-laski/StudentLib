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

        #region Objects/ObjectLists
        
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
                colleges.Add(new Models.API.Collage.College(item.ToString()));
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
            List<Models.API.Deparment.Department> departments = new List<Models.API.Deparment.Department>();
            var json = JObject.Parse(await Request.MakeGetRequest($"{URL}/group/college/departments?college_id={id}"));
            foreach(JObject item in json.SelectToken("departments"))
            {
                departments.Add(new Models.API.Deparment.Department(item.ToString()));
            }
            return departments;
        }

        /// <summary>
        /// Giving categories list of department
        /// </summary>
        /// <param name="id">Department`s ID</param>
        /// <returns></returns>
        internal static async Task<List<Models.API.Categorie.Categorie>> GetCategorieObject(int id)
        {
            List<Models.API.Categorie.Categorie> categories = new List<Models.API.Categorie.Categorie>();
            var json = JObject.Parse(await Request.MakeGetRequest($"{URL}/group/college/department/categories?department_id={id}"));
            foreach (JObject item in json.SelectToken("categories"))
            {
                categories.Add(new Models.API.Categorie.Categorie(item));
            }
            return categories;

            //JObject json = JObject.Parse(await Request.MakeGetRequest($"{URL}/group/college/department/categories?department_id={id}"));
            //List<Models.API.Categorie.Categorie> categories = JsonConvert.DeserializeObject<List<Models.API.Categorie.Categorie>>(json.SelectToken("categories").ToString());
            //return categories;
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
