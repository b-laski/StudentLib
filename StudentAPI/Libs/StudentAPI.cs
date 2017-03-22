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
        #region Requests
           
        internal static async Task<Models.API.User> GetUserObject()
        {
            return new Models.API.User(JObject.Parse(await Request.MakeGetRequest($"{URL}/user/me")));
        }

        internal static async Task<string> GetCollege()
        {
            var json = await Request.MakeGetRequest($"{URL}/group/colleges");
            return json;
        }
            
        internal static async Task<List<Models.API.Collage.College>> GetCollegeList()
        {
            var json = JObject.Parse(await Request.MakeGetRequest($"{URL}/group/colleges"));
            List<Models.API.Collage.College> colleges= new List<Models.API.Collage.College>();
            foreach(JToken item in json.SelectToken("colleges"))
            {
                colleges.Add(new Models.API.Collage.College(item.ToString()));
            }
            return colleges;

            //var list = JsonConvert.DeserializeObject<List<Models.API.Collage.College>>(await Request.MakeGetRequest($"{URL}/group/colleges"));
            //return list;
        }
 
        internal static async Task<List<Models.API.Deparment.Department>> GetDepartmentObject(int id)
        {
            var json = JObject.Parse(await Request.MakeGetRequest($"{URL}/group/college/departments?college_id={id}"));
            List<Models.API.Deparment.Department> departments = new List<Models.API.Deparment.Department>();
            foreach(JToken item in json.SelectToken("departments"))
            {
                departments.Add(new Models.API.Deparment.Department(item.ToString()));
            }
            return departments;
        }

        #endregion

        #region Settings

        /// <summary>
        /// Login by provider!
        /// </summary>
        /// <param name="auth_provider">Provider like a "facebook"</param>
        /// <param name="accessToken">Access to provider</param>
        /// <returns></returns>
        internal static async Task<Models.API.Session> SetSession(string auth_provider, string accessToken)
        {
            return new Models.API.Session(JObject.Parse(await Request.MakeGetRequest($"{URL}/auth/connect-with-provider?auth_provider={auth_provider}&access_token={accessToken}")));
        }

        /// <summary>
        /// Give information about first login to KotStudent
        /// </summary>
        /// <returns></returns>
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

    }
}
