using Newtonsoft.Json.Linq;

namespace StudentAPI.Models.API
{
    public class Session
    {
        private static int userID { get; set; }
        private static string sessionID { get; set; }
        private static string sessionToken { get; set; }
        private static bool _new { get; set; }
        private static long timeNow { get; set; }


        public static string SessionID { get => sessionID; }
        public static string SessionToken { get => sessionToken; }
        public static bool New { get => _new; }

        public Session(JToken json)
        {
            if (bool.TryParse(json.SelectToken("isNew").ToString(), out bool isNew) && isNew) _new = true;
            if (int.TryParse(json.SelectToken("userID").ToString(), out int _userID)) userID = _userID;
            if (int.TryParse(json.SelectToken("timenow").ToString(), out int _timeNow)) timeNow = _timeNow;

            sessionID = json.SelectToken("sessionid").ToString();
            sessionToken = json.SelectToken("sessionHandleKey").ToString();
        }
    }
}
