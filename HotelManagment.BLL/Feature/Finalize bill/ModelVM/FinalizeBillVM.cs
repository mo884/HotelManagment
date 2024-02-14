using HotelManagment.BLL.Feature.Guest.ModelVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagment.BLL.Feature.Finalize_bill.ModelVM
{
    public class FinalizeBillVM
    {
        public string RoomBill { get; set; }
        public string FoodBill { get; set; }
        public string Total { get; set; }
        public GetAllGuestVM GuestVM { get; set; }

    }
}
