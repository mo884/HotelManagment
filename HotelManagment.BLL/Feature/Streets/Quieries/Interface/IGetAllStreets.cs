using HotelManagment.BLL.Feature.Streets.ModelVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagment.BLL.Feature.Streets.Quieries.Interface
{
    public interface IGetAllStreets
    {
        List<GetAllStreetsVM> GetAll();
    }
}
