using HotelManagment.BLL.Feature.MenuInfo.ModelVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagment.BLL.Feature.MenuInfo.Queries.Interface
{
    public interface IGetMenuInfoRepoBYID
    {
        MenuInfoVM Get(int id);
    }
}
