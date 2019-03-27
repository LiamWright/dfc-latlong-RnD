using DFC.GeoCoding.Standard.AzureMaps;
using DFC.GeoCoding.Standard.AzureMaps.Model;
using DFC.GeoCoding.Standard.AzureMaps.Service;
using System;
using System.Configuration;
using System.Threading.Tasks;

namespace dfc_latlong_RnD
{
    class Program
    {
        public static string _apiUrl, _apiVersion, _key;
        public static AzureMapService service;
        static void Main(string[] args)
        {
            _apiUrl = ConfigurationManager.AppSettings["ApiUrl"];
            _apiVersion = ConfigurationManager.AppSettings["ApiVersion"];
            _key = ConfigurationManager.AppSettings["Key"];


            service = new AzureMapService(
                azureMapURL: _apiUrl,
                apiVersion: _apiVersion,
                subscriptionKey: _key);

            CallService().Wait();
        }

        public static async Task CallService()
        {

            //Load Document
            //Loop through regions, get sub regions
            //For each sub region, get the lat long, find in SQL, insert.
            var results =  await service.GetPositionForAddress("Northampton GB");
        }
    }
}
