using System;
using System.Collections.Generic;
using System.Text;

namespace DFC.GeoCoding.Standard.AzureMaps.Interfaces
{
    public interface IAzureMapsSettings
    {
        string ApiUrl { get; set; }
        string ApiVersion { get; set; }
        string Key { get; set; }


    }
}
