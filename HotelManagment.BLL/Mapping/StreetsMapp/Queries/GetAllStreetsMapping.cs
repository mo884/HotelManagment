using HotelManagment.BLL.Feature.State.ModelVM;
using HotelManagment.BLL.Feature.Streets.ModelVM;
using HotelManagment.DAL.Entities.Adress;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagment.BLL.Mapping.StreetsMapp.Queries
{
    public static class GetAllStreetsMapping
    {
        public static List<GetAllStreetsVM> Map(List<Streets> streets)
        {

            List<GetAllStreetsVM> getAllStreetsVMs = new List<GetAllStreetsVM>();
            foreach (var item in streets)
            {
                getAllStreetsVMs.Add(MapState(item));
            }
            return getAllStreetsVMs;
        }

        private static GetAllStreetsVM MapState(Streets state)
        {
            GetAllStreetsVM getAllStateRep = new GetAllStreetsVM()
            {
                ID = state.ID,
                Street_Adress = state.Street_Adress,
                City = state.City,
                CityID = state.CityID,
            };
            return getAllStateRep;
        }
    }
}
