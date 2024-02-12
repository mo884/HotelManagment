using HotelManagment.BLL.Feature.State.ModelVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagment.BLL.Feature.State.Quieries.Interface
{
    public interface IGetAllStateRep
    {
        List<StateVM> GetAll();
    }
}
