using System;
using System.IO;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using StudentAPI.Exceptions;

namespace StudentAPI.Libs
{
    internal class Request
    {
        /// <summary>
        /// Get Method
        /// </summary>
        /// <param name="URL">URL for request</param>
        /// <param name="sessionID"></param>
        /// <param name="sessionToken"></param>
        /// <returns></returns>
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

        //TUTAJ BEDZIE POST/PUT/DELETE

        /// <summary>
        /// Exception for request!
        /// </summary>
        /// <param name="e"></param>
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
