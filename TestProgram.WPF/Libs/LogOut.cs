﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace TestProgram.WPF.Libs
{
    public static class LogOut
    {
        public static void DeleteEveryCookie(Uri url)
        {
            string cookie = string.Empty;
            try
            {
                // Get every cookie (Expiration will not be in this response)
                cookie = Application.GetCookie(url);
            }
            catch (Win32Exception)
            {
                // "no more data is available" ... happens randomly so ignore it.
            }
            if (!string.IsNullOrEmpty(cookie))
            {
                // This may change eventually, but seems quite consistent for Facebook.com.
                // ... they split all values w/ ';' and put everything in foo=bar format.
                string[] values = cookie.Split(';');
                foreach (string s in values)
                {
                    if (s.IndexOf('=') > 0)
                    {
                        // Sets value to null with expiration date of yesterday.
                        DeleteSingleCookie(s.Substring(0, s.IndexOf('=')).Trim(), url);
                    }
                }
            }
        }
        private static void DeleteSingleCookie(string name, Uri url)
        {
            try
            {
                // Calculate "one day ago"
                DateTime expiration = DateTime.UtcNow - TimeSpan.FromDays(1);
                // Format the cookie as seen on FB.com.  Path and domain name are important factors here.
                string cookie = String.Format("{0}=; expires={1}; path=/; domain=.facebook.com", name, expiration.ToString("R"));
                // Set a single value from this cookie (doesnt work if you try to do all at once, for some reason)
                Application.SetCookie(url, cookie);
            }
            catch (Exception exc)
            {
                throw new Exception("FAIL!" + exc);
            }
        }
    }
}
