using HotelManagment.BLL.Feature.Guest.ModelVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagment.BLL.Feature.Guest.Queries.InterFace
{
    public interface IGetAllGuestRep
    {
        List<GetAllGuestVM> GetAll();
    }
}
