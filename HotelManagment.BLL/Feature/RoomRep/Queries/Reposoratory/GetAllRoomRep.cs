using HotelManagment.BLL.Feature.RoomRep.ModelVM;
using HotelManagment.BLL.Feature.RoomRep.Queries.Interface;
using HotelManagment.BLL.Mapping.RoomMap.Command;
using HotelManagment.DAL.Database;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagment.BLL.Feature.RoomRep.Queries.Reposoratory
{
    public class GetAllRoomRep : IGetAllRoomRep
    {
        private readonly HotelDBContext HotelDBContext;
        public GetAllRoomRep()
        {
            HotelDBContext = new HotelDBContext();
        }
        public List<GetAllRoomVM> Get()
        { var Data = HotelDBContext.Rooms.Include(a => a.RoomType).ToList();
           if(Data is not null)
                return GetRoomMapping.Map(Data);
            return null;
        }
    }
}
