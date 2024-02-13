using HotelManagment.BLL.Feature.City.ModelVM;
using HotelManagment.BLL.Feature.RoomRep.ModelVM;
using HotelManagment.DAL.Entities.Adress;
using HotelManagment.DAL.Entities.RoomInfo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagment.BLL.Mapping.RoomMap.Command
{
    public static class GetRoomMapping
    {
        public static List<GetAllRoomVM> Map(List<Room> room)
        {

            List<GetAllRoomVM> getAllRoomVMs = new List<GetAllRoomVM>();
            foreach (var item in room)
            {
                getAllRoomVMs.Add(MapState(item));
            }
            return getAllRoomVMs;
        }

        private static GetAllRoomVM MapState(Room room)
        {
            GetAllRoomVM getGetAllRoomVMRep = new GetAllRoomVM()
            {
               ID = room.ID,
               RoomType = room.RoomType,
               RoomTypeID = room.RoomTypeID,
               room_number = room.room_number
            };
            return getGetAllRoomVMRep;
        }
    }
}
