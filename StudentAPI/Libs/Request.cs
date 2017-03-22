using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Authentication;
using System.Text;
using System.Threading.Tasks;
using StudentAPI.Exceptions;

namespace StudentAPI.Libs
{
    internal class Request
    {
        internal static async Task<string> MakeGetRequest(string URL, string sessionID = null, string sessionToken=null)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(new Uri($"{URL}"));
            try
            {
                //if (!string.IsNullOrEmpty(Models.API.Session.SesionID))
                    request.Headers.Add("me-session-id", Models.API.Session.SesionID);
                //if (!string.IsNullOrEmpty(Models.API.Session.SesionToken))
                    request.Headers.Add("me-handle", Models.API.Session.SesionToken);

                request.AutomaticDecompression = DecompressionMethods.GZip;
                request.Method = "GET";
                request.Accept = "application/json";
                request.ContentType = "application/json";

                using (var responseStream = await request.GetResponseAsync())
                {
                    return await new StreamReader(responseStream.GetResponseStream(), Encoding.UTF8, true).ReadToEndAsync();
                }
            }
            catch (WebException e)
            {
                handleWebException(e);
                return null;
            }
        }

        private static void handleWebException(WebException e)
        {
            HttpWebResponse errorResp = e.Response as HttpWebResponse;
            switch (errorResp.StatusCode)
            {
                case HttpStatusCode.BadRequest:
                    throw new Exception(e.Message);
                case HttpStatusCode.Unauthorized:
                    throw new InvalidAccessToken(e.Message);
                case HttpStatusCode.Forbidden:
                    throw new InvalidAccessToken(e.Message);
                case HttpStatusCode.NotFound:
                    throw new NotFoundPath(e.Message);
                case HttpStatusCode.MethodNotAllowed:
                    throw new InvalidAccess(e.Message);
                case HttpStatusCode.InternalServerError:
                    throw new ServerError(e.Message);
                default:
                    throw e;
            }
        }
    }
}
