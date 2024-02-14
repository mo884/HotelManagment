using HotelManagment.BLL.Feature.Finalize_bill.ModelVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagment.BLL.Feature.Finalize_bill.Queries.Interface
{
    public interface IFinalizebillRep
    {
        FinalizeBillVM GetFinalizebill(int? RoomID,int? GuestID ,int? ReservationID);
    }
}
