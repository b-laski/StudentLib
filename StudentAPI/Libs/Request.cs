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
        //GetMethod
        internal static async Task<string> MakeGetRequest(string URL)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(new Uri($"{URL}"));
            try
            {
                request.AutomaticDecompression = DecompressionMethods.GZip;
                request.Method = "GET";
                request.Accept = "application/json";
                request.ContentType = "application/json";
                request.Headers.Add("me-session-id", Models.API.Session.SessionID);
                request.Headers.Add("me-handle", Models.API.Session.SessionToken);

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

        //OtherMethod
        internal static async Task<string> MakeRestRequest(string URL, string method, string requestData = null, byte[] data = null)
        {
            if (data == null)
                data = new UTF8Encoding().GetBytes(requestData ?? "");

            var request = (HttpWebRequest)WebRequest.Create(new Uri($"{URL}"));
            request.Method = method;
            request.Accept = "application/json";
            request.ContentType = "application/json";
            request.Headers.Add("me-session-id", Models.API.Session.SessionID);
            request.Headers.Add("me-handle", Models.API.Session.SessionToken);

            using (var requestStream = await request.GetRequestStreamAsync())
            {
                await requestStream.WriteAsync(data, 0, data.Length);
            }

            try
            {
                using (var responseStream = await request.GetResponseAsync())
                {
                    return await new StreamReader(responseStream.GetResponseStream(), Encoding.Default, true).ReadToEndAsync();
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
