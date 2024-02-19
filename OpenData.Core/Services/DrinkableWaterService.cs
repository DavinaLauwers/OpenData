using Newtonsoft.Json;
using OpenData.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenData.Core.Services
{
    public class DrinkableWaterService : IDrinkableWaterService
    {
        private string jsonData = Path.GetFullPath(@"../OpenData.Core/Data/drinkwaterplekken-gent.json");
        private List<DrinkableWater> _mywaters = new List<DrinkableWater>();
        int newId = 1;

        public DrinkableWaterService()
        {
            GetList();
        }

        public Task<IQueryable<DrinkableWater>> GetDrinkableWaterPlaces()
        {
            return Task.FromResult(_mywaters.AsQueryable());
        }

        public void Add(DrinkableWater drinkableWater)
        {
            drinkableWater.Id = "B-" + newId;
            _mywaters.Add(drinkableWater);
            newId++;
        }

        public void Delete(string id)
        {
            var water = _mywaters.SingleOrDefault(x => x.Id == id);
            _mywaters.Remove(water);
        }

        public DrinkableWater GetDetails(string id)
        {
            var water = _mywaters.SingleOrDefault(x => x.Id == id);
            var waterDetails = new DrinkableWater()
            {
                Id = water.Id,
                Name = water.Name,
                StreetName = water.StreetName,
                HouseNumber = water.HouseNumber,
                PostalCode = water.PostalCode,
                City = water.City,
                Website = water.Website,
                Email = water.Email,
                SectorCode = water.SectorCode,
                SectorName = water.SectorName,
                NeighbourhoodCode = water.NeighbourhoodCode,
                NeighbourhoodName = water.NeighbourhoodName,
                Keyword = water.Keyword,
                Phone = water.Phone,
            };
            return waterDetails;
        }

        public void Update(DrinkableWater drinkableWater)
        {
            DrinkableWater drinkableWaterToUpdate = _mywaters.SingleOrDefault(x => x.Id == drinkableWater.Id);
            drinkableWaterToUpdate.Id = drinkableWater.Id;
            drinkableWaterToUpdate.Name = drinkableWater.Name;
            drinkableWaterToUpdate.StreetName = drinkableWater.StreetName;
            drinkableWaterToUpdate.HouseNumber = drinkableWater.HouseNumber;
            drinkableWaterToUpdate.PostalCode = drinkableWater.PostalCode;
            drinkableWaterToUpdate.City = drinkableWater.City;
            drinkableWaterToUpdate.Website = drinkableWater.Website;
            drinkableWaterToUpdate.Email = drinkableWater.Email;
            drinkableWaterToUpdate.SectorCode = drinkableWater.SectorCode;
            drinkableWaterToUpdate.SectorName = drinkableWater.SectorName;
            drinkableWaterToUpdate.NeighbourhoodCode = drinkableWater.NeighbourhoodCode;
            drinkableWaterToUpdate.NeighbourhoodName = drinkableWater.NeighbourhoodName;
            drinkableWaterToUpdate.Phone = drinkableWater.Phone;
            drinkableWaterToUpdate.Keyword = drinkableWater.Keyword;
        }

        private void GetList()
        {
            var getWaters = JsonConvert.DeserializeObject<ICollection<DrinkableWater>>(File.ReadAllText(jsonData));

            int idCount = 1;
            foreach (var water in getWaters)
            {
                if (water.Id == "0" || water.Id == null)
                {
                    water.Id = "A-" + idCount;
                    idCount++;
                }

                DrinkableWater drinkableWater = new DrinkableWater
                {
                    Id = water.Id,
                    Name = water.Name,
                    StreetName = water.StreetName,
                    HouseNumber = water.HouseNumber,
                    PostalCode = water.PostalCode,
                    City = water.City,
                    Website = water.Website,
                    Email = water.Email,
                    SectorCode = water.SectorCode,
                    SectorName = water.SectorName,
                    NeighbourhoodCode = water.NeighbourhoodCode,
                    NeighbourhoodName = water.NeighbourhoodName,
                    Phone = water.Phone,
                    Keyword = water.Keyword,
                };
                _mywaters.Add(drinkableWater);
            }
        }
    }
}
