using HotelManagment.BLL.Feature.Streets.ModelVM;
using HotelManagment.DAL.Entities.Adress;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagment.BLL.Mapping.StreetsMapp.Queries
{
    public static class GetStreetByCityNameMapping
    {
        public static List< GetStreetByCityNameVM> Map(List<Streets> streets)
        {
            List<GetStreetByCityNameVM> getStreetByCityNameVM = new List<GetStreetByCityNameVM>();
            foreach (var street in streets) 
            {
                getStreetByCityNameVM.Add(MapIndividual(street));
            }
            

            return getStreetByCityNameVM;
        }
        public static GetStreetByCityNameVM MapIndividual(Streets streets)
        {
            GetStreetByCityNameVM getStreetByCityNameVM= new GetStreetByCityNameVM()
            {
                ID = streets.ID,
                City =streets.City,
                CityID = streets.CityID,
                Street_Adress = streets.Street_Adress
            };
            return getStreetByCityNameVM;
        }
    }
}
