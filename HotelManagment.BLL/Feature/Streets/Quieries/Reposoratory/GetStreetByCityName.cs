using HotelManagment.BLL.Feature.Streets.ModelVM;
using HotelManagment.BLL.Feature.Streets.Quieries.Interface;
using HotelManagment.BLL.Mapping.StreetsMapp.Queries;
using HotelManagment.DAL.Database;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagment.BLL.Feature.Streets.Quieries.Reposoratory
{
    public class GetStreetByCityName : IGetStreetByCityName
    {

        private readonly HotelDBContext HotelDBContext;
        public GetStreetByCityName()
        {
            HotelDBContext = new HotelDBContext();
        }
        public List<GetStreetByCityNameVM> Get(string cityName)
        {
            var Data = HotelDBContext.Streets.Include(a => a.City).Where(a => a.City.CityName == cityName).ToList();
            if (Data is not null)
            return GetStreetByCityNameMapping.Map(Data);
            return null;
        }
    }
}
