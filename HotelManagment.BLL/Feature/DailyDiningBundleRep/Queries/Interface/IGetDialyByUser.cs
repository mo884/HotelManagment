using HotelManagment.DAL.Entities.Reservations.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagment.BLL.Feature.DailyDiningBundleRep.Queries.Interface
{
    public interface IGetDialyByUser
    {
        List<DailyDiningBundle> Get();
    }
}
