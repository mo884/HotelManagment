using HotelManagment.DAL.Entities.RoomInfo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagment.BLL.Feature.RoomRep.ModelVM
{
    public class RoomRecordVM
    {
       public List<RoomVM> RroomRecord { get; set; }
        public List<RoomVM> RoomNotRecord { get; set; }

    }
}
