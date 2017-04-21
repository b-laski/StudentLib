using System.Collections.Generic;
using System.Threading.Tasks;

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

        /// <summary>
        /// [SYNC] GET CURESES LIST!
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static List<Models.API.Courses.Course> GetCoursesList(int ID) => Task.Run(() => Libs.StudentAPI.GetCursesObject(ID)).Result;

        /// <summary>
        /// [ASYNC] GET CURESES LIST!
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static async Task<List<Models.API.Courses.Course>> GetCoursesListAsync(int ID) => await Libs.StudentAPI.GetCursesObject(ID);

        /// <summary>
        /// [SYNC] GET THREAD LIST IN COURSE!
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static List<Models.API.Threads.Thread> GetThreadsList(int ID) => Task.Run(() => Libs.StudentAPI.GetThreadList(ID)).Result;

        /// <summary>
        /// [ASYNC] GET THREAD LIST IN COURSE!
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static async Task<List<Models.API.Threads.Thread>> GetThreadsListAsync(int ID) => await Libs.StudentAPI.GetThreadList(ID);

        /// <summary>
        /// [SYNC] GET POSTS LIST IN CURSE!
        /// </summary>
        /// <param name="ID"></param>
        /// <param name="OP"></param>
        /// <returns></returns>
        public static List<Models.API.PostComent.Post> GetPostList(int ID, int OP) => Task.Run(() => Libs.StudentAPI.GetPostList(ID, OP)).Result;

        /// <summary>
        /// [ASYNC] GET POSTS LIST IN THREAD!
        /// </summary>
        /// <param name="ID"></param>
        /// <param name="OP"></param>
        /// <returns></returns>
        public static async Task<List<Models.API.PostComent.Post>> GetPostListAsync(int ID, int OP) => await Libs.StudentAPI.GetPostList(ID, OP);

        /// <summary>
        /// [SYNC] GET COMMENTS LIST IN POST!
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static List<Models.API.PostComent.CommentList> GetCommentsList(int ID) => Task.Run(() => Libs.StudentAPI.GetCommentList(ID)).Result;

        /// <summary>
        /// [ASYNC] GET COMMENTS LIST IN POST!
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static async Task<List<Models.API.PostComent.CommentList>> GetCommentsListAsync(int ID) => await Libs.StudentAPI.GetCommentList(ID);

        public static List<Models.API.Group.GroupMembers> GetMemberList(int ID) => Task.Run(() => Libs.StudentAPI.GetMemberList(ID)).Result;

        public static async Task<List<Models.API.Group.GroupMembers>> GetMemberListAsync(int ID) => await Libs.StudentAPI.GetMemberList(ID);
        #endregion

        #region CreateMethods

        public static void CreateCollege(string name, List<string> alias, string description) => Libs.StudentAPI.CreateCollege(name, alias, description);

        public static void CreateDepartment(string name, int college_id, string description) => Libs.StudentAPI.CreateDepartment(name, college_id, description);

        public static void CreateCategorie(string name, int department_id) => Libs.StudentAPI.CreateCategories(name, department_id);

        public static void CreateCurses(string name, int category_id) => Libs.StudentAPI.CreateCourse(name, category_id);

        public static void CreateThread(int group_id, string title, bool isPinned) => Libs.StudentAPI.CreateThread(group_id, title, isPinned);

        public static void CreatePost(int thread_id, string message) => Libs.StudentAPI.CreatePost(thread_id, message);

        public static void CreatComment(int post_id, string message) => Libs.StudentAPI.CreateComment(post_id, message);

        public static void JoinToGroup(int group_id) => Libs.StudentAPI.JoinToGroup(group_id);

        #endregion

        #region EditMethods

        public static void EditPost(int post_id, string content) => Libs.StudentAPI.EditPost(post_id, content);

        #endregion

        #region DeleteMethods

        public static void DeletePost(int ID) => Libs.StudentAPI.DeletePost(ID);

        public static void LeaveFromGroup(int groupID, int memberID) => Libs.StudentAPI.LeaveFormGroup(groupID, memberID);

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
