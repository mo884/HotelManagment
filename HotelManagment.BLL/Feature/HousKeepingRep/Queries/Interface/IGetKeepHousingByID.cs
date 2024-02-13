using HotelManagment.DAL.Entities.Reservations.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagment.BLL.Feature.HousKeepingRep.Queries.Interface
{
    public interface IGetKeepHousingByID
    {
        Housekeeping GetHousekeepingByID(int  id);  
    }
}
