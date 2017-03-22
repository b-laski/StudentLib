﻿using Newtonsoft.Json;
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
        #region Objects
           
        internal static async Task<Models.API.User> GetUserObject()
        {
            return new Models.API.User(JObject.Parse(await Request.MakeGetRequest($"{URL}/user/me")).SelectToken("user"));
        }
            
        internal static async Task<List<Models.API.Collage.College>> GetCollegeListObject()
        {
            var json = JObject.Parse(await Request.MakeGetRequest($"{URL}/group/colleges")).SelectToken("colleges");
            List<Models.API.Collage.College> colleges= new List<Models.API.Collage.College>();
            foreach(JToken item in json)
            {
                colleges.Add(new Models.API.Collage.College(item.ToString()));
            }
            return colleges;
        }
 
        internal static async Task<List<Models.API.Deparment.Department>> GetDepartmentObject(string id)
        {
            var json = JObject.Parse(await Request.MakeGetRequest($"{URL}/group/college/departments?college_id={id}"));
            List<Models.API.Deparment.Department> departments = new List<Models.API.Deparment.Department>();
            foreach(JObject item in json.SelectToken("departments"))
            {
                departments.Add(new Models.API.Deparment.Department(item.ToString()));
            }
            return departments;
        }

        internal static async Task<List<Models.API.Categorie.Categorie>> GetCategorieObject(string id)
        {
            List<Models.API.Categorie.Categorie> categories = new List<Models.API.Categorie.Categorie>();
            var json = JObject.Parse(await Request.MakeGetRequest($"{URL}/group/college/department/categories?department_id={id}")).SelectToken("categories");
            Logs.Output.Log(json.ToString());
            foreach (JObject item in json)
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
        /// <returns></returns>
        internal static async Task<Models.API.Session> SetSession(string auth_provider, string accessToken)
        {
            return new Models.API.Session(JObject.Parse(await Request.MakeGetRequest($"{URL}/auth/connect-with-provider?auth_provider={auth_provider}&access_token={accessToken}")).SelectToken("authResult"));
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

        #region TestRegion

        internal static async Task<string> GetCollege()
        {
            var json = await Request.MakeGetRequest($"{URL}/group/colleges");
            return json;
        }

        #endregion

    }
}
