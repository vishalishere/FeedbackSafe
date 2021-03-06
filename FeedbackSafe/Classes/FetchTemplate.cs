﻿using System;
using System.IO;
using System.Web;

namespace FeedbackSafe
{
    public class FetchTemplate
    {
        public static string ReadFile(string FileName)
        {
            try
            {
                String FILENAME = HttpContext.Current.Server.MapPath(FileName);
                using (StreamReader objStreamReader = File.OpenText(FILENAME))
                {
                    String contents = objStreamReader.ReadToEnd();
                    return contents;
                }
            }
            catch (Exception ex)
            {
            }
            return "";
        }
    }
}