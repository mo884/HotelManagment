using HotelManagment.BLL.Feature.Login.Command.ModelVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagment.BLL.Feature.Login.Command.Interface
{
    public interface ILoginRep
    {
        string AuthenticateUser(LoginVM loginVM);
    }
}
