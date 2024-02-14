using HotelManagment.BLL.Feature.MenuInfo.ModelVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagment.BLL.Feature.MenuInfo.Command.Interface
{
    public interface IAddMenuInfoRep
    {
        void Add(MenuInfoVM menuInfoVM);
    }
}
