using System;
using System.Net;
using System.IO;

namespace CinemagiC.Services
{
    public class HttpRequest
    {

        public static string HttpRequester(){
            return HttpRequester(1);
        }
        public static string HttpRequester(int page)
        {
            string jsonString = string.Empty;
            string url = @"https://api.themoviedb.org/3/movie/popular?api_key=de2c61fd451b50de11cee234a5d8346b&language=en-US&page=" + Convert.ToString(page);


            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.AutomaticDecompression = DecompressionMethods.GZip;

            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                jsonString = reader.ReadToEnd();
            }

            System.Diagnostics.Debug.WriteLine(jsonString);

            return jsonString;
        }
    }
}
