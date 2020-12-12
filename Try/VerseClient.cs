using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Try
{
    public static class VerseClient
    {
        public static string GetAllVerse()
        {
            var client = new RestClient("http://localhost/db_prayer/displayverse.php");
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(request);
            return response.Content;
        }

        public static string addVerse(Verses verses)
        {
            var client = new RestClient("http://localhost/db_prayer/addverse.php");
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AlwaysMultipartFormData = true;
            request.AddParameter("VerseID", verses.Verseid);
            request.AddParameter("Versesw", verses.Versesw);
            IRestResponse response = client.Execute(request);
            return response.Content;
        }

        public static string deleteVerse(int id)
        {
            var client = new RestClient("http://localhost/db_prayer/deleteverse.php");
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AlwaysMultipartFormData = true;
            request.AddParameter("VerseID", id);
            IRestResponse response = client.Execute(request);
            return response.Content;
        }

        public static string updateVerse(Verses verses)
        {
            var client = new RestClient("http://localhost/db_prayer/updateverse.php");
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AlwaysMultipartFormData = true;
            request.AddParameter("VerseID", verses.Verseid);
            request.AddParameter("Versesw", verses.Versesw);
            IRestResponse response = client.Execute(request);
            return response.Content;
        }

        public static string RandVerses()
        {
            var client = new RestClient("http://localhost/db_prayer/RandVerses.php");
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(request);
            return response.Content;
        }

    }
}
