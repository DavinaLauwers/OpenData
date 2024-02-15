using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenData.Core.Entities
{
    public class DrinkableWater
    {
        [JsonProperty("objectid")]
        public string Id { get; set; }
        [JsonProperty("naam")]
        public string Name { get; set; }
        [JsonProperty("straatnaam")]
        public string StreetName { get; set; }
        [JsonProperty("huisnummer")]
        public string HouseNumber { get; set; }
        [JsonProperty("postcode")]
        public string PostalCode { get; set; }
        [JsonProperty("gemeente")]
        public string City { get; set; }
        [JsonProperty("website")]
        public string Website { get; set; }
        [JsonProperty("email")]
        public string Email { get; set; }
        [JsonProperty("telefoon")]
        public string Phone { get; set; }
        [JsonProperty("trefwoord")]
        public string Keyword { get; set; }
        [JsonProperty("sectorcode")]
        public string SectorCode { get; set; }
        [JsonProperty("sectornaam")]
        public string SectorName { get; set; }
        [JsonProperty("wijkcode")]
        public string NeighbourhoodCode { get; set; }
        [JsonProperty("wijknaam")]
        public string NeighbourhoodName { get; set; }
    }
}
