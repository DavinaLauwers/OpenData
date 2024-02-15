using OpenData.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenData.Core.Services
{
    public interface IDrinkableWaterService
    {
        Task<IQueryable<DrinkableWater>> GetDrinkableWaterPlaces();
        void Add(DrinkableWater drinkableWater);
        void Update(DrinkableWater drinkableWater);
        void Delete(string id);
        DrinkableWater GetDetails(string id);
    }
}
