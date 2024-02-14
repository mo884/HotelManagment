using HotelManagment.BLL.Feature.Finalize_bill.ModelVM;
using HotelManagment.BLL.Feature.Finalize_bill.Queries.Interface;
using HotelManagment.BLL.Feature.Guest.ModelVM;
using HotelManagment.DAL.Database;
using HotelManagment.DAL.Entities.GuestInfo;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagment.BLL.Feature.Finalize_bill.Queries.Reposoratory
{
    public class FinalizebillRep : IFinalizebillRep
    {
        private readonly HotelDBContext hotelDBContext;
        public FinalizebillRep()
        {
            hotelDBContext = new HotelDBContext();
        }
        public FinalizeBillVM GetFinalizebill(int? RoomID, int? GuestID, int? ReservationID)
        {
            FinalizeBillVM finalizeBillVM = new FinalizeBillVM();
            var DataRoom = hotelDBContext.Rooms.Where(a => a.ID==RoomID).Include(a => a.RoomType).FirstOrDefault();
            var DataReservation = hotelDBContext.MealInfos.Where(a => a.ID==ReservationID).FirstOrDefault();
            finalizeBillVM.FoodBill = DataReservation.FoodBill.ToString();
            finalizeBillVM.RoomBill= DataRoom.RoomType.Price.ToString();
            finalizeBillVM.Total =  (DataReservation.FoodBill +DataRoom.RoomType.Price).ToString();
            finalizeBillVM.GuestVM = new GetAllGuestVM();
            finalizeBillVM.GuestVM.CreditCared =hotelDBContext.Guests.Where(a => a.Id==GuestID).Include(a=>a.CreditCared).FirstOrDefault().CreditCared;
            return finalizeBillVM;
        }
    }
}
