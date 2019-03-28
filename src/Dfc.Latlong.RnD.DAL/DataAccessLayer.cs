using dfc_latlong_RnD.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dfc.Latlong.RnD.DAL
{
    public class DataAccessLayer
    {
        public SelectRegionModel GetRegions()
        {
            return new SelectRegionModel
            {
                LabelText = "Select course region",
                HintText = "For example, South West",
                AriaDescribedBy = "Select all that apply.",
                RegionItems = new RegionItemModel[]
                {
                    new RegionItemModel
                    {
                        Id = "E12000001",
                        Checked = false,
                        RegionName = "North East",
                        SubRegions = new SubRegionItemModel[]
                        {
                            new SubRegionItemModel{ Id = "E06000001", SubRegionName = "County Durham"},
                            new SubRegionItemModel{ Id = "E06000002", SubRegionName = "Darlington"},
                            new SubRegionItemModel{ Id = "E06000003", SubRegionName = "Gateshead"},
                            new SubRegionItemModel{ Id = "E06000004", SubRegionName = "Hartlepool"},
                            new SubRegionItemModel{ Id = "E06000005", SubRegionName = "Middlesbrough"},
                            new SubRegionItemModel{ Id = "E06000047", SubRegionName = "Newcastle upon Tyne"},
                            new SubRegionItemModel{ Id = "E06000057", SubRegionName = "North Tyneside"},
                            new SubRegionItemModel{ Id = "E08000021", SubRegionName = "Northumberland"},
                            new SubRegionItemModel{ Id = "E08000022", SubRegionName = "Redcar and Cleveland"},
                            new SubRegionItemModel{ Id = "E08000023", SubRegionName = "South Tyneside"},
                            new SubRegionItemModel{ Id = "E08000024", SubRegionName = "Stockton-on-Tees"},
                            new SubRegionItemModel{ Id = "E08000037", SubRegionName = "Sunderland"}
                        }
                    },
                    new RegionItemModel
                    {
                        Id = "E12000002",
                        Checked = false,
                        RegionName = "North West",
                        SubRegions = new SubRegionItemModel[]
                        {
                            new SubRegionItemModel{ Id = "E06000006", SubRegionName = "Halton"},
                            new SubRegionItemModel{ Id = "E06000007", SubRegionName = "Warrington"},
                            new SubRegionItemModel{ Id = "E06000008", SubRegionName = "Blackburn with Darwen"},
                            new SubRegionItemModel{ Id = "E06000009", SubRegionName = "Blackpool"},
                            new SubRegionItemModel{ Id = "E06000049", SubRegionName = "Cheshire East"},
                            new SubRegionItemModel{ Id = "E06000050", SubRegionName = "Cheshire West and Chester"},
                            new SubRegionItemModel{ Id = "E08000001", SubRegionName = "Bolton"},
                            new SubRegionItemModel{ Id = "E08000002", SubRegionName = "Bury"},
                            new SubRegionItemModel{ Id = "E08000003", SubRegionName = "Manchester"},
                            new SubRegionItemModel{ Id = "E08000004", SubRegionName = "Oldham"},
                            new SubRegionItemModel{ Id = "E08000005", SubRegionName = "Rochdale"},
                            new SubRegionItemModel{ Id = "E08000006", SubRegionName = "Salford"},
                            new SubRegionItemModel{ Id = "E08000007", SubRegionName = "Stockport"},
                            new SubRegionItemModel{ Id = "E08000008", SubRegionName = "Tameside"},
                            new SubRegionItemModel{ Id = "E08000009", SubRegionName = "Trafford"},
                            new SubRegionItemModel{ Id = "E08000010", SubRegionName = "Wigan"},
                            new SubRegionItemModel{ Id = "E08000011", SubRegionName = "Knowsley"},
                            new SubRegionItemModel{ Id = "E08000012", SubRegionName = "Liverpool"},
                            new SubRegionItemModel{ Id = "E08000013", SubRegionName = "St. Helens"},
                            new SubRegionItemModel{ Id = "E08000014", SubRegionName = "Sefton"},
                            new SubRegionItemModel{ Id = "E08000015", SubRegionName = "Wirral"},
                            new SubRegionItemModel{ Id = "E10000006", SubRegionName = "Cumbria"},
                            new SubRegionItemModel{ Id = "E10000017", SubRegionName = "Lancashire"}

                        }
                    },
                    new RegionItemModel
                    {
                        Id = "E12000003",
                        Checked = false,
                        RegionName = "Yorkshire and The Humber",
                        SubRegions = new SubRegionItemModel[]
                        {
                            new SubRegionItemModel{ Id = "E06000010", SubRegionName = "Kingston upon Hull, City of"},
                            new SubRegionItemModel{ Id = "E06000011", SubRegionName = "East Riding of Yorkshire"},
                            new SubRegionItemModel{ Id = "E06000012", SubRegionName = "North East Lincolnshire"},
                            new SubRegionItemModel{ Id = "E06000013", SubRegionName = "North Lincolnshire"},
                            new SubRegionItemModel{ Id = "E06000014", SubRegionName = "York"},
                            new SubRegionItemModel{ Id = "E08000016", SubRegionName = "Barnsley"},
                            new SubRegionItemModel{ Id = "E08000017", SubRegionName = "Doncaster"},
                            new SubRegionItemModel{ Id = "E08000018", SubRegionName = "Rotherham"},
                            new SubRegionItemModel{ Id = "E08000019", SubRegionName = "Sheffield"},
                            new SubRegionItemModel{ Id = "E08000032", SubRegionName = "Bradford"},
                            new SubRegionItemModel{ Id = "E08000033", SubRegionName = "Calderdale"},
                            new SubRegionItemModel{ Id = "E08000034", SubRegionName = "Kirklees"},
                            new SubRegionItemModel{ Id = "E08000035", SubRegionName = "Leeds"},
                            new SubRegionItemModel{ Id = "E08000036", SubRegionName = "Wakefield"},
                            new SubRegionItemModel{ Id = "E10000023", SubRegionName = "North Yorkshire"}
                        }
                    },
                    new RegionItemModel
                    {
                        Id = "E12000004",
                        Checked = false,
                        RegionName = "East Midlands",
                        SubRegions = new SubRegionItemModel[]
                        {
                            new SubRegionItemModel{ Id = "E06000015", SubRegionName = "Derby"},
                            new SubRegionItemModel{ Id = "E10000007", SubRegionName = "Derbyshire"},
                            new SubRegionItemModel{ Id = "E06000016", SubRegionName = "Leicester"},
                            new SubRegionItemModel{ Id = "E10000018", SubRegionName = "Leicestershire"},
                            new SubRegionItemModel{ Id = "E10000019", SubRegionName = "Lincolnshire"},
                            new SubRegionItemModel{ Id = "E10000021", SubRegionName = "Northamptonshire"},
                            new SubRegionItemModel{ Id = "E06000018", SubRegionName = "Nottingham"},
                            new SubRegionItemModel{ Id = "E10000024", SubRegionName = "Nottinghamshire"},
                            new SubRegionItemModel{ Id = "E06000017", SubRegionName = "Rutland"}
                        }
                    },
                    new RegionItemModel
                    {
                        Id = "E12000005",
                        Checked = false,
                        RegionName = "West Midlands",
                        SubRegions = new SubRegionItemModel[]
                        {
                            new SubRegionItemModel{ Id = "E06000019", SubRegionName = "Herefordshire, County of"},
                            new SubRegionItemModel{ Id = "E06000020", SubRegionName = "Telford and Wrekin"},
                            new SubRegionItemModel{ Id = "E06000021", SubRegionName = "Stoke-on-Trent"},
                            new SubRegionItemModel{ Id = "E06000051", SubRegionName = "Shropshire"},
                            new SubRegionItemModel{ Id = "E08000025", SubRegionName = "Birmingham"},
                            new SubRegionItemModel{ Id = "E08000026", SubRegionName = "Coventry"},
                            new SubRegionItemModel{ Id = "E08000027", SubRegionName = "Dudley"},
                            new SubRegionItemModel{ Id = "E08000028", SubRegionName = "Sandwell"},
                            new SubRegionItemModel{ Id = "E08000029", SubRegionName = "Solihull"},
                            new SubRegionItemModel{ Id = "E08000030", SubRegionName = "Walsall"},
                            new SubRegionItemModel{ Id = "E08000031", SubRegionName = "Wolverhampton"},
                            new SubRegionItemModel{ Id = "E10000028", SubRegionName = "Staffordshire"},
                            new SubRegionItemModel{ Id = "E10000031", SubRegionName = "Warwickshire"},
                            new SubRegionItemModel{ Id = "E10000034", SubRegionName = "Worcestershire"}
                        }
                    },
                    new RegionItemModel
                    {
                        Id = "E12000006",
                        Checked = false,
                        RegionName = "East of England",
                        SubRegions = new SubRegionItemModel[]
                        {
                            new SubRegionItemModel{ Id = "E06000055", SubRegionName = "Bedford"},
                            new SubRegionItemModel{ Id = "E10000003", SubRegionName = "Cambridgeshire"},
                            new SubRegionItemModel{ Id = "E06000056", SubRegionName = "Central Bedfordshire"},
                            new SubRegionItemModel{ Id = "E10000012", SubRegionName = "Essex"},
                            new SubRegionItemModel{ Id = "E10000015", SubRegionName = "Hertfordshire"},
                            new SubRegionItemModel{ Id = "E06000032", SubRegionName = "Luton"},
                            new SubRegionItemModel{ Id = "E10000020", SubRegionName = "Norfolk"},
                            new SubRegionItemModel{ Id = "E06000031", SubRegionName = "Peterborough"},
                            new SubRegionItemModel{ Id = "E06000033", SubRegionName = "Southend-on-Sea"},
                            new SubRegionItemModel{ Id = "E10000029", SubRegionName = "Suffolk"},
                            new SubRegionItemModel{ Id = "E06000034", SubRegionName = "Thurrock"}
                        }
                    },
                    new RegionItemModel
                    {
                        Id = "E12000007",
                        Checked = false,
                        RegionName = "London",
                        SubRegions = new SubRegionItemModel[]
                        {
                            new SubRegionItemModel{ Id = "E09000001", SubRegionName = "City of London"},
                            new SubRegionItemModel{ Id = "E09000002", SubRegionName = "Barking and Dagenham"},
                            new SubRegionItemModel{ Id = "E09000003", SubRegionName = "Barnet"},
                            new SubRegionItemModel{ Id = "E09000004", SubRegionName = "Bexley"},
                            new SubRegionItemModel{ Id = "E09000005", SubRegionName = "Brent"},
                            new SubRegionItemModel{ Id = "E09000006", SubRegionName = "Bromley"},
                            new SubRegionItemModel{ Id = "E09000007", SubRegionName = "Camden"},
                            new SubRegionItemModel{ Id = "E09000008", SubRegionName = "Croydon"},
                            new SubRegionItemModel{ Id = "E09000009", SubRegionName = "Ealing"},
                            new SubRegionItemModel{ Id = "E09000010", SubRegionName = "Enfield"},
                            new SubRegionItemModel{ Id = "E09000011", SubRegionName = "Greenwich"},
                            new SubRegionItemModel{ Id = "E09000012", SubRegionName = "Hackney"},
                            new SubRegionItemModel{ Id = "E09000013", SubRegionName = "Hammersmith and Fulham"},
                            new SubRegionItemModel{ Id = "E09000014", SubRegionName = "Haringey"},
                            new SubRegionItemModel{ Id = "E09000015", SubRegionName = "Harrow"},
                            new SubRegionItemModel{ Id = "E09000016", SubRegionName = "Havering"},
                            new SubRegionItemModel{ Id = "E09000017", SubRegionName = "Hillingdon"},
                            new SubRegionItemModel{ Id = "E09000018", SubRegionName = "Hounslow"},
                            new SubRegionItemModel{ Id = "E09000019", SubRegionName = "Islington"},
                            new SubRegionItemModel{ Id = "E09000020", SubRegionName = "Kensington and Chelsea"},
                            new SubRegionItemModel{ Id = "E09000021", SubRegionName = "Kingston upon Thames"},
                            new SubRegionItemModel{ Id = "E09000022", SubRegionName = "Lambeth"},
                            new SubRegionItemModel{ Id = "E09000023", SubRegionName = "Lewisham"},
                            new SubRegionItemModel{ Id = "E09000024", SubRegionName = "Merton"},
                            new SubRegionItemModel{ Id = "E09000025", SubRegionName = "Newham"},
                            new SubRegionItemModel{ Id = "E09000026", SubRegionName = "Redbridge"},
                            new SubRegionItemModel{ Id = "E09000027", SubRegionName = "Richmond upon Thames"},
                            new SubRegionItemModel{ Id = "E09000028", SubRegionName = "Southwark"},
                            new SubRegionItemModel{ Id = "E09000029", SubRegionName = "Sutton"},
                            new SubRegionItemModel{ Id = "E09000030", SubRegionName = "Tower Hamlets"},
                            new SubRegionItemModel{ Id = "E09000031", SubRegionName = "Waltham Forest"},
                            new SubRegionItemModel{ Id = "E09000032", SubRegionName = "Wandsworth"},
                            new SubRegionItemModel{ Id = "E09000033", SubRegionName = "Westminster"}
                        }
                    },
                    new RegionItemModel
                    {
                        Id = "E12000008",
                        Checked = false,
                        RegionName = "South East",
                        SubRegions = new SubRegionItemModel[]
                        {
                            new SubRegionItemModel{ Id = "E06000035", SubRegionName = "Medway"},
                            new SubRegionItemModel{ Id = "E06000036", SubRegionName = "Bracknell Forest"},
                            new SubRegionItemModel{ Id = "E06000037", SubRegionName = "West Berkshire"},
                            new SubRegionItemModel{ Id = "E06000038", SubRegionName = "Reading"},
                            new SubRegionItemModel{ Id = "E06000039", SubRegionName = "Slough"},
                            new SubRegionItemModel{ Id = "E06000040", SubRegionName = "Windsor and Maidenhead"},
                            new SubRegionItemModel{ Id = "E06000041", SubRegionName = "Wokingham"},
                            new SubRegionItemModel{ Id = "E06000042", SubRegionName = "Milton Keynes"},
                            new SubRegionItemModel{ Id = "E06000043", SubRegionName = "Brighton and Hove"},
                            new SubRegionItemModel{ Id = "E06000044", SubRegionName = "Portsmouth"},
                            new SubRegionItemModel{ Id = "E06000045", SubRegionName = "Southampton"},
                            new SubRegionItemModel{ Id = "E06000046", SubRegionName = "Isle of Wight"},
                            new SubRegionItemModel{ Id = "E10000002", SubRegionName = "Buckinghamshire"},
                            new SubRegionItemModel{ Id = "E10000011", SubRegionName = "East Sussex"},
                            new SubRegionItemModel{ Id = "E10000014", SubRegionName = "Hampshire"},
                            new SubRegionItemModel{ Id = "E10000016", SubRegionName = "Kent"},
                            new SubRegionItemModel{ Id = "E10000025", SubRegionName = "Oxfordshire"},
                            new SubRegionItemModel{ Id = "E10000030", SubRegionName = "Surrey"},
                            new SubRegionItemModel{ Id = "E10000032", SubRegionName = "West Sussex"}
                        }
                    },
                    new RegionItemModel
                    {
                        Id = "E12000009",
                        Checked = false,
                        RegionName = "South West",
                        SubRegions = new SubRegionItemModel[]
                        {
                            new SubRegionItemModel{ Id = "E06000022", SubRegionName = "Bath and North East Somerset"},
                            new SubRegionItemModel{ Id = "E06000023", SubRegionName = "Bristol, City of"},
                            new SubRegionItemModel{ Id = "E06000024", SubRegionName = "North Somerset"},
                            new SubRegionItemModel{ Id = "E06000025", SubRegionName = "South Gloucestershire"},
                            new SubRegionItemModel{ Id = "E06000026", SubRegionName = "Plymouth"},
                            new SubRegionItemModel{ Id = "E06000027", SubRegionName = "Torbay"},
                            new SubRegionItemModel{ Id = "E06000028", SubRegionName = "Bournemouth"},
                            new SubRegionItemModel{ Id = "E06000029", SubRegionName = "Poole"},
                            new SubRegionItemModel{ Id = "E06000030", SubRegionName = "Swindon"},
                            new SubRegionItemModel{ Id = "E06000052", SubRegionName = "Cornwall"},
                            new SubRegionItemModel{ Id = "E06000053", SubRegionName = "Isles of Scilly"},
                            new SubRegionItemModel{ Id = "E06000054", SubRegionName = "Wiltshire"},
                            new SubRegionItemModel{ Id = "E10000008", SubRegionName = "Devon"},
                            new SubRegionItemModel{ Id = "E10000009", SubRegionName = "Dorset"},
                            new SubRegionItemModel{ Id = "E10000013", SubRegionName = "Gloucestershire"},
                            new SubRegionItemModel{ Id = "E10000027", SubRegionName = "Somerset"}
                        }
                    }

                }
            };
        }
    }
}
