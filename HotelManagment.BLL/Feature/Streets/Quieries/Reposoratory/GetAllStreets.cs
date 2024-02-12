using HotelManagment.BLL.Feature.Streets.ModelVM;
using HotelManagment.BLL.Feature.Streets.Quieries.Interface;
using HotelManagment.BLL.Mapping.CityMap.Queries;
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
    public class GetAllStreets : IGetAllStreets
    {
        private readonly HotelDBContext HotelDBContext;
        public GetAllStreets()
        {
            HotelDBContext = new HotelDBContext();
        }
        public List<GetAllStreetsVM> GetAll()
        {
            var Data = HotelDBContext.Streets.Include(a => a.City).ToList();
            if (Data is not null)
                return GetAllStreetsMapping.Map(Data);

            return null;
        }
    }
}
