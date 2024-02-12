using HotelManagment.BLL.Feature.City.ModelVM;
using HotelManagment.DAL.Entities.Adress;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagment.BLL.Mapping.CityMap.Queries
{
    public class GetAllCityMApping
    {
        public static List<GetAllCityVM> Map(List<City> city)
        {

            List<GetAllCityVM> getAllCityVMs = new List<GetAllCityVM>();
            foreach (var item in city)
            {
                getAllCityVMs.Add(MapState(item));
            }
            return getAllCityVMs;
        }

        private static GetAllCityVM MapState(City city)
        {
            GetAllCityVM getGetAllCityVMRep = new GetAllCityVM()
            {
                ID = city.ID,
                CityName = city.CityName,
                StateID = city.StateID,
                Streets = city.Streets
            };
            return getGetAllCityVMRep;
        }
    }
}
