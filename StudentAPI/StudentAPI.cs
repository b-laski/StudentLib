using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentAPI;

namespace StudentAPI
{
    public static class StudentAPI
    {
        #region Object/ObjectList
        
        /// <summary>
        /// [SYNC]Setting session by access token from provider.
        /// </summary>
        /// <param name="auth_provider">Name of provider</param>
        /// <param name="accessToken">Access Token</param>
        /// <returns></returns>
        public static bool SetSession(string auth_provider, string accessToken) => Task.Run(() => Libs.StudentAPI.SetSession(auth_provider, accessToken)).Result;

        /// <summary>
        /// [ASYNC] Setting sesion by access token from provider.
        /// </summary>
        /// <param name="auth_provider">Name of provider</param>
        /// <param name="accessToken"></param>
        /// <returns></returns>
        public static async Task<bool> SetSessionAsync(string auth_provider, string accessToken) => await Libs.StudentAPI.SetSession(auth_provider, accessToken);

        /// <summary>
        /// [SYNC] Giving information about currnet user
        /// </summary>
        /// <returns></returns>
        public static Models.API.User GetUserObject() => Task.Run(() => Libs.StudentAPI.GetUserObject()).Result;

        /// <summary>
        /// [ASYNC] Giving information about currnet user
        /// </summary>
        /// <returns></returns>
        public static async Task<Models.API.User> GetUserObjectAsync() => await Libs.StudentAPI.GetUserObject();

        /// <summary>
        /// [SYNC]Giving list of colleges and information
        /// </summary>
        /// <param name="pattern">Patter of name college.</param>
        /// <returns></returns>
        public static List<Models.API.Collage.College> GetCollegeList(string pattern = null) => Task.Run(() => Libs.StudentAPI.GetCollegeListObject(pattern)).Result;

        /// <summary>
        /// [ASYNC]Giving list of colleges and information
        /// </summary>
        /// <param name="pattern">Patter of name college.</param>
        /// <returns></returns>
        public static async Task<List<Models.API.Collage.College>> GetCollegeListAsync(string pattern = null) => await Libs.StudentAPI.GetCollegeListObject(pattern);

        /// <summary>
        /// [SYNC]Giving list of departments and information
        /// </summary>
        /// <param name="ID">College`s ID</param>
        /// <returns></returns>
        public static List<Models.API.Deparment.Department> GetDepartmentList(int ID) => Task.Run(() => Libs.StudentAPI.GetDepartmentObject(ID)).Result;

        /// <summary>
        /// [ASYNC]Giving list of departments and information
        /// </summary>
        /// <param name="ID">College`s ID</param>
        /// <returns></returns>
        public static async Task<List<Models.API.Deparment.Department>> GetDepartmentListAsync(int ID) => await Libs.StudentAPI.GetDepartmentObject(ID);

        /// <summary>
        /// [SYNC] Giving list of categories and information
        /// </summary>
        /// <param name="ID">ID of department</param>
        /// <returns></returns>
        public static List<Models.API.Categorie.Categorie> GetCategoriesList(int ID) => Task.Run(() => Libs.StudentAPI.GetCategorieObject(ID)).Result;

        /// <summary>
        /// [ASYNC] Giving list of categories and information
        /// </summary>
        /// <param name="ID">ID of department</param>
        /// <returns></returns>
        public static async Task<List<Models.API.Categorie.Categorie>> GetCategoriesListAsync(int ID) => await Libs.StudentAPI.GetCategorieObject(ID);

        #endregion

        #region Settings
        /// <summary>
        /// [PRIVATE]GetSesionID
        /// </summary>
        /// <returns></returns>
        public static string GetSessionID() => Libs.StudentAPI.GetSessionID();

        /// <summary>
        /// [PRIVATE]Get SesionToken
        /// </summary>
        /// <returns></returns>
        public static string GetSessionToken() => Libs.StudentAPI.GetSessionToken();

        /// <summary>
        /// Showing information about new user.
        /// </summary>
        /// <returns></returns>
        public static bool IsNew() => Libs.StudentAPI.isNew();
        #endregion

    }
}
