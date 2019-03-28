using Dfc.Latlong.RnD.DAL;
using DFC.GeoCoding.Standard.AzureMaps.Service;
using Newtonsoft.Json;
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

            UpdateCoordinates().Wait();
        }

        public static async Task UpdateCoordinates()
        {

            //Load Document
            //Loop through regions, get sub regions
            //For each sub region, get the lat long, find in SQL, insert.
            DataAccessLayer dal = new DataAccessLayer();

            var regions = dal.GetRegions();
            foreach (var region in regions.RegionItems)
            {
                foreach (var subRegion in region.SubRegions)
                {
                    var result = service.GetPositionForAddress(subRegion.SubRegionName).Result;

                    subRegion.Latitude = (decimal)result.Lat;
                    subRegion.Longitude = (decimal)result.Lon;

                }
            }
            var json = JsonConvert.SerializeObject(regions);
        }

        
    }
}
