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
                        SubRegions = new SubRegion[]
                        {
                            new SubRegion{ Id = "E06000001", Name = "County Durham"},
                            new SubRegion{ Id = "E06000002", Name = "Darlington"},
                            new SubRegion{ Id = "E06000003", Name = "Gateshead"},
                            new SubRegion{ Id = "E06000004", Name = "Hartlepool"},
                            new SubRegion{ Id = "E06000005", Name = "Middlesbrough"},
                            new SubRegion{ Id = "E06000047", Name = "Newcastle upon Tyne"},
                            new SubRegion{ Id = "E06000057", Name = "North Tyneside"},
                            new SubRegion{ Id = "E08000021", Name = "Northumberland"},
                            new SubRegion{ Id = "E08000022", Name = "Redcar and Cleveland"},
                            new SubRegion{ Id = "E08000023", Name = "South Tyneside"},
                            new SubRegion{ Id = "E08000024", Name = "Stockton-on-Tees"},
                            new SubRegion{ Id = "E08000037", Name = "Sunderland"}
                        }
                    },
                    new RegionItemModel
                    {
                        Id = "E12000002",
                        Checked = false,
                        RegionName = "North West",
                        SubRegions = new SubRegion[]
                        {
                            new SubRegion{ Id = "E06000006", Name = "Halton"},
                            new SubRegion{ Id = "E06000007", Name = "Warrington"},
                            new SubRegion{ Id = "E06000008", Name = "Blackburn with Darwen"},
                            new SubRegion{ Id = "E06000009", Name = "Blackpool"},
                            new SubRegion{ Id = "E06000049", Name = "Cheshire East"},
                            new SubRegion{ Id = "E06000050", Name = "Cheshire West and Chester"},
                            new SubRegion{ Id = "E08000001", Name = "Bolton"},
                            new SubRegion{ Id = "E08000002", Name = "Bury"},
                            new SubRegion{ Id = "E08000003", Name = "Manchester"},
                            new SubRegion{ Id = "E08000004", Name = "Oldham"},
                            new SubRegion{ Id = "E08000005", Name = "Rochdale"},
                            new SubRegion{ Id = "E08000006", Name = "Salford"},
                            new SubRegion{ Id = "E08000007", Name = "Stockport"},
                            new SubRegion{ Id = "E08000008", Name = "Tameside"},
                            new SubRegion{ Id = "E08000009", Name = "Trafford"},
                            new SubRegion{ Id = "E08000010", Name = "Wigan"},
                            new SubRegion{ Id = "E08000011", Name = "Knowsley"},
                            new SubRegion{ Id = "E08000012", Name = "Liverpool"},
                            new SubRegion{ Id = "E08000013", Name = "St. Helens"},
                            new SubRegion{ Id = "E08000014", Name = "Sefton"},
                            new SubRegion{ Id = "E08000015", Name = "Wirral"},
                            new SubRegion{ Id = "E10000006", Name = "Cumbria"},
                            new SubRegion{ Id = "E10000017", Name = "Lancashire"}

                        }
                    },
                    new RegionItemModel
                    {
                        Id = "E12000003",
                        Checked = false,
                        RegionName = "Yorkshire and The Humber",
                        SubRegions = new SubRegion[]
                        {
                            new SubRegion{ Id = "E06000010", Name = "Kingston upon Hull, City of"},
                            new SubRegion{ Id = "E06000011", Name = "East Riding of Yorkshire"},
                            new SubRegion{ Id = "E06000012", Name = "North East Lincolnshire"},
                            new SubRegion{ Id = "E06000013", Name = "North Lincolnshire"},
                            new SubRegion{ Id = "E06000014", Name = "York"},
                            new SubRegion{ Id = "E08000016", Name = "Barnsley"},
                            new SubRegion{ Id = "E08000017", Name = "Doncaster"},
                            new SubRegion{ Id = "E08000018", Name = "Rotherham"},
                            new SubRegion{ Id = "E08000019", Name = "Sheffield"},
                            new SubRegion{ Id = "E08000032", Name = "Bradford"},
                            new SubRegion{ Id = "E08000033", Name = "Calderdale"},
                            new SubRegion{ Id = "E08000034", Name = "Kirklees"},
                            new SubRegion{ Id = "E08000035", Name = "Leeds"},
                            new SubRegion{ Id = "E08000036", Name = "Wakefield"},
                            new SubRegion{ Id = "E10000023", Name = "North Yorkshire"}
                        }
                    },
                    new RegionItemModel
                    {
                        Id = "E12000004",
                        Checked = false,
                        RegionName = "East Midlands",
                        SubRegions = new SubRegion[]
                        {
                            new SubRegion{ Id = "E06000015", Name = "Derby"},
                            new SubRegion{ Id = "E10000007", Name = "Derbyshire"},
                            new SubRegion{ Id = "E06000016", Name = "Leicester"},
                            new SubRegion{ Id = "E10000018", Name = "Leicestershire"},
                            new SubRegion{ Id = "E10000019", Name = "Lincolnshire"},
                            new SubRegion{ Id = "E10000021", Name = "Northamptonshire"},
                            new SubRegion{ Id = "E06000018", Name = "Nottingham"},
                            new SubRegion{ Id = "E10000024", Name = "Nottinghamshire"},
                            new SubRegion{ Id = "E06000017", Name = "Rutland"}
                        }
                    },
                    new RegionItemModel
                    {
                        Id = "E12000005",
                        Checked = false,
                        RegionName = "West Midlands",
                        SubRegions = new SubRegion[]
                        {
                            new SubRegion{ Id = "E06000019", Name = "Herefordshire, County of"},
                            new SubRegion{ Id = "E06000020", Name = "Telford and Wrekin"},
                            new SubRegion{ Id = "E06000021", Name = "Stoke-on-Trent"},
                            new SubRegion{ Id = "E06000051", Name = "Shropshire"},
                            new SubRegion{ Id = "E08000025", Name = "Birmingham"},
                            new SubRegion{ Id = "E08000026", Name = "Coventry"},
                            new SubRegion{ Id = "E08000027", Name = "Dudley"},
                            new SubRegion{ Id = "E08000028", Name = "Sandwell"},
                            new SubRegion{ Id = "E08000029", Name = "Solihull"},
                            new SubRegion{ Id = "E08000030", Name = "Walsall"},
                            new SubRegion{ Id = "E08000031", Name = "Wolverhampton"},
                            new SubRegion{ Id = "E10000028", Name = "Staffordshire"},
                            new SubRegion{ Id = "E10000031", Name = "Warwickshire"},
                            new SubRegion{ Id = "E10000034", Name = "Worcestershire"}
                        }
                    },
                    new RegionItemModel
                    {
                        Id = "E12000006",
                        Checked = false,
                        RegionName = "East of England",
                        SubRegions = new SubRegion[]
                        {
                            new SubRegion{ Id = "E06000055", Name = "Bedford"},
                            new SubRegion{ Id = "E10000003", Name = "Cambridgeshire"},
                            new SubRegion{ Id = "E06000056", Name = "Central Bedfordshire"},
                            new SubRegion{ Id = "E10000012", Name = "Essex"},
                            new SubRegion{ Id = "E10000015", Name = "Hertfordshire"},
                            new SubRegion{ Id = "E06000032", Name = "Luton"},
                            new SubRegion{ Id = "E10000020", Name = "Norfolk"},
                            new SubRegion{ Id = "E06000031", Name = "Peterborough"},
                            new SubRegion{ Id = "E06000033", Name = "Southend-on-Sea"},
                            new SubRegion{ Id = "E10000029", Name = "Suffolk"},
                            new SubRegion{ Id = "E06000034", Name = "Thurrock"}
                        }
                    },
                    new RegionItemModel
                    {
                        Id = "E12000007",
                        Checked = false,
                        RegionName = "London",
                        SubRegions = new SubRegion[]
                        {
                            new SubRegion{ Id = "E09000001", Name = "City of London"},
                            new SubRegion{ Id = "E09000002", Name = "Barking and Dagenham"},
                            new SubRegion{ Id = "E09000003", Name = "Barnet"},
                            new SubRegion{ Id = "E09000004", Name = "Bexley"},
                            new SubRegion{ Id = "E09000005", Name = "Brent"},
                            new SubRegion{ Id = "E09000006", Name = "Bromley"},
                            new SubRegion{ Id = "E09000007", Name = "Camden"},
                            new SubRegion{ Id = "E09000008", Name = "Croydon"},
                            new SubRegion{ Id = "E09000009", Name = "Ealing"},
                            new SubRegion{ Id = "E09000010", Name = "Enfield"},
                            new SubRegion{ Id = "E09000011", Name = "Greenwich"},
                            new SubRegion{ Id = "E09000012", Name = "Hackney"},
                            new SubRegion{ Id = "E09000013", Name = "Hammersmith and Fulham"},
                            new SubRegion{ Id = "E09000014", Name = "Haringey"},
                            new SubRegion{ Id = "E09000015", Name = "Harrow"},
                            new SubRegion{ Id = "E09000016", Name = "Havering"},
                            new SubRegion{ Id = "E09000017", Name = "Hillingdon"},
                            new SubRegion{ Id = "E09000018", Name = "Hounslow"},
                            new SubRegion{ Id = "E09000019", Name = "Islington"},
                            new SubRegion{ Id = "E09000020", Name = "Kensington and Chelsea"},
                            new SubRegion{ Id = "E09000021", Name = "Kingston upon Thames"},
                            new SubRegion{ Id = "E09000022", Name = "Lambeth"},
                            new SubRegion{ Id = "E09000023", Name = "Lewisham"},
                            new SubRegion{ Id = "E09000024", Name = "Merton"},
                            new SubRegion{ Id = "E09000025", Name = "Newham"},
                            new SubRegion{ Id = "E09000026", Name = "Redbridge"},
                            new SubRegion{ Id = "E09000027", Name = "Richmond upon Thames"},
                            new SubRegion{ Id = "E09000028", Name = "Southwark"},
                            new SubRegion{ Id = "E09000029", Name = "Sutton"},
                            new SubRegion{ Id = "E09000030", Name = "Tower Hamlets"},
                            new SubRegion{ Id = "E09000031", Name = "Waltham Forest"},
                            new SubRegion{ Id = "E09000032", Name = "Wandsworth"},
                            new SubRegion{ Id = "E09000033", Name = "Westminster"}
                        }
                    },
                    new RegionItemModel
                    {
                        Id = "E12000008",
                        Checked = false,
                        RegionName = "South East",
                        SubRegions = new SubRegion[]
                        {
                            new SubRegion{ Id = "E06000035", Name = "Medway"},
                            new SubRegion{ Id = "E06000036", Name = "Bracknell Forest"},
                            new SubRegion{ Id = "E06000037", Name = "West Berkshire"},
                            new SubRegion{ Id = "E06000038", Name = "Reading"},
                            new SubRegion{ Id = "E06000039", Name = "Slough"},
                            new SubRegion{ Id = "E06000040", Name = "Windsor and Maidenhead"},
                            new SubRegion{ Id = "E06000041", Name = "Wokingham"},
                            new SubRegion{ Id = "E06000042", Name = "Milton Keynes"},
                            new SubRegion{ Id = "E06000043", Name = "Brighton and Hove"},
                            new SubRegion{ Id = "E06000044", Name = "Portsmouth"},
                            new SubRegion{ Id = "E06000045", Name = "Southampton"},
                            new SubRegion{ Id = "E06000046", Name = "Isle of Wight"},
                            new SubRegion{ Id = "E10000002", Name = "Buckinghamshire"},
                            new SubRegion{ Id = "E10000011", Name = "East Sussex"},
                            new SubRegion{ Id = "E10000014", Name = "Hampshire"},
                            new SubRegion{ Id = "E10000016", Name = "Kent"},
                            new SubRegion{ Id = "E10000025", Name = "Oxfordshire"},
                            new SubRegion{ Id = "E10000030", Name = "Surrey"},
                            new SubRegion{ Id = "E10000032", Name = "West Sussex"}
                        }
                    },
                    new RegionItemModel
                    {
                        Id = "E12000009",
                        Checked = false,
                        RegionName = "South West",
                        SubRegions = new SubRegion[]
                        {
                            new SubRegion{ Id = "E06000022", Name = "Bath and North East Somerset"},
                            new SubRegion{ Id = "E06000023", Name = "Bristol, City of"},
                            new SubRegion{ Id = "E06000024", Name = "North Somerset"},
                            new SubRegion{ Id = "E06000025", Name = "South Gloucestershire"},
                            new SubRegion{ Id = "E06000026", Name = "Plymouth"},
                            new SubRegion{ Id = "E06000027", Name = "Torbay"},
                            new SubRegion{ Id = "E06000028", Name = "Bournemouth"},
                            new SubRegion{ Id = "E06000029", Name = "Poole"},
                            new SubRegion{ Id = "E06000030", Name = "Swindon"},
                            new SubRegion{ Id = "E06000052", Name = "Cornwall"},
                            new SubRegion{ Id = "E06000053", Name = "Isles of Scilly"},
                            new SubRegion{ Id = "E06000054", Name = "Wiltshire"},
                            new SubRegion{ Id = "E10000008", Name = "Devon"},
                            new SubRegion{ Id = "E10000009", Name = "Dorset"},
                            new SubRegion{ Id = "E10000013", Name = "Gloucestershire"},
                            new SubRegion{ Id = "E10000027", Name = "Somerset"}
                        }
                    }

                }
            };
        }
    }
}
