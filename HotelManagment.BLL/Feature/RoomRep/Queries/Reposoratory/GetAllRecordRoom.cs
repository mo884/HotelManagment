using HotelManagment.BLL.Feature.Reservations.ModelVM;
using HotelManagment.BLL.Feature.RoomRep.ModelVM;
using HotelManagment.DAL.Database;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagment.BLL.Feature.RoomRep.Queries.Reposoratory
{
    public class GetAllRecordRoom
    {
        private readonly HotelDBContext HotelDBContext;
        public GetAllRecordRoom()
        {
            HotelDBContext = new HotelDBContext();
        }
        public RoomRecordVM Get()
        {
            RoomRecordVM roomRecordVM = new RoomRecordVM();
            roomRecordVM.RoomNotRecord=new();
            roomRecordVM.RroomRecord=new();
            var Rooms = HotelDBContext.Rooms.Include(a => a.RoomType).ToList();
            foreach (var item in Rooms)
            {
                var Data = HotelDBContext.Resrvations.Where(a => a.RoomID==item.ID).FirstOrDefault();
                RoomVM roomVM = new RoomVM() { Price=item.RoomType.Price,room_number=item.room_number,room_floor=item.RoomType.room_floor,room_type=item.RoomType.room_type };
                if (Data!=null)
                {
                    roomRecordVM.RroomRecord.Add(roomVM);
                }
                else
                {
                    roomRecordVM.RoomNotRecord.Add(roomVM);

                }
            }
            return roomRecordVM;
        }
    }
}
