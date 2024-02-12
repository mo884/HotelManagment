using HotelManagment.BLL.Feature.City.ModelVM;
using HotelManagment.BLL.Feature.State.Quieries.Reposoratory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagment.BLL.Feature.City.Quieries.Interface
{
    public interface IGetAllCityRep
    {
        List<GetAllCityVM> GetAll();
    }
}
