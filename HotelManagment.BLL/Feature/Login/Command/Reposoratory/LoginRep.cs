using HotelManagment.BLL.Feature.Login.Command.Interface;
using HotelManagment.BLL.Feature.Login.Command.ModelVM;
using HotelManagment.DAL.Database;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagment.BLL.Feature.Login.Command.Reposoratory
{
    public class LoginRep : ILoginRep
    {
        private readonly HotelDBContext hotelDBContext;
        public LoginRep()
        {
            hotelDBContext = new HotelDBContext();
        }
        public string AuthenticateUser(LoginVM loginVM)
        {
            var user = hotelDBContext.UserIdentities.FirstOrDefault(u => u.UserName == loginVM.UserName);

            if (user != null)
            {
                if (VerifyPassword(loginVM.Password, user.Passward))
                {
                    
                    return $"{user.Type}";
                }
            }

            // Either the user was not found or the passwords did not match
            return null;
        }

        private bool VerifyPassword(string password, string passwordHash)
        {
            return password == passwordHash;
        }
    }
}
