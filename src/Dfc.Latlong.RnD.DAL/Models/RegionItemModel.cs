using DFC.GeoCoding.Standard.AzureMaps.Model;
using System.Collections.Generic;

namespace dfc_latlong_RnD.Models
{
    public class RegionItemModel
    {
        public string Id { get; set; }
        public string RegionName { get; set; }
        public bool? Checked { get; set; }

        public SubRegion[] SubRegions { get; set; }
    }

    public class SubRegion
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public Position LatLong { get; set; }
    }
}