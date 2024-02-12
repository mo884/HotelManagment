using HotelManagment.BLL.Feature.CreditCard.ModelVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagment.BLL.Feature.CreditCard.Command.Interface
{
    public interface IAddCridetCardRep
    {
        void Add(AddCridetVM addCridetVM);
    }
}
