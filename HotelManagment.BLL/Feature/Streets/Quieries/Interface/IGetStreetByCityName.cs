using HotelManagment.BLL.Feature.Streets.ModelVM;
using HotelManagment.DAL.Entities.Adress;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagment.BLL.Feature.Streets.Quieries.Interface
{
    public interface IGetStreetByCityName
    {
        List<GetStreetByCityNameVM> Get(string cityName);
    }
}
