using HotelManagment.BLL.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagment.BLL.Feature.HousKeepingRep.Command.Interface
{
    public interface IAddHousKeepingRep
    {
        void Add(CheckClean checkClean);
    }
}
