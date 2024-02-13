using HotelManagment.BLL.Feature.RoomRep.ModelVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagment.BLL.Feature.RoomRep.Queries.Interface
{
    public interface  IGetAllRoomRep
    {
        List<GetAllRoomVM> Get();
    }
}
