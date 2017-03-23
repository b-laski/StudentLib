﻿using Newtonsoft.Json.Linq;

namespace StudentAPI.Models.API
{
    public class Session
    {
        public static string SesionID { get; protected set; }
        public static string SesionToken { get; protected set; }
        public static bool New { get; protected set; }

        public Session(JToken json)
        {
            bool isNew;

            if (bool.TryParse(json.SelectToken("isNew").ToString(), out isNew) && isNew) New = true;

            SesionID = json.SelectToken("sessionid").ToString();
            SesionToken = json.SelectToken("sessionHandleKey").ToString();
        }
    }
}
