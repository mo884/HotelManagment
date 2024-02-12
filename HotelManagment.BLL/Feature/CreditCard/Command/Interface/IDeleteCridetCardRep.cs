using HotelManagment.DAL.Migrations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagment.BLL.Feature.CreditCard.Command.Interface
{
   public interface IDeleteCridetCardRep
    {
        void Delete(int ID);
    }
}
