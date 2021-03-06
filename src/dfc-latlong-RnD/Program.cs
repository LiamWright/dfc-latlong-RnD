﻿using Dfc.Latlong.RnD.DAL;
using DFC.GeoCoding.Standard.AzureMaps.Service;
using dfc_latlong_RnD.Models;
using Newtonsoft.Json;
using System.Configuration;
using System.Threading.Tasks;

namespace dfc_latlong_RnD
{
    class Program
    {
        public static string _apiUrl, _apiVersion, _key;
        public static AzureMapService service;
        public static DataAccessLayer dal;
        static void Main(string[] args)
        {
            _apiUrl = ConfigurationManager.AppSettings["ApiUrl"];
            _apiVersion = ConfigurationManager.AppSettings["ApiVersion"];
            _key = ConfigurationManager.AppSettings["Key"];


            service = new AzureMapService(
                azureMapURL: _apiUrl,
                apiVersion: _apiVersion,
                subscriptionKey: _key);



            dal = new DataAccessLayer();
            UpdateCoordinates().Wait();

        }

        public static async Task UpdateCoordinates()
        {

            //Load Document
            //Loop through regions, get sub regions
            //For each sub region, get the lat long, find in SQL, insert.
            

            var regions = dal.GetRegions();
            foreach (var region in regions.RegionItems)
            {
                var regionResult = service.GetPositionForAddress(region.RegionName + ", England, United Kingdom").Result;

                region.Latitude = (decimal)regionResult.Lat;
                region.Longitude = (decimal)regionResult.Lon;

                foreach (var subRegion in region.SubRegions)
                {
                    
                    var result = service.GetPositionForAddress(subRegion.SubRegionName).Result;

                    subRegion.Latitude = (decimal)result.Lat;
                    subRegion.Longitude = (decimal)result.Lon;

                }
            }
            var json = JsonConvert.SerializeObject(regions);
            //dal.InsertIntoTable(regions);
        }


        
    }
}
