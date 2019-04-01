using DFC.GeoCoding.Standard.AzureMaps.Model;
using System.Collections.Generic;

namespace dfc_latlong_RnD.Models
{
    public class RegionItemModel
    {
        public string Id { get; set; }
        public string RegionName { get; set; }
        public bool? Checked { get; set; }
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }

        public SubRegionItemModel[] SubRegions { get; set; }
    }

    public class SubRegionItemModel
    {
        public string Id { get; set; }
        public string SubRegionName { get; set; }
        public bool? Checked { get; set; }
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
    }
}