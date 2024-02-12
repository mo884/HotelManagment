using HotelManagment.BLL.Feature.Guest.ModelVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagment.BLL.Feature.Guest.Command.InterFace
{
    public interface IAddGuestRep
    {
        void Add(AddGuestVM addGuestVM);
    }
}
