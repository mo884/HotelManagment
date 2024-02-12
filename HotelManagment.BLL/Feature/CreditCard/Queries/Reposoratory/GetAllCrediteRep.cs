using HotelManagment.BLL.Feature.CreditCard.ModelVM;
using HotelManagment.BLL.Feature.CreditCard.Queries.Interface;
using HotelManagment.BLL.Feature.Guest.ModelVM;
using HotelManagment.BLL.Mapping.CrediteCard.Queries;
using HotelManagment.BLL.Mapping.GuestMap.Queries;
using HotelManagment.DAL.Database;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagment.BLL.Feature.CreditCard.Queries.Reposoratory
{
    public class GetAllCrediteRep : IGetAllCrediteRep
    {
        private readonly HotelDBContext HotelDBContext;
        public GetAllCrediteRep()
        {
            HotelDBContext = new HotelDBContext();
        }
        public List<GetAllCridetVM> GetAll()
        {
            var Data = HotelDBContext.CreditCared.Include(a => a.Guest).ToList();
            if (Data is not null)
                return GetAllCrediteMapping.Map(Data);
            return null;
        }
    }
}
