using System;
using System.Net;
using System.IO;

namespace CinemagiC.Services
{
    public class HttpRequest
    {
        public HttpRequest()
        {
            string jsonString = string.Empty;
            string url = @"https://api.themoviedb.org/3/movie/popular?api_key=de2c61fd451b50de11cee234a5d8346b&language=en-US&page=1"


            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.AutomaticDecompression = DecompressionMethods.GZip;

            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                jsonString = reader.ReadToEnd();
            }

            Console.WriteLine(jsonString);
        }
    }
}
