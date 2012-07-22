// -----------------------------------------------------------------------
// <copyright file="WebUpload.cs" company="">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace vtmblip.ext
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Net;
    using System.Collections.Specialized;
    using System.IO;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class WebUpload
    {
        public static string UploadFileEx(string uploadfile, string url,
            string fileFormName, string contenttype, NameValueCollection querystring,
            CookieContainer cookies)
        {
            if ((fileFormName == null) ||
                (fileFormName.Length == 0))
            {
                fileFormName = "file";
            }

            if ((contenttype == null) ||
                (contenttype.Length == 0))
            {
                contenttype = "application/octet-stream";
            }

            Uri uri = new Uri(url);

            FileStream fileStream = new FileStream(uploadfile,
                                        FileMode.Open, FileAccess.Read);
  
            HttpWebRequest webrequest = (HttpWebRequest)WebRequest.Create(uri);
            if (cookies != null)
                webrequest.CookieContainer = cookies;
            webrequest.Headers.Clear();
            webrequest.ContentLength = fileStream.Length;
            webrequest.ContentType = contenttype;
            webrequest.Method = "POST";

            Stream requestStream = webrequest.GetRequestStream();


            byte[] buffer = new Byte[checked((uint)Math.Min(4096,
                                     (int)fileStream.Length))];
            int bytesRead = 0;
            while ((bytesRead = fileStream.Read(buffer, 0, buffer.Length)) != 0)
                requestStream.Write(buffer, 0, bytesRead);

            fileStream.Close();

            WebResponse response = webrequest.GetResponse();
            Stream s = response.GetResponseStream();
            StreamReader sr = new StreamReader(s);

            string resps = sr.ReadToEnd();
            response.Close();

            return resps;
        }
    }
}
