using DFC.GeoCoding.Standard.AzureMaps.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DFC.GeoCoding.Standard.AzureMaps.Model
{
    public class AzureMapsSettings : IAzureMapsSettings
    {
        public string ApiUrl { get; set; }
        public string ApiVersion { get; set; }
        public string Key { get; set; }
    }
}
