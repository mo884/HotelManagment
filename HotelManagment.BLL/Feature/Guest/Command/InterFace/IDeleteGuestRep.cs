using HotelManagment.DAL.Migrations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagment.BLL.Feature.Guest.Command.InterFace
{
    public interface IDeleteGuestRep
    {
        void Delete(int ID);
    }
}
