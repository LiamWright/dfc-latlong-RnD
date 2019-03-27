using System;
using System.Collections.Generic;
using System.Text;

namespace dfc_latlong_RnD.Models
{
    public class SelectRegionModel
    {
        public IEnumerable<RegionItemModel> RegionItems { get; set; }

        public string LabelText { get; set; }
        public string HintText { get; set; }
        public string AriaDescribedBy { get; set; }

        public SelectRegionModel()
        {
            RegionItems = new List<RegionItemModel>();
        }
       
    }
}
