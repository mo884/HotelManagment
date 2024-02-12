using HotelManagment.BLL.Feature.City.ModelVM;
using HotelManagment.BLL.Feature.City.Quieries.Interface;
using HotelManagment.BLL.Mapping.CityMap.Queries;
using HotelManagment.BLL.Mapping.StateMap.Queries;
using HotelManagment.DAL.Database;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagment.BLL.Feature.City.Quieries.Reposoratory
{
    public class GetAllCity : IGetAllCityRep
    {
        private readonly HotelDBContext HotelDBContext;
        public GetAllCity()
        {
            HotelDBContext = new HotelDBContext();
        }
        public List<GetAllCityVM> GetAll()
        {
            var Data = HotelDBContext.City.Include(a=>a.Streets).ToList();
            if (Data is not null)
                return GetAllCityMApping.Map(Data);

            return null;
        }
    }
}
