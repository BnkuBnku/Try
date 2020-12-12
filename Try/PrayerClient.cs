using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Try
{
    public static class PrayerClient
    {
        public static string GetAllPrayer()
        {
            var client = new RestClient("http://localhost/db_prayer/displayprayer.php");
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(request);
            return response.Content;
        }

        public static string addPrayer(Prayer prayer)
        {
            var client = new RestClient("http://localhost/db_prayer/addprayer.php");
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AlwaysMultipartFormData = true;
            request.AddParameter("PrayerID", prayer.Prayerid);
            request.AddParameter("Prayer", prayer.Prayerw);
            IRestResponse response = client.Execute(request);
            return response.Content;
        }

        public static string deletePrayer(int id)
        {
            var client = new RestClient("http://localhost/db_prayer/deleteprayer.php");
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AlwaysMultipartFormData = true;
            request.AddParameter("PrayerID", id);
            IRestResponse response = client.Execute(request);
            return response.Content;
        }

        public static string updatePrayer(Prayer prayer)
        {
            var client = new RestClient("http://localhost/db_prayer/updateprayer.php");
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AlwaysMultipartFormData = true;
            request.AddParameter("PrayerID", "2");
            request.AddParameter("Prayerw", "HAAHHAAHAH");
            IRestResponse response = client.Execute(request);
            return response.Content;
        }

        public static string RandPrayer()
        {
            var client = new RestClient("http://localhost/db_prayer/RandPrayer.php");
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(request);
            return response.Content;
        }


    }
}
